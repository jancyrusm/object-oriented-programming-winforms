/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 5/22/2021
 * Time: 2:30 PM
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MultiplicationTable
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void CalculateButtonClick(object sender, EventArgs e)
		{
			int mltpcnd = Convert.ToInt16(multiplicandBox.Text);
			int mltpr = Convert.ToInt16(multiplierBox.Text);
			
			int result = mltpcnd * mltpr;
			productBox.Text = result.ToString();
		}
		void ExitButtonClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
