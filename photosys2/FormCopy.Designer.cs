namespace photosys2
{
    partial class FormCopy
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
            this.rbnCopy = new System.Windows.Forms.RadioButton();
            this.rbnMove = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkRename = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxFileExistsAction = new System.Windows.Forms.ComboBox();
            this.chkSaveSrcDirNames = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnkPath
            // 
            this.lnkPath.AutoSize = true;
            this.lnkPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkPath.Location = new System.Drawing.Point(0, 0);
            this.lnkPath.Name = "lnkPath";
            this.lnkPath.Size = new System.Drawing.Size(84, 13);
            this.lnkPath.TabIndex = 0;
            this.lnkPath.TabStop = true;
            this.lnkPath.Text = "Destination path";
            this.lnkPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tbxPath
            // 
            this.tbxPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxPath.Location = new System.Drawing.Point(0, 13);
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.Size = new System.Drawing.Size(459, 20);
            this.tbxPath.TabIndex = 1;
            // 
            // rbnCopy
            // 
            this.rbnCopy.AutoSize = true;
            this.rbnCopy.Checked = true;
            this.rbnCopy.Location = new System.Drawing.Point(3, 3);
            this.rbnCopy.Name = "rbnCopy";
            this.rbnCopy.Size = new System.Drawing.Size(49, 17);
            this.rbnCopy.TabIndex = 2;
            this.rbnCopy.TabStop = true;
            this.rbnCopy.Text = "Copy";
            this.rbnCopy.UseVisualStyleBackColor = true;
            // 
            // rbnMove
            // 
            this.rbnMove.AutoSize = true;
            this.rbnMove.Location = new System.Drawing.Point(58, 3);
            this.rbnMove.Name = "rbnMove";
            this.rbnMove.Size = new System.Drawing.Size(52, 17);
            this.rbnMove.TabIndex = 3;
            this.rbnMove.Text = "Move";
            this.rbnMove.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.rbnCopy);
            this.flowLayoutPanel1.Controls.Add(this.rbnMove);
            this.flowLayoutPanel1.Controls.Add(this.chkRename);
            this.flowLayoutPanel1.Controls.Add(this.chkSaveSrcDirNames);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 33);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(459, 23);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // chkRename
            // 
            this.chkRename.AutoSize = true;
            this.chkRename.Location = new System.Drawing.Point(116, 3);
            this.chkRename.Name = "chkRename";
            this.chkRename.Size = new System.Drawing.Size(128, 17);
            this.chkRename.TabIndex = 5;
            this.chkRename.Text = "Rename as date/time";
            this.chkRename.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.AutoSize = true;
            this.btnOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(424, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(32, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnOk);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 110);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(459, 29);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Действие, если конечный файл существует";
            // 
            // cbxFileExistsAction
            // 
            this.cbxFileExistsAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxFileExistsAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFileExistsAction.FormattingEnabled = true;
            this.cbxFileExistsAction.Location = new System.Drawing.Point(0, 69);
            this.cbxFileExistsAction.Name = "cbxFileExistsAction";
            this.cbxFileExistsAction.Size = new System.Drawing.Size(459, 21);
            this.cbxFileExistsAction.TabIndex = 8;
            // 
            // chkSaveSrcDirNames
            // 
            this.chkSaveSrcDirNames.AutoSize = true;
            this.chkSaveSrcDirNames.Location = new System.Drawing.Point(250, 3);
            this.chkSaveSrcDirNames.Name = "chkSaveSrcDirNames";
            this.chkSaveSrcDirNames.Size = new System.Drawing.Size(163, 17);
            this.chkSaveSrcDirNames.TabIndex = 6;
            this.chkSaveSrcDirNames.Text = "Save source directory names";
            this.chkSaveSrcDirNames.UseVisualStyleBackColor = true;
            // 
            // FormCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 139);
            this.Controls.Add(this.cbxFileExistsAction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tbxPath);
            this.Controls.Add(this.lnkPath);
            this.Name = "FormCopy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Copy/Move/Rename";
            this.Load += new System.EventHandler(this.FormCopy_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkPath;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public System.Windows.Forms.TextBox tbxPath;
        public System.Windows.Forms.RadioButton rbnCopy;
        public System.Windows.Forms.RadioButton rbnMove;
        public System.Windows.Forms.CheckBox chkRename;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbxFileExistsAction;
        public System.Windows.Forms.CheckBox chkSaveSrcDirNames;
    }
}