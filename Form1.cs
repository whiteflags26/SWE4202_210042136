using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab09
{
    public partial class Form1 : Form
    {
        public static Form1 form1instance;
        public string username;
        public Form1()
        {
            InitializeComponent();
            form1instance = this;
        }

        private void CreateOneLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string file = "C:\\Users\\mirsa\\Documents\\VsStudioC#\\lab09\\username&password_list.txt";
            bool flg1 = false, flg2 = false;
            if (File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);
                int i = 1;
                foreach (string line in lines)
                {
                    if (i % 3 == 2 && line == UserNameTextBox.Text) flg1 = true;
                    if (i % 3 == 0 && line == PasswordTextBox.Text) flg2 = true;
                    i++;
                }
                if (flg1 && flg2)
                {
                    username = UserNameTextBox.Text;
                    Form3 f3 = new Form3();
                    f3.Show();
                    this.Hide();
                }
            }
        }
    }
}
