/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 5/12/2021
 * Time: 4:07 PM
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Celsius_and_Fahrenheit_Temperature_Converter
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
		void CelsiusButtonClick(object sender, EventArgs e)
		{
			double temperature = Convert.ToInt16(inputBox.Text);
			double celsius = (temperature - 32) * 5 / 9;

			resultsBox.Text = celsius.ToString() + "°C";			
		}
		void FarenheitButtonClick(object sender, EventArgs e)
		{
			double temperature = Convert.ToInt16(inputBox.Text);
			double fahrenheit = (temperature * 9) / 5 + 32;	
			
			resultsBox.Text = fahrenheit.ToString() + "°F";
		}
		void ResultsBoxTextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
