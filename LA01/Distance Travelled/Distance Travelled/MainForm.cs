/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 5/12/2021
 * Time: 4:36 PM
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Distance_Travelled
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
		void CalculateButtonClick(object sender, EventArgs e)
		{
			double speed = Convert.ToInt16(inputBox.Text);
			double five = speed * 5;
			double eight = speed * 8;
			double twelve = speed * 12;
			
			fiveHours.Text = five.ToString();
			eightHours.Text = eight.ToString();
			twelveHours.Text = twelve.ToString();
		}
		void FiveHoursTextChanged(object sender, EventArgs e)
		{
			
		}
		void EightHoursTextChanged(object sender, EventArgs e)
		{
			
		}
		void TwelveHoursTextChanged(object sender, EventArgs e)
		{
			
		}
		void ClearButtonClick(object sender, EventArgs e)
		{
			inputBox.Clear();
			fiveHours.Clear();
			eightHours.Clear();
			twelveHours.Clear();
		}
	}
}
