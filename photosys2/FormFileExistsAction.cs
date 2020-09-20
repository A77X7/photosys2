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
    public partial class FormFileExistsAction : Form
    {
        public FormFileExistsAction()
        {
            InitializeComponent();
        }

        public Form1.FileExistsActions result = Form1.FileExistsActions.Ask;
        
        private void button4_Click(object sender, EventArgs e)
        {
            result = Form1.FileExistsActions.Replace;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result = Form1.FileExistsActions.Skip;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = Form1.FileExistsActions.SaveBoth;
        }

        private void FormFileExistsAction_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.None)
                e.Cancel = true;
        }
    }
}
