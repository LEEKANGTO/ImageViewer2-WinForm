namespace ImageViewer2WinForm
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLoad = new System.Windows.Forms.Button();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelVer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelType = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPos = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPixelValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelRatio = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programExitXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imageIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipVerticallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipHorizontallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateClockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateCounterClockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cornerDetectCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodFeatrueToTrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.harrisCornerDetectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fASTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonNextLoad = new System.Windows.Forms.Button();
            this.buttonPrevLoad = new System.Windows.Forms.Button();
            this.buttonColorToGray = new System.Windows.Forms.Button();
            this.statusStripMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(6, 3);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(87, 33);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load(&L)...";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelVer,
            this.toolStripStatusLabelFileName,
            this.toolStripStatusLabelSize,
            this.toolStripStatusLabelType,
            this.toolStripStatusLabelPos,
            this.toolStripStatusLabelPixelValue,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelRatio});
            this.statusStripMain.Location = new System.Drawing.Point(0, 506);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1055, 24);
            this.statusStripMain.TabIndex = 14;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabelVer
            // 
            this.toolStripStatusLabelVer.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelVer.Name = "toolStripStatusLabelVer";
            this.toolStripStatusLabelVer.Size = new System.Drawing.Size(29, 19);
            this.toolStripStatusLabelVer.Text = "Ver";
            // 
            // toolStripStatusLabelFileName
            // 
            this.toolStripStatusLabelFileName.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelFileName.Name = "toolStripStatusLabelFileName";
            this.toolStripStatusLabelFileName.Size = new System.Drawing.Size(61, 19);
            this.toolStripStatusLabelFileName.Text = "FileName";
            // 
            // toolStripStatusLabelSize
            // 
            this.toolStripStatusLabelSize.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelSize.Name = "toolStripStatusLabelSize";
            this.toolStripStatusLabelSize.Size = new System.Drawing.Size(33, 19);
            this.toolStripStatusLabelSize.Text = "Size";
            // 
            // toolStripStatusLabelType
            // 
            this.toolStripStatusLabelType.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelType.Name = "toolStripStatusLabelType";
            this.toolStripStatusLabelType.Size = new System.Drawing.Size(36, 19);
            this.toolStripStatusLabelType.Text = "Type";
            // 
            // toolStripStatusLabelPos
            // 
            this.toolStripStatusLabelPos.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelPos.Name = "toolStripStatusLabelPos";
            this.toolStripStatusLabelPos.Size = new System.Drawing.Size(30, 19);
            this.toolStripStatusLabelPos.Text = "Pos";
            // 
            // toolStripStatusLabelPixelValue
            // 
            this.toolStripStatusLabelPixelValue.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelPixelValue.Name = "toolStripStatusLabelPixelValue";
            this.toolStripStatusLabelPixelValue.Size = new System.Drawing.Size(41, 19);
            this.toolStripStatusLabelPixelValue.Text = "Value";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(736, 19);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // toolStripStatusLabelRatio
            // 
            this.toolStripStatusLabelRatio.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelRatio.Name = "toolStripStatusLabelRatio";
            this.toolStripStatusLabelRatio.Size = new System.Drawing.Size(74, 19);
            this.toolStripStatusLabelRatio.Text = "Zoom Ratio";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileFToolStripMenuItem,
            this.ToolStripMenuItem,
            this.imageIToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1055, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileFToolStripMenuItem
            // 
            this.fileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadLToolStripMenuItem,
            this.programExitXToolStripMenuItem});
            this.fileFToolStripMenuItem.Name = "fileFToolStripMenuItem";
            this.fileFToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.fileFToolStripMenuItem.Text = "File(&F)";
            // 
            // loadLToolStripMenuItem
            // 
            this.loadLToolStripMenuItem.Name = "loadLToolStripMenuItem";
            this.loadLToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.loadLToolStripMenuItem.Text = "Load(&L)";
            this.loadLToolStripMenuItem.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // programExitXToolStripMenuItem
            // 
            this.programExitXToolStripMenuItem.Name = "programExitXToolStripMenuItem";
            this.programExitXToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.programExitXToolStripMenuItem.Text = "Program Exit(&X)";
            this.programExitXToolStripMenuItem.Click += new System.EventHandler(this.programExitXToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionOToolStripMenuItem1});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ToolStripMenuItem.Text = "Tools(&T)";
            // 
            // optionOToolStripMenuItem1
            // 
            this.optionOToolStripMenuItem1.Name = "optionOToolStripMenuItem1";
            this.optionOToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.optionOToolStripMenuItem1.Text = "Option(&O)";
            this.optionOToolStripMenuItem1.Click += new System.EventHandler(this.optionOToolStripMenuItem1_Click);
            // 
            // imageIToolStripMenuItem
            // 
            this.imageIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flipFToolStripMenuItem,
            this.rotateRToolStripMenuItem,
            this.toolStripSeparator1,
            this.cornerDetectCToolStripMenuItem});
            this.imageIToolStripMenuItem.Name = "imageIToolStripMenuItem";
            this.imageIToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.imageIToolStripMenuItem.Text = "Image(&I)";
            // 
            // flipFToolStripMenuItem
            // 
            this.flipFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flipVerticallyToolStripMenuItem,
            this.flipHorizontallyToolStripMenuItem});
            this.flipFToolStripMenuItem.Name = "flipFToolStripMenuItem";
            this.flipFToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.flipFToolStripMenuItem.Text = "Flip(&F)";
            // 
            // flipVerticallyToolStripMenuItem
            // 
            this.flipVerticallyToolStripMenuItem.Name = "flipVerticallyToolStripMenuItem";
            this.flipVerticallyToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.flipVerticallyToolStripMenuItem.Text = "Flip Vertically";
            this.flipVerticallyToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItemBtnClick);
            // 
            // flipHorizontallyToolStripMenuItem
            // 
            this.flipHorizontallyToolStripMenuItem.Name = "flipHorizontallyToolStripMenuItem";
            this.flipHorizontallyToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.flipHorizontallyToolStripMenuItem.Text = "Flip Horizontally";
            this.flipHorizontallyToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItemBtnClick);
            // 
            // rotateRToolStripMenuItem
            // 
            this.rotateRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotateClockwiseToolStripMenuItem,
            this.rotateCounterClockwiseToolStripMenuItem});
            this.rotateRToolStripMenuItem.Name = "rotateRToolStripMenuItem";
            this.rotateRToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.rotateRToolStripMenuItem.Text = "Rotate(&R)";
            // 
            // rotateClockwiseToolStripMenuItem
            // 
            this.rotateClockwiseToolStripMenuItem.Name = "rotateClockwiseToolStripMenuItem";
            this.rotateClockwiseToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.rotateClockwiseToolStripMenuItem.Text = "Rotate clockwise";
            this.rotateClockwiseToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItemBtnClick);
            // 
            // rotateCounterClockwiseToolStripMenuItem
            // 
            this.rotateCounterClockwiseToolStripMenuItem.Name = "rotateCounterClockwiseToolStripMenuItem";
            this.rotateCounterClockwiseToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.rotateCounterClockwiseToolStripMenuItem.Text = "Rotate counter-clockwise";
            this.rotateCounterClockwiseToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItemBtnClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // cornerDetectCToolStripMenuItem
            // 
            this.cornerDetectCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goodFeatrueToTrackToolStripMenuItem,
            this.harrisCornerDetectorToolStripMenuItem,
            this.fASTToolStripMenuItem});
            this.cornerDetectCToolStripMenuItem.Name = "cornerDetectCToolStripMenuItem";
            this.cornerDetectCToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.cornerDetectCToolStripMenuItem.Text = "Corner Detect(&C)";
            // 
            // goodFeatrueToTrackToolStripMenuItem
            // 
            this.goodFeatrueToTrackToolStripMenuItem.Name = "goodFeatrueToTrackToolStripMenuItem";
            this.goodFeatrueToTrackToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.goodFeatrueToTrackToolStripMenuItem.Text = "Good Featrue to Track";
            // 
            // harrisCornerDetectorToolStripMenuItem
            // 
            this.harrisCornerDetectorToolStripMenuItem.Name = "harrisCornerDetectorToolStripMenuItem";
            this.harrisCornerDetectorToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.harrisCornerDetectorToolStripMenuItem.Text = "Harris Corner Detector";
            // 
            // fASTToolStripMenuItem
            // 
            this.fASTToolStripMenuItem.Name = "fASTToolStripMenuItem";
            this.fASTToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.fASTToolStripMenuItem.Text = "FAST";
            this.fASTToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItemBtnClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxImage, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1055, 482);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxImage.Location = new System.Drawing.Point(6, 54);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(1043, 422);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxImage_Paint);
            this.pictureBoxImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxImage_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonColorToGray);
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.buttonNextLoad);
            this.panel1.Controls.Add(this.buttonPrevLoad);
            this.panel1.Controls.Add(this.buttonLoad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 39);
            this.panel1.TabIndex = 1;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(203, 3);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 32);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Reset(&R)";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonNextLoad
            // 
            this.buttonNextLoad.Location = new System.Drawing.Point(151, 3);
            this.buttonNextLoad.Name = "buttonNextLoad";
            this.buttonNextLoad.Size = new System.Drawing.Size(46, 33);
            this.buttonNextLoad.TabIndex = 3;
            this.buttonNextLoad.Text = ">";
            this.buttonNextLoad.UseVisualStyleBackColor = true;
            this.buttonNextLoad.Click += new System.EventHandler(this.buttonNextLoad_Click);
            // 
            // buttonPrevLoad
            // 
            this.buttonPrevLoad.Location = new System.Drawing.Point(99, 3);
            this.buttonPrevLoad.Name = "buttonPrevLoad";
            this.buttonPrevLoad.Size = new System.Drawing.Size(46, 33);
            this.buttonPrevLoad.TabIndex = 2;
            this.buttonPrevLoad.Text = "<";
            this.buttonPrevLoad.UseVisualStyleBackColor = true;
            this.buttonPrevLoad.Click += new System.EventHandler(this.buttonPrevLoad_Click);
            // 
            // buttonColorToGray
            // 
            this.buttonColorToGray.Location = new System.Drawing.Point(285, 4);
            this.buttonColorToGray.Name = "buttonColorToGray";
            this.buttonColorToGray.Size = new System.Drawing.Size(90, 32);
            this.buttonColorToGray.TabIndex = 7;
            this.buttonColorToGray.Text = "ColorToGray";
            this.buttonColorToGray.UseVisualStyleBackColor = true;
            this.buttonColorToGray.Click += new System.EventHandler(this.buttonColorToGray_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 530);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageViewer2";
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPos;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPixelValue;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelVer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSize;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRatio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programExitXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionOToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFileName;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonNextLoad;
        private System.Windows.Forms.Button buttonPrevLoad;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ToolStripMenuItem imageIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipVerticallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipHorizontallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateClockwiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateCounterClockwiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cornerDetectCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodFeatrueToTrackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem harrisCornerDetectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fASTToolStripMenuItem;
        private System.Windows.Forms.Button buttonColorToGray;
    }
}

