/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 4/24/2021
 * Time: 4:47 PM
 * 
 */
using System;
using System.Windows.Forms;

namespace Addition
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
		void ExitButtonClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void AddButtonClick(object sender, EventArgs e)
		{
			int a = Convert.ToInt16(firstBox.Text);
			int b = Convert.ToInt16(secondBox.Text);

			int result = a + b;
			resultsBox.Text = result.ToString();
		}
		void ClearButtonClick(object sender, EventArgs e)
		{
			firstBox.Clear();
			secondBox.Clear();
			resultsBox.Clear();
		}
		void MultiplyButtonClick(object sender, EventArgs e)
		{
			int a = Convert.ToInt16(firstBox.Text);
			int b = Convert.ToInt16(secondBox.Text);

			int result = a * b;
			resultsBox.Text = result.ToString();
		}
		void MainFormLoad(object sender, EventArgs e)
		{

		}
	}
}
