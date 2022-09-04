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
    public partial class Form1 : Form
    {
        public static string textPassedForm1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Form2.textPassedForm2;
        }

        private void btnPassText_Click(object sender, EventArgs e)
        {
            textPassedForm1 = richTextBox1.Text;
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();  // Hides this Form
        }
    }
}
