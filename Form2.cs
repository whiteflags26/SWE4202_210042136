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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            string file = "C:\\Users\\mirsa\\Documents\\VsStudioC#\\lab09\\username&password_list.txt";
            bool flg = true;
            if (File.Exists(file))
            {
                if (UserNameTextBox.Text.Length >= 6 && PasswordTextBox.Text.Length >= 6)
                {
                    string[] lines = File.ReadAllLines(file);
                    foreach (string line in lines)
                    {
                        if (line == UserNameTextBox.Text)
                        {
                            flg = false; break;
                        }
                    }
                    if (flg == true)
                    {
                        if (PasswordTextBox.Text == RetypeTextBox.Text)
                        {
                            File.AppendAllText(file, NameTextBox.Text);
                            File.AppendAllText(file, "\n");
                            File.AppendAllText(file, UserNameTextBox.Text);
                            File.AppendAllText(file, "\n");
                            File.AppendAllText(file, PasswordTextBox.Text);
                            File.AppendAllText(file, "\n");
                        }
                    }
                }
            }
                    
        }
    }
}
