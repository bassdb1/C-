using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPassingText
{
    public partial class Form2 : Form
    {
        public static string textPassedForm2;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Form1.textPassedForm1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textPassedForm2 = richTextBox1.Text;
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();  // Hides this Form
        }
    }
}
