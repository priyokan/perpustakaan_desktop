﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace perpus
{
    public partial class userControlAbsen : UserControl
    {
        public userControlAbsen()
        {
            InitializeComponent();
        }

        public event EventHandler ButtonClick;

        private void Button1_Click(object sender, EventArgs e)
        {
            //if(this.ButtonClick != null)            
                this.ButtonClick(this, e);            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void UserControlAbsen_Load(object sender, EventArgs e)
        {

        }

        private void TxtNIS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txtNIS.Text == "Masukan NIS...")
            {
                txtNIS.Text = "";
            }
            
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtNIS_Leave(object sender, EventArgs e)
        {
            if(txtNIS.Text == "")
            {
                txtNIS.Text = "Masukan NIS...";
            }
        }
    }
}
