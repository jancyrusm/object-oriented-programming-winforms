using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cash_Register
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxsubtotal.Text = "₱0.00";
            textBoxtax.Text = "₱0.00";
            textBoxtotal.Text = "₱0.00";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pesosBox.Text = pesosBox.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pesosBox.Text = pesosBox.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pesosBox.Text = pesosBox.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pesosBox.Text = pesosBox.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pesosBox.Text = pesosBox.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pesosBox.Text = pesosBox.Text + "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            pesosBox.Text = pesosBox.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pesosBox.Text = pesosBox.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pesosBox.Text = pesosBox.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            pesosBox.Text = pesosBox.Text + "0";
        }

        private void buttondot_Click(object sender, EventArgs e)
        {
            pesosBox.Text = pesosBox.Text + ".";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pesosBox.Clear();
            textBoxsubtotal.Text = "₱0.00";
            textBoxtax.Text = "₱0.00";
            textBoxtotal.Text = "₱0.00";
        }

        public void buttonEnter_Click(object sender, EventArgs e)
        {
            double pesos = Convert.ToDouble(pesosBox.Text);
            textBoxsubtotal.Text = pesos.ToString("0.00");
            pesosBox.Clear();
        }

        public void buttonTotal_Click(object sender, EventArgs e)
        {
            double subtotal = Convert.ToDouble(textBoxsubtotal.Text);
            if (subtotal > 499)
            {
                double tax = subtotal * 0.1;
                textBoxtax.Text = tax.ToString("0.00");
            }
            else if (subtotal > 100 && subtotal < 499)
            {
                double tax = subtotal * 0.075;
                textBoxtax.Text = tax.ToString("0.00");
            }
            else if (subtotal < 100)
            {
                double tax = subtotal * 0.05;
                textBoxtax.Text = tax.ToString("0.00");
            }

            double taxes = Convert.ToDouble(textBoxtax.Text);
            double total = subtotal + taxes;

            textBoxtotal.Text = total.ToString("₱0.00");

            double reftaxes = Convert.ToDouble(textBoxtax.Text);
            double refsubtotal = Convert.ToDouble(textBoxsubtotal.Text);

            textBoxtax.Text = reftaxes.ToString("₱0.00");
            textBoxsubtotal.Text = refsubtotal.ToString("₱0.00");

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string s = pesosBox.Text;

            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }
            else
            {
                s = "0";
            }

            pesosBox.Text = s;
        }


    }
}
