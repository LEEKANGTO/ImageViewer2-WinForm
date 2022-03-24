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
        public OptionForm()
        {
            InitializeComponent();
            loadZoominit = Properties.Settings.Default.LoadZoomInit;
        }

        private void treeViewOption_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Text == "Image Load")
            {
                CheckBox chkBox = new CheckBox();
                String strText = "이미지를 로드할 때 확대 비율을 초기화";
                int textLength = strText.Length * 16;
                chkBox.Text = strText;
                chkBox.Name = String.Format("checkBoxLoadZoomInit");
                chkBox.Size = new Size(textLength, 20);
                chkBox.Location = new Point(15, 25);
                if (loadZoominit)
                {
                    chkBox.Checked = loadZoominit;
                }
                chkBox.Click += new_chkBox_Click;

                groupBoxParmeter.Controls.Add(chkBox);
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
            Properties.Settings.Default.Save();
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
