namespace photosys2
{
    partial class Form1
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
            this.lnkPath = new System.Windows.Forms.LinkLabel();
            this.tbxPath = new System.Windows.Forms.TextBox();
            this.lvwFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.wpf = new System.Windows.Forms.Integration.ElementHost();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnkPath
            // 
            this.lnkPath.AutoSize = true;
            this.lnkPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkPath.Location = new System.Drawing.Point(0, 0);
            this.lnkPath.Name = "lnkPath";
            this.lnkPath.Size = new System.Drawing.Size(65, 13);
            this.lnkPath.TabIndex = 0;
            this.lnkPath.TabStop = true;
            this.lnkPath.Text = "Source path";
            this.lnkPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPath_LinkClicked);
            // 
            // tbxPath
            // 
            this.tbxPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxPath.Location = new System.Drawing.Point(0, 13);
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.Size = new System.Drawing.Size(463, 20);
            this.tbxPath.TabIndex = 1;
            this.tbxPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPath_KeyPress);
            // 
            // lvwFiles
            // 
            this.lvwFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.lvwFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwFiles.FullRowSelect = true;
            this.lvwFiles.HideSelection = false;
            this.lvwFiles.Location = new System.Drawing.Point(0, 33);
            this.lvwFiles.Name = "lvwFiles";
            this.lvwFiles.Size = new System.Drawing.Size(463, 400);
            this.lvwFiles.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwFiles.TabIndex = 2;
            this.lvwFiles.UseCompatibleStateImageBehavior = false;
            this.lvwFiles.View = System.Windows.Forms.View.Details;
            this.lvwFiles.SelectedIndexChanged += new System.EventHandler(this.lvwFiles_SelectedIndexChanged);
            this.lvwFiles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lvwFiles_KeyPress);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "File date";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date src";
            // 
            // pbxImage
            // 
            this.pbxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxImage.Location = new System.Drawing.Point(0, 33);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(312, 400);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImage.TabIndex = 3;
            this.pbxImage.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 433);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(779, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // wpf
            // 
            this.wpf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wpf.Location = new System.Drawing.Point(0, 33);
            this.wpf.Name = "wpf";
            this.wpf.Size = new System.Drawing.Size(312, 400);
            this.wpf.TabIndex = 5;
            this.wpf.Text = "elementHost1";
            this.wpf.Child = null;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvwFiles);
            this.splitContainer1.Panel1.Controls.Add(this.tbxPath);
            this.splitContainer1.Panel1.Controls.Add(this.lnkPath);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pbxImage);
            this.splitContainer1.Panel2.Controls.Add(this.wpf);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(779, 433);
            this.splitContainer1.SplitterDistance = 463;
            this.splitContainer1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 33);
            this.panel1.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(312, 33);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy/Move/Rename...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Size, KB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 455);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "PhotoSys";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkPath;
        private System.Windows.Forms.TextBox tbxPath;
        private System.Windows.Forms.ListView lvwFiles;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Integration.ElementHost wpf;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

