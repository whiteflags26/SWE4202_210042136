﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab09
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            WelcomeLabel.Text = "Welcome! " + Form1.form1instance.username;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
