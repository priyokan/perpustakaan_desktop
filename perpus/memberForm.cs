﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace perpus
{
    public partial class memberForm : Form
    {
        public memberForm()
        {
            InitializeComponent();
        }

        public static string anu;

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PicBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void MemberForm_Load(object sender, EventArgs e)
        {

        }

        private void UserControlAbsen1_Click(object sender, EventArgs e)
        {

        }

        private void UserControlAbsen1_Load(object sender, EventArgs e)
        {

        }

        

        private void UserControlAbsen1_ControlAdded(object sender, ControlEventArgs e)
        {

        }
    }
}
