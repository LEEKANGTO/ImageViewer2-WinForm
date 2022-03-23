using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;

namespace ImageViewer2WinForm
{
    public partial class Form1 : Form
    {
        private int x1;
        private int y1;
        private bool ImageLoaded = false;
        private Mat image = null;
        private MatType imageType;
        private int red;
        private int green;
        private int blue;
        private int gray;

        public Form1()
        {
            InitializeComponent();
            InitControl();
            InitMouseMoveEvent();
        }

        public void InitControl()
        {
            toolStripStatusLabelVer.Text = String.Format("Ver: {0}", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());
        }

        public void InitMouseMoveEvent()
        {
            this.pictureBoxImage.MouseMove += PictureBox_MouseMove;
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (ImageLoaded)
            {
                this.pictureBoxImage.Cursor = GetPictureBoxRect(this.pictureBoxImage).Contains(e.Location) ? Cursors.Cross : Cursors.Default;
                ConvertPictureBoxCoordinates(this.pictureBoxImage, out this.x1, out this.y1, e.X, e.Y);
                this.toolStripStatusLabelPos.Text = String.Format("X: {0} Y: {1} ", x1, y1);
                if (imageType == MatType.CV_8UC3)
                {
                    GetImgPixelRGBValue(out this.red, out this.green, out this.blue, x1, y1);
                    toolStripStatusLabelPixelValue.Text = String.Format("R: {0} G: {1} B: {2}", red, green, blue);
                }
                else if (imageType == MatType.CV_8UC1)
                {
                    GetImgPixelGrayValue(out this.gray, x1, y1);
                    toolStripStatusLabelPixelValue.Text = String.Format("Gray: {0}", gray);
                }

            }
        }

        private Rectangle GetPictureBoxRect(PictureBox box)
        {
            System.Drawing.Size si = box.Size;
            System.Drawing.Size sp = box.ClientSize;
            float ri = 1f * si.Width / si.Height;
            float rp = 1f * sp.Width / sp.Height;
            if (rp > ri)
            {
                int width = si.Width * sp.Height / si.Height;
                int left = (sp.Width - width) / 2;
                return new Rectangle(left, 0, width, sp.Height);
            }
            else
            {
                int height = si.Height * sp.Width / si.Width;
                int top = (sp.Height - height) / 2;
                return new Rectangle(0, top, sp.Width, height);
            }
        }
        private void ConvertPictureBoxCoordinates(PictureBox box, out int targetX, out int targetY, int srcX, int srcY)
        {
            int boxWidth = box.ClientSize.Width;
            int boxHeight = box.ClientSize.Height;
            int imgwidth = box.Image.Width;
            int imgHeight = box.Image.Height;

            targetX = srcX;
            targetY = srcY;

            switch (box.SizeMode)
            {
                case PictureBoxSizeMode.AutoSize:
                case PictureBoxSizeMode.Normal:
                case PictureBoxSizeMode.CenterImage:
                case PictureBoxSizeMode.Zoom:
                    break;
                case PictureBoxSizeMode.StretchImage:
                    targetX = (int)(imgwidth * srcX / (float)boxWidth);
                    targetY = (int)(imgHeight * srcY / (float)boxHeight);
                    break;
            }

        }
        private void GetImgPixelRGBValue(out int red, out int green, out int blue, int x1, int y1)
        {
            //TypeSpecificMat (faster)
            var mat3 = new Mat<Vec3b>(image);
            var indexer = mat3.GetIndexer();
            Vec3b color = indexer[y1, x1];
            byte temp = color.Item0;
            color.Item0 = color.Item2;
            color.Item2 = temp;
            indexer[y1, x1] = color;

            red = color.Item0;
            green = color.Item1;
            blue = color.Item2;
        }

        private void GetImgPixelGrayValue(out int gray, int x1, int y1)
        {
            var mat1 = new Mat<Byte>(image);
            var indexer = mat1.GetIndexer();
            gray = indexer[y1, x1];
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadImage(dlg.FileName);
            }
        }

        private void LoadImage(String fileName)
        {
            image = Cv2.ImRead(fileName, ImreadModes.Unchanged);
            imageType = image.Type();
            pictureBoxImage.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(image);
            ImageLoaded = true;

        }
    }
}
