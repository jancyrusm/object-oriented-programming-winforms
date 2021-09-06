/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 6/5/2021
 * Time: 11:24 AM
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleCalc
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void AddRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			int first = Convert.ToInt16(firstBox.Text);
			int second = Convert.ToInt16(secondBox.Text);
			
			int result = first + second;
			resultsBox.Text = result.ToString();	
		}
		void SubtractRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			int first = Convert.ToInt16(firstBox.Text);
			int second = Convert.ToInt16(secondBox.Text);
			
			int result = first - second;
			resultsBox.Text = result.ToString();	
		}
		void MultiplyRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			int first = Convert.ToInt16(firstBox.Text);
			int second = Convert.ToInt16(secondBox.Text);
			
			int result = first * second;
			resultsBox.Text = result.ToString();	
		}
		void DivideRadioButtonCheckedChanged(object sender, EventArgs e)
		{		
			int first = Convert.ToInt16(firstBox.Text);
			int second = Convert.ToInt16(secondBox.Text);
			
			int result = first / second;
			resultsBox.Text = result.ToString();
		}
	}
}
