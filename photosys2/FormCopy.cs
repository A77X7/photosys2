using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace photosys2
{
    public partial class FormCopy : Form
    {
        public FormCopy()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            if (System.IO.Directory.Exists(tbxPath.Text))
            {
                dlg.SelectedPath = tbxPath.Text;
            }
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbxPath.Text = dlg.SelectedPath;
            }
        }

        private void FormCopy_Load(object sender, EventArgs e)
        {
            cbxFileExistsAction.Items.Add(Form1.FileExistsActions.Ask);
            cbxFileExistsAction.Items.Add(Form1.FileExistsActions.Replace);
            cbxFileExistsAction.Items.Add(Form1.FileExistsActions.SaveBoth);
            cbxFileExistsAction.Items.Add(Form1.FileExistsActions.Skip);
            cbxFileExistsAction.Items.Add(Form1.FileExistsActions.SkipSameOrSaveBoth);
            cbxFileExistsAction.SelectedIndex = 0;
        }
    }
}
