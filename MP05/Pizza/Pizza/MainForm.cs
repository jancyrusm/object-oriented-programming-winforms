/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 6/5/2021
 * Time: 12:41 PM
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Pizza
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void DeluxeRadioButtonCheckedChanged(object sender, EventArgs e)
		{
            cheeseCheckBox.Checked = true;
            bacon_hamCheckBox.Checked = true;
            onions_chiliCheckBox.Checked = true;
			pepperCheckBox.Checked = false;
			mushroomsCheckBox.Checked = false;
			tomato_pineappleCheckBox.Checked = false;
			salamiCheckBox.Checked = false;
			
			double price = 185.00;
			priceBox.Text = price.ToString();
		}
		void SpecialRadioButtonCheckedChanged(object sender, EventArgs e)
		{
            cheeseCheckBox.Checked = true;
            bacon_hamCheckBox.Checked = true;
            onions_chiliCheckBox.Checked = true;
			pepperCheckBox.Checked = true;
			mushroomsCheckBox.Checked = true;
			tomato_pineappleCheckBox.Checked = false;
			salamiCheckBox.Checked = false;	

			double price = 275.00;
			priceBox.Text = price.ToString();
		}
		void PrimoRadioButtonCheckedChanged(object sender, EventArgs e)
		{
            cheeseCheckBox.Checked = true;
            bacon_hamCheckBox.Checked = true;
            onions_chiliCheckBox.Checked = true;
            pepperCheckBox.Checked = true;
            mushroomsCheckBox.Checked = true;
            tomato_pineappleCheckBox.Checked = true;
            salamiCheckBox.Checked = true;

            double price = 350.00;
			priceBox.Text = price.ToString();	
		}
		void CalculateButtonClick(object sender, EventArgs e)
		{
			int cost = Convert.ToInt16(priceBox.Text);
			int quantity = Convert.ToInt16(quantityBox.Text);
			
			int result = cost * quantity;
			total_amountBox.Text = "Php " + result.ToString("F2");				
		}
	}
}
