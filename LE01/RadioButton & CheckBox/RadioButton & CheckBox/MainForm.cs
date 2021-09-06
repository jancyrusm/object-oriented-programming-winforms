/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 5/22/2021
 * Time: 2:21 PM
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RadioButton___CheckBox
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();			
		}
		void CloseButtonClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void ClearButtonClick(object sender, EventArgs e)
		{
			// Clear Textboxes
			subtotalBox.Clear();
			discountBox.Clear();
			netamountBox.Clear();
			
			// Clear Checkboxes
			checkBox1.Checked = false;
			checkBox2.Checked = false;
			checkBox3.Checked = false;
			
			// Clear Checkboxes
			radioButton1.Checked = false;
			radioButton2.Checked = false;
			radioButton3.Checked = false;
		}
		void ComputeButtonClick(object sender, EventArgs e)
		{
			
			//conditional statements para sa checkboxes
			if (checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked) // checkBox1 only
			{
				int subtotal = 10000;
				subtotalBox.Text = subtotal.ToString();
			}
			else if (!checkBox1.Checked && checkBox2.Checked && !checkBox3.Checked) // checkBox2 only
			{
				int subtotal = 7500;
				subtotalBox.Text = subtotal.ToString();
			}	
			else if (checkBox1.Checked && checkBox2.Checked && !checkBox3.Checked) // checkBox1 and checkBox2 only
			{
				int subtotal = 17500;
				subtotalBox.Text = subtotal.ToString();
			}
			else if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked) // all checkBoxes checked
			{
				int subtotal = 22500;
				subtotalBox.Text = subtotal.ToString();
			}			
			else if (!checkBox1.Checked && !checkBox2.Checked && checkBox3.Checked) // checkBox3 only
			{
				int subtotal = 5000;
				subtotalBox.Text = subtotal.ToString();
			}	
			else if (checkBox1.Checked && !checkBox2.Checked && checkBox3.Checked) // checkBox1 and checkBox3 only
			{
				int subtotal = 15000;
				subtotalBox.Text = subtotal.ToString();
			}
			else if (!checkBox1.Checked && checkBox2.Checked && checkBox3.Checked) // checkBox2 and checkBox3 only
			{
				int subtotal = 12500;
				subtotalBox.Text = subtotal.ToString();
			}
			
			//para sa value ng discount based sa radio buttons
			if (radioButton1.Checked == true)
			{
				double sbttlValue = Convert.ToInt16(subtotalBox.Text);
				double discount = sbttlValue * 0.05;
				discountBox.Text = discount.ToString();
			}
			else if (radioButton2.Checked == true)
			{
				double sbttlValue = Convert.ToInt16(subtotalBox.Text);
				double discount = sbttlValue * 0.10;
				discountBox.Text = discount.ToString();				
			}
			else if (radioButton3.Checked == true)
			{
				double sbttlValue = Convert.ToInt16(subtotalBox.Text);
				double discount = sbttlValue * 0.15;
				discountBox.Text = discount.ToString();				
			}
			else if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
			{
				int discount = 0;
				discountBox.Text = discount.ToString();				
			}
			
			//computation sa discount
 				int sbttl = Convert.ToInt16(subtotalBox.Text);
 				int dscnt = Convert.ToInt16(discountBox.Text);
 				
 				int result = sbttl - dscnt;
 				
 			//show yung netamount
 				netamountBox.Text = result.ToString();
		}
	}
}
