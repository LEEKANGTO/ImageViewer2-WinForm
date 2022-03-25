using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer2WinForm
{
    public partial class OptionForm : Form
    {
        private bool loadZoominit;
        private int CornerFastTh;
        private String prevText;

        public OptionForm()
        {
            InitializeComponent();
            loadZoominit = Properties.Settings.Default.LoadZoomInit;
            CornerFastTh = Properties.Settings.Default.FastThreshold;
            prevText = CornerFastTh.ToString();
        }

        private void treeViewOption_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int ControlX = 15;
            int ControlY = 25;
            int ControlHeight = 20;
            if(e.Node.Text == "Image Load")
            {
                CheckBox chkBox = new CheckBox();
                String strText = "이미지를 로드할 때 확대 비율 초기화";
                chkBox.Text = strText;
                chkBox.Name = String.Format("checkBoxLoadZoomInit");
                int textWidth = GetTextWidth(strText.Length, 16);
                chkBox.Size = new Size(textWidth, ControlHeight);
                chkBox.Location = new Point(ControlX, ControlY);
                if (loadZoominit)
                {
                    chkBox.Checked = loadZoominit;
                }
                chkBox.Click += new_chkBox_Click;

                groupBoxParmeter.Controls.Add(chkBox);
            }
            else if(e.Node.Text == "Corner")
            {
                Label lbl = new Label();
                String strText = "FAST Threshold: ";
                lbl.Text = strText;
                lbl.Name = String.Format("labelFastThreshold");
                int textWidth = GetTextWidth(strText.Length, 7);
                lbl.Size = new Size(textWidth, ControlHeight);
                lbl.Location = new Point(ControlX, ControlY);
                TextBox textBox = new TextBox();
                textBox.Name = String.Format("textBoxThreshold");
                textBox.Size = new Size(100, ControlHeight);
                textBox.Location = new Point(textWidth+15, ControlY-5);
                textBox.Text = String.Format("{0}", CornerFastTh);
                textBox.TextChanged += new EventHandler(textBoxTextChanged);
                groupBoxParmeter.Controls.Add(lbl);
                groupBoxParmeter.Controls.Add(textBox);
            }
        }
        private void textBoxTextChanged(object sender, EventArgs e)
        {
            TextBox hTextBox = (TextBox)sender;
        
            double value = 0;
            if(double.TryParse(hTextBox.Text, out value) == false)
            {
                hTextBox.Text = prevText;
                hTextBox.Select(hTextBox.Text.Length, 0);
            }
            else
            {
                prevText = hTextBox.Text;
                CornerFastTh = int.Parse(hTextBox.Text);
            }
        }

        private void new_chkBox_Click(object sender, EventArgs e)
        {
            CheckBox chkBox = (CheckBox)sender;
            if (chkBox.Checked)
            {
                loadZoominit = true;
            }
            else
            {
                loadZoominit = false;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LoadZoomInit = loadZoominit;
            Properties.Settings.Default.FastThreshold = CornerFastTh;
            Properties.Settings.Default.Save();
            
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int GetTextWidth(int textLength, int ratio) { return textLength * ratio; }
    }
}
