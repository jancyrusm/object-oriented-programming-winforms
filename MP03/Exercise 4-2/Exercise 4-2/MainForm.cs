/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 5/15/2021
 * Time: 1:47 PM
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Exercise_4_2
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
		void FirstYear_radioButtonCheckedChanged(object sender, EventArgs e)
		{
			this.output_textBox.Text  = "Freshman";
		}
		void SecondYear_radioButtonCheckedChanged(object sender, EventArgs e)
		{
			this.output_textBox.Text  = "Sophomore";
		}
		void ThirdYear_radioButtonCheckedChanged(object sender, EventArgs e)
		{
			this.output_textBox.Text  = "Junior";
		}
		void FourthYear_radioButtonCheckedChanged(object sender, EventArgs e)
		{
			this.output_textBox.Text  = "Senior";
		}
	}
}
