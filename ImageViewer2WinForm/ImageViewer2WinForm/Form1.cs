using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        //https://ella-devblog.tistory.com/6
        private double ratio = 1.0F;
        private System.Drawing.Point LastPoint;
        private System.Drawing.Point imgPoint;
        private System.Drawing.Point clickPoint;
        private Rectangle imgRect;


        public Form1()
        {
            InitializeComponent();
            InitControl();
            InitMouseEvent();

        }
        public void InitMouseEvent()
        {
            InitMouseMoveEvent();
            InitMouseWheelEvent();

        }

        public void InitMouseWheelEvent()
        {
            pictureBoxImage.MouseWheel += new MouseEventHandler(PictureBox_MouseWheel);
            imgPoint = new System.Drawing.Point(pictureBoxImage.Width / 2, pictureBoxImage.Height / 2);
            imgRect = new Rectangle(0, 0, pictureBoxImage.Width, pictureBoxImage.Height);
            ratio = 1.0;
            clickPoint = imgPoint;
        }

        private void PictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            int lines = e.Delta * SystemInformation.MouseWheelScrollLines / 120;
            PictureBox pb = (PictureBox)sender;

            if (lines > 0)
            {
                ratio *= 1.1F;
                if (ratio > 100.0) ratio = 100.0f;

                imgRect.Width = (int)Math.Round(pictureBoxImage.Width * ratio);
                imgRect.Height = (int)Math.Round(pictureBoxImage.Height * ratio);
                imgRect.X = -(int)Math.Round(1.1F * (imgPoint.X - imgRect.X) - imgPoint.X);
                imgRect.Y = -(int)Math.Round(1.1F * (imgPoint.Y - imgRect.Y) - imgPoint.Y);
            }
            else if (lines < 0)
            {
                ratio *= 0.9F;
                if (ratio < 1) ratio = 1;

                imgRect.Width = (int)Math.Round(pictureBoxImage.Width * ratio);
                imgRect.Height = (int)Math.Round(pictureBoxImage.Height * ratio);
                imgRect.X = -(int)Math.Round(0.9F * (imgPoint.X - imgRect.X) - imgPoint.X);
                imgRect.Y = -(int)Math.Round(0.9F * (imgPoint.Y - imgRect.Y) - imgPoint.Y);
            }

            if (imgRect.X > 0) imgRect.X = 0;
            if (imgRect.Y > 0) imgRect.Y = 0;
            if (imgRect.X + imgRect.Width < pictureBoxImage.Width) imgRect.X = pictureBoxImage.Width - imgRect.Width;
            if (imgRect.Y + imgRect.Height < pictureBoxImage.Height) imgRect.Y = pictureBoxImage.Height - imgRect.Height;
            pictureBoxImage.Invalidate();
            toolStripStatusLabelRatio.Text = String.Format("Zoom Ratio: {0}", ratio);
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
                if (e.Button == MouseButtons.Left)
                {
                    imgRect.X = imgRect.X + (int)Math.Round((double)(e.X - clickPoint.X) / 5);
                    if (imgRect.X >= 0) imgRect.X = 0;
                    if (Math.Abs(imgRect.X) >= Math.Abs(imgRect.Width - pictureBoxImage.Width)) imgRect.X = -(imgRect.Width - pictureBoxImage.Width);
                    imgRect.Y = imgRect.Y + (int)Math.Round((double)(e.Y - clickPoint.Y) / 5);
                    if (imgRect.Y >= 0) imgRect.Y = 0;
                    if (Math.Abs(imgRect.Y) >= Math.Abs(imgRect.Height - pictureBoxImage.Height)) imgRect.Y = -(imgRect.Height - pictureBoxImage.Height);
                    pictureBoxImage.Invalidate();
                }
                else
                {
                    LastPoint = e.Location;
                    imgPoint = new System.Drawing.Point(e.X, e.Y);
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
        }

        private void pictureBoxImage_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBoxImage.Image != null)
            {
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

                e.Graphics.DrawImage(pictureBoxImage.Image, imgRect);
                pictureBoxImage.Focus();
            }
        }

        private void pictureBoxImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                clickPoint = new System.Drawing.Point(e.X, e.Y);
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
            toolStripStatusLabelSize.Text = String.Format("{0}*{1}", image.Width, image.Height);
            InitImageRatio();
            pictureBoxImage.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(image);
            ImageLoaded = true;
            pictureBoxImage.Invalidate();
        }

        private void InitImageRatio()
        {
            imgRect.X = 0;
            imgRect.Y = 0;
            ratio = 1.0F;
            imgRect.Width = (int)Math.Round(pictureBoxImage.Width * ratio);
            imgRect.Height = (int)Math.Round(pictureBoxImage.Height * ratio);
            toolStripStatusLabelRatio.Text = String.Format("Zoom Ratio: {0}", ratio);
        }

        private void programExitXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void optionOToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}