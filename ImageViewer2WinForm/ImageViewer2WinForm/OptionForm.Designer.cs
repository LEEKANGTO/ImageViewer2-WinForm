﻿namespace ImageViewer2WinForm
{
    partial class OptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Image Load");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Environment", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.treeViewOption = new System.Windows.Forms.TreeView();
            this.groupBoxParmeter = new System.Windows.Forms.GroupBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77F));
            this.tableLayoutPanel1.Controls.Add(this.treeViewOption, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxParmeter, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.333333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(660, 305);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // treeViewOption
            // 
            this.treeViewOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewOption.Location = new System.Drawing.Point(3, 3);
            this.treeViewOption.Name = "treeViewOption";
            treeNode3.Name = "ImageLoad";
            treeNode3.Text = "Image Load";
            treeNode4.Name = "Environment";
            treeNode4.Text = "Environment";
            this.treeViewOption.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeViewOption.Size = new System.Drawing.Size(145, 299);
            this.treeViewOption.TabIndex = 1;
            this.treeViewOption.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewOption_AfterSelect);
            // 
            // groupBoxParmeter
            // 
            this.groupBoxParmeter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxParmeter.Location = new System.Drawing.Point(154, 3);
            this.groupBoxParmeter.Name = "groupBoxParmeter";
            this.groupBoxParmeter.Size = new System.Drawing.Size(503, 299);
            this.groupBoxParmeter.TabIndex = 2;
            this.groupBoxParmeter.TabStop = false;
            this.groupBoxParmeter.Text = "Parameter";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(484, 314);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(565, 314);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 349);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OptionForm";
            this.Text = "Option";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView treeViewOption;
        private System.Windows.Forms.GroupBox groupBoxParmeter;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}