/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 6/5/2021
 * Time: 11:08 AM
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Color_Theme
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void YellowRadiobtnCheckedChanged(object sender, EventArgs e)
		{
			BackColor = Color.Yellow;
			statusStrip1.BackColor = Color.Yellow;
			ForeColor = Color.Black;
			colorGroupBox.ForeColor = Color.Black;
			exitButton.ForeColor = Color.Black;
		}
		void RedRadiobtnCheckedChanged(object sender, EventArgs e)
		{
			BackColor = Color.Red;
			statusStrip1.BackColor = Color.Red;
			ForeColor = Color.White;
			colorGroupBox.ForeColor = Color.White;
			exitButton.ForeColor = Color.Black;
		}
		void WhiteRadiobtnCheckedChanged(object sender, EventArgs e)
		{
			BackColor = Color.White;
			statusStrip1.BackColor = Color.White;
			ForeColor = Color.Black;
			colorGroupBox.ForeColor = Color.Black;
			exitButton.ForeColor = Color.Black;
		}
		void NormalRadiobtnCheckedChanged(object sender, EventArgs e)
		{
			BackColor = Color.FromKnownColor(KnownColor.Control);
			statusStrip1.BackColor = Color.FromKnownColor(KnownColor.Control);
			ForeColor = Color.Black;
			colorGroupBox.ForeColor = Color.Black;
			exitButton.ForeColor = Color.Black;
		}
		void ExitButtonClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
