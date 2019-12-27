using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace captcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string[] symbol1 = { "a", "b", "c", "k", "d", "y" };
            string[] symbol2 = { "+", "-", "£", "$", "*" };
            int[] symbol3 = { 3, 5, 7, 9, 6, 1, 4 };
            char[] symbol4 = { 'v', 'p', 't', 'i', 'r' };


            Random r = new Random();
            int s1, s2, s3, s4, s5;
            s1 = r.Next(0, symbol1.Length);
            s2 = r.Next(0, symbol2.Length);
            s3 = r.Next(0, symbol1.Length);
            s4 = r.Next(0, symbol3.Length);
            s5 = r.Next(0, symbol4.Length);
            
            this.label1.Visible = true;
            label1.Text = symbol1[s1].ToString() + symbol2[s2].ToString() + symbol1[s3].ToUpper().ToString() + symbol3[s4].ToString() + symbol4[s5].ToString();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == textBox1.Text)
            {
                Form2 fr = new Form2();
                fr.Show();
                //this.Hide(); // Giriş yapıldıktan sonra arkadaki captcha ekranını gizlemek için kullanılır
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }
    }
}
