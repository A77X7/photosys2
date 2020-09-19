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
    }
}
