using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Bill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string quantity = textBoxquantity.Text;
            string menu = textBoxmenu.Text;
            string price = textBoxprice.Text;

            //Quantity * Price
            double quant = Convert.ToDouble(quantity);
            double prc = Convert.ToDouble(price);

            double ttlprc = quant * prc;

            listBoxquantity.Items.Add(quantity.ToString());
            listBoxmenu.Items.Add(menu.ToString());
            listBoxprice.Items.Add(ttlprc.ToString("0.00"));
        }

        private void buttonTotal_Click(object sender, EventArgs e)
        {
            double sum = 0;
            for (int i = 0; i < listBoxprice.Items.Count; i++)
            {
                sum += Convert.ToDouble(listBoxprice.Items[i]);
            }
            textBoxtotalcost.Text = sum.ToString("₱0.00");
        }
    }
}
