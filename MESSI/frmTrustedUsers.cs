﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprint3
{
    public partial class frmTrustedUsers : Form
    {
        public frmTrustedUsers()
        {
            InitializeComponent();
        }

        private void frmTrustedUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
