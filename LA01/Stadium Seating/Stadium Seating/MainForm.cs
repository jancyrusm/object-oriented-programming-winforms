/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 5/12/2021
 * Time: 4:23 PM
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Stadium_Seating
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
			double input_A = Convert.ToInt16(classA_inputBox.Text);
			double input_B = Convert.ToInt16(classB_inputBox.Text);
			double input_C = Convert.ToInt16(classC_inputBox.Text);
			
			double A = input_A * 15;
			double B = input_B * 12;
			double C = input_C * 9;
			double total = A + B + C;
			
			classA_resultsBox.Text = "$" + A.ToString("f2");
			classB_resultsBox.Text = "$" + B.ToString("f2");
			classC_resultsBox.Text = "$" + C.ToString("f2");
			totalBox.Text = "$" + total.ToString("f2");
		}
		void ClearButtonClick(object sender, EventArgs e)
		{
			classA_inputBox.Clear();
			classB_inputBox.Clear();
			classC_inputBox.Clear();
			classA_resultsBox.Clear();
			classB_resultsBox.Clear();	
			classC_resultsBox.Clear();
			totalBox.Clear();							
		}
		void ExitButtonClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
