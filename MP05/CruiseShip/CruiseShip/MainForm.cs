/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 6/5/2021
 * Time: 12:06 PM
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CruiseShip
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void EconomyRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			toiletCheckBox.Checked = true;
			mealsCheckBox.Checked = true;	
			airconCheckBox.Checked = false;
			bedCheckBox.Checked = false;
			televisionCheckBox.Checked = false;
			vipCheckBox.Checked = false;
			
			string fare = "Php 1,500";
			totalfareBox.Text = fare;
		}
		void TouristRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			toiletCheckBox.Checked = true;
			mealsCheckBox.Checked = true;
			airconCheckBox.Checked = true;
			bedCheckBox.Checked = true;
			televisionCheckBox.Checked = false;
			vipCheckBox.Checked = false;	
			
			string fare = "Php 2,500";
			totalfareBox.Text = fare;	
		}
		void CabinRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			toiletCheckBox.Checked = true;
			mealsCheckBox.Checked = true;
			airconCheckBox.Checked = true;
			bedCheckBox.Checked = true;
			televisionCheckBox.Checked = true;
			vipCheckBox.Checked = true;	
			
			string fare = "Php 4,000";
			totalfareBox.Text = fare;		
		}
		void ClearButtonClick(object sender, EventArgs e)
		{
			//uncheck all checkboxes
			toiletCheckBox.Checked = false;
			mealsCheckBox.Checked = false;
			airconCheckBox.Checked = false;
			bedCheckBox.Checked = false;
			televisionCheckBox.Checked = false;
			vipCheckBox.Checked = false;

			//deselect all radio buttons
			economyRadioButton.Checked = false;
			touristRadioButton.Checked = false;
			cabinRadioButton.Checked = false;
			
			//clear text box
			totalfareBox.Clear();
		}
		void ExitButtonClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
