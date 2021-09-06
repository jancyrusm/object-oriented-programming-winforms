/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 5/15/2021
 * Time: 1:44 PM
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Exercise_4_1
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
		void Option1_radioButtonCheckedChanged(object sender, EventArgs e)
		{
			this.radioButton_textBox.Text  = "Radio button 1 clicked";
		}
		void Option2_radioButtonCheckedChanged(object sender, EventArgs e)
		{
			this.radioButton_textBox.Text  = "Radio button 2 clicked";
		}
		void Option3_radioButtonCheckedChanged(object sender, EventArgs e)
		{
			this.radioButton_textBox.Text  = "Radio button 3 clicked";
		}
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			this.checkBox_textBox.Text  = "Check box 1 clicked";	
		}
		void CheckBox2CheckedChanged(object sender, EventArgs e)
		{
			this.checkBox_textBox.Text  = "Check box 2 clicked";	
		}
		void CheckBox3CheckedChanged(object sender, EventArgs e)
		{
			this.checkBox_textBox.Text  = "Check box 3 clicked";	
		}
		void RadioButton_textBoxTextChanged(object sender, EventArgs e)
		{
	
		}
		void CheckBox_textBoxTextChanged(object sender, EventArgs e)
		{
	
		}
	}
}
