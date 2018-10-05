using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace TerbilangWindowsFormsApp
{
    public partial class Form1 : Form
    {
        Terbilang terbilang = new Terbilang();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            //label3Hasil.Text = Convert.ToString(terbilang.TerbilangIndonesia(a));
            richTextBox1.Text = Convert.ToString(terbilang.TerbilangIndonesia(a));
        }
    }
}
