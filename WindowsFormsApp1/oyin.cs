﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class oyin : Form
    {
        public oyin()
        {
            InitializeComponent();
        }

        

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            double san=double.Parse(guna2TextBox1.Text);
            label1.Text = (san*san).ToString();
        }

        private void guna2TextBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (guna2TextBox1.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;

            }
            e.Handled = true;
        }
    }
}
