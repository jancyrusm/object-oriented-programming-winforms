/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 4/24/2021
 * Time: 6:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Compute
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
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ComputeButtonClick(object sender, EventArgs e)
		{
			int a = Convert.ToInt16(addendBox1.Text);
            int b = Convert.ToInt16(addendBox2.Text);
            
            int result = a + b;
            sumBox.Text = result.ToString();
		}
		void ClearButtonClick(object sender, EventArgs e)
		{
			addendBox1.Clear();
            addendBox2.Clear();
            sumBox.Clear();
		}
		void ExitButtonClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
