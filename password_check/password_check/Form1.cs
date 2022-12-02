using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_check
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Method to test if our password contains a number

        private int numberPass(string pass)
        {
            int num = 0;

            foreach (char ch in pass)
            {
                if (char.IsDigit(ch))
                {
                    num++;
                }
            }
            return num;
        }

        // Method to test if our password contains an Uppercase character

        private int upperCase(string pass)
        {
            int num = 0;

            foreach (char ch in pass)
            {
                if (char.IsUpper(ch))
                {
                    num++;
                }
            }
            return num;
        }

        // Method to test if our password contains an lowercase character

        private int lowerCase(string pass)
        {
            int num = 0;

            foreach (char ch in pass)
            {
                if (char.IsLower(ch))
                {
                    num++;
                }
            }
            return num;
        }

        // Method to test if our password contains an special character

        private int specialCharacter(string pass)
        {
            int num = 0;
            const string SYMBOLS = "!@#$%^&*()";
            foreach (var item in SYMBOLS)
            {
                if (pass.Contains(item))
                {
                    num++;
                }
            }
            return num;

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            const int MIN_LENGTH = 8;

            string password = txtPassword.Text;

            if (password.Length >= MIN_LENGTH  && numberPass(password) >=1 && upperCase(password) >=1 && lowerCase(password) >=1 && specialCharacter(password) >=1)
            {
                MessageBox.Show("Password is good");

            }
            else
            {
                MessageBox.Show("Password is bad");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
