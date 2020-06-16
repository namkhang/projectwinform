﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 f2;

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nhậpHồSơToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f2 == null)
            {
                f2 = new Form2();
                f2.FormClosed += new FormClosedEventHandler(F2_FormClosed);
                IsMdiContainer = true;
                f2.MdiParent = this;
                f2.Show();
            }
            else f2.Activate();
        }
        private void F2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f2 = null;
        }
    }
}
