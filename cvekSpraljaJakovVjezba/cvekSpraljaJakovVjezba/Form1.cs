using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cvekSpraljaJakovVjezba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonPodaci_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(textBox1.Text + " " + textBox2.Text);

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Console.ReadLine();

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            Console.ReadLine();

        }
    }
}
