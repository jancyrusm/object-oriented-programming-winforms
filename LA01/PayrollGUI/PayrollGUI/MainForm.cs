/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 5/12/2021
 * Time: 9:36 PM
 * 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PayrollGUI
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
		}
		void GenerateButtonClick(object sender, EventArgs e)
		{
			string name = Convert.ToString(name_inputBox.Text);
			name_resultBox.Text = name.ToString();
			
			string ssn = Convert.ToString(ssn_inputBox.Text);
			ssn_resultBox.Text = ssn.ToString();
			
			double hpr = Convert.ToInt16(hpr_inputBox.Text);
			hpr_resultBox.Text = hpr.ToString();
			
			double workHours = Convert.ToInt16(workHours_inputBox.Text);
			workHours_resultBox.Text = workHours.ToString();
			
			double grossPay = hpr * workHours;
			grossPay_resultBox.Text = grossPay.ToString();
			
			double fwt = grossPay * 0.15;
			fwt_resultBox.Text = fwt.ToString();
			
			double swt = grossPay * 0.05;
			swt_resultBox.Text = swt.ToString();

			double netPay = grossPay - (fwt + swt);
			netPay_resultBox.Text = netPay.ToString();			
		}
		void Name_resultBoxTextChanged(object sender, EventArgs e)
		{
			 
		}
		void Ssn_resultBoxTextChanged(object sender, EventArgs e)
		{
	
		}
		void Hpr_resultBoxTextChanged(object sender, EventArgs e)
		{
	
		}
		void WorkHours_resultBoxTextChanged(object sender, EventArgs e)
		{
	
		}
		void GrossPay_resultBoxTextChanged(object sender, EventArgs e)
		{
	
		}
		void Fwt_resultBoxTextChanged(object sender, EventArgs e)
		{
	
		}
		void Swt_resultBoxTextChanged(object sender, EventArgs e)
		{
	
		}
	}
}
