/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 6/5/2021
 * Time: 12:06 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CruiseShip
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox accomodationGroupBox;
		private System.Windows.Forms.RadioButton economyRadioButton;
		private System.Windows.Forms.RadioButton cabinRadioButton;
		private System.Windows.Forms.RadioButton touristRadioButton;
		private System.Windows.Forms.GroupBox amenitiesGroupBox;
		private System.Windows.Forms.CheckBox vipCheckBox;
		private System.Windows.Forms.CheckBox mealsCheckBox;
		private System.Windows.Forms.CheckBox bedCheckBox;
		private System.Windows.Forms.CheckBox televisionCheckBox;
		private System.Windows.Forms.CheckBox airconCheckBox;
		private System.Windows.Forms.CheckBox toiletCheckBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.TextBox totalfareBox;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.accomodationGroupBox = new System.Windows.Forms.GroupBox();
			this.cabinRadioButton = new System.Windows.Forms.RadioButton();
			this.touristRadioButton = new System.Windows.Forms.RadioButton();
			this.economyRadioButton = new System.Windows.Forms.RadioButton();
			this.amenitiesGroupBox = new System.Windows.Forms.GroupBox();
			this.vipCheckBox = new System.Windows.Forms.CheckBox();
			this.mealsCheckBox = new System.Windows.Forms.CheckBox();
			this.bedCheckBox = new System.Windows.Forms.CheckBox();
			this.televisionCheckBox = new System.Windows.Forms.CheckBox();
			this.airconCheckBox = new System.Windows.Forms.CheckBox();
			this.toiletCheckBox = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.totalfareBox = new System.Windows.Forms.TextBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.clearButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.accomodationGroupBox.SuspendLayout();
			this.amenitiesGroupBox.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// accomodationGroupBox
			// 
			this.accomodationGroupBox.Controls.Add(this.cabinRadioButton);
			this.accomodationGroupBox.Controls.Add(this.touristRadioButton);
			this.accomodationGroupBox.Controls.Add(this.economyRadioButton);
			this.accomodationGroupBox.Location = new System.Drawing.Point(13, 13);
			this.accomodationGroupBox.Name = "accomodationGroupBox";
			this.accomodationGroupBox.Size = new System.Drawing.Size(139, 118);
			this.accomodationGroupBox.TabIndex = 0;
			this.accomodationGroupBox.TabStop = false;
			this.accomodationGroupBox.Text = "Accomodation Type";
			// 
			// cabinRadioButton
			// 
			this.cabinRadioButton.Location = new System.Drawing.Point(22, 79);
			this.cabinRadioButton.Name = "cabinRadioButton";
			this.cabinRadioButton.Size = new System.Drawing.Size(98, 24);
			this.cabinRadioButton.TabIndex = 0;
			this.cabinRadioButton.TabStop = true;
			this.cabinRadioButton.Text = "Cabin";
			this.cabinRadioButton.UseVisualStyleBackColor = true;
			this.cabinRadioButton.CheckedChanged += new System.EventHandler(this.CabinRadioButtonCheckedChanged);
			// 
			// touristRadioButton
			// 
			this.touristRadioButton.Location = new System.Drawing.Point(22, 49);
			this.touristRadioButton.Name = "touristRadioButton";
			this.touristRadioButton.Size = new System.Drawing.Size(98, 24);
			this.touristRadioButton.TabIndex = 0;
			this.touristRadioButton.TabStop = true;
			this.touristRadioButton.Text = "Tourist";
			this.touristRadioButton.UseVisualStyleBackColor = true;
			this.touristRadioButton.CheckedChanged += new System.EventHandler(this.TouristRadioButtonCheckedChanged);
			// 
			// economyRadioButton
			// 
			this.economyRadioButton.Location = new System.Drawing.Point(22, 19);
			this.economyRadioButton.Name = "economyRadioButton";
			this.economyRadioButton.Size = new System.Drawing.Size(98, 24);
			this.economyRadioButton.TabIndex = 0;
			this.economyRadioButton.TabStop = true;
			this.economyRadioButton.Text = "Economy";
			this.economyRadioButton.UseVisualStyleBackColor = true;
			this.economyRadioButton.CheckedChanged += new System.EventHandler(this.EconomyRadioButtonCheckedChanged);
			// 
			// amenitiesGroupBox
			// 
			this.amenitiesGroupBox.Controls.Add(this.vipCheckBox);
			this.amenitiesGroupBox.Controls.Add(this.mealsCheckBox);
			this.amenitiesGroupBox.Controls.Add(this.bedCheckBox);
			this.amenitiesGroupBox.Controls.Add(this.televisionCheckBox);
			this.amenitiesGroupBox.Controls.Add(this.airconCheckBox);
			this.amenitiesGroupBox.Controls.Add(this.toiletCheckBox);
			this.amenitiesGroupBox.Location = new System.Drawing.Point(158, 13);
			this.amenitiesGroupBox.Name = "amenitiesGroupBox";
			this.amenitiesGroupBox.Size = new System.Drawing.Size(130, 208);
			this.amenitiesGroupBox.TabIndex = 1;
			this.amenitiesGroupBox.TabStop = false;
			this.amenitiesGroupBox.Text = "Amenities";
			// 
			// vipCheckBox
			// 
			this.vipCheckBox.AutoCheck = false;
			this.vipCheckBox.Location = new System.Drawing.Point(21, 169);
			this.vipCheckBox.Name = "vipCheckBox";
			this.vipCheckBox.Size = new System.Drawing.Size(104, 24);
			this.vipCheckBox.TabIndex = 0;
			this.vipCheckBox.Text = "VIP";
			this.vipCheckBox.UseVisualStyleBackColor = true;
			// 
			// mealsCheckBox
			// 
			this.mealsCheckBox.AutoCheck = false;
			this.mealsCheckBox.Location = new System.Drawing.Point(21, 139);
			this.mealsCheckBox.Name = "mealsCheckBox";
			this.mealsCheckBox.Size = new System.Drawing.Size(104, 24);
			this.mealsCheckBox.TabIndex = 0;
			this.mealsCheckBox.Text = "Meals";
			this.mealsCheckBox.UseVisualStyleBackColor = true;
			// 
			// bedCheckBox
			// 
			this.bedCheckBox.AutoCheck = false;
			this.bedCheckBox.Location = new System.Drawing.Point(21, 109);
			this.bedCheckBox.Name = "bedCheckBox";
			this.bedCheckBox.Size = new System.Drawing.Size(104, 24);
			this.bedCheckBox.TabIndex = 0;
			this.bedCheckBox.Text = "Bed Sheets";
			this.bedCheckBox.UseVisualStyleBackColor = true;
			// 
			// televisionCheckBox
			// 
			this.televisionCheckBox.AutoCheck = false;
			this.televisionCheckBox.Location = new System.Drawing.Point(21, 79);
			this.televisionCheckBox.Name = "televisionCheckBox";
			this.televisionCheckBox.Size = new System.Drawing.Size(104, 24);
			this.televisionCheckBox.TabIndex = 0;
			this.televisionCheckBox.Text = "Television";
			this.televisionCheckBox.UseVisualStyleBackColor = true;
			// 
			// airconCheckBox
			// 
			this.airconCheckBox.AutoCheck = false;
			this.airconCheckBox.Location = new System.Drawing.Point(21, 49);
			this.airconCheckBox.Name = "airconCheckBox";
			this.airconCheckBox.Size = new System.Drawing.Size(104, 24);
			this.airconCheckBox.TabIndex = 0;
			this.airconCheckBox.Text = "Aircon";
			this.airconCheckBox.UseVisualStyleBackColor = true;
			// 
			// toiletCheckBox
			// 
			this.toiletCheckBox.AutoCheck = false;
			this.toiletCheckBox.Location = new System.Drawing.Point(21, 20);
			this.toiletCheckBox.Name = "toiletCheckBox";
			this.toiletCheckBox.Size = new System.Drawing.Size(104, 24);
			this.toiletCheckBox.TabIndex = 0;
			this.toiletCheckBox.Text = "Toilet";
			this.toiletCheckBox.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 224);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Total Fare:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// totalfareBox
			// 
			this.totalfareBox.Location = new System.Drawing.Point(119, 227);
			this.totalfareBox.Name = "totalfareBox";
			this.totalfareBox.Size = new System.Drawing.Size(169, 20);
			this.totalfareBox.TabIndex = 3;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 258);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(299, 22);
			this.statusStrip1.TabIndex = 4;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(177, 17);
			this.toolStripStatusLabel1.Text = "Jan Cyrus M. Villar | BS COE 1 - 6";
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(12, 137);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(140, 39);
			this.clearButton.TabIndex = 5;
			this.clearButton.Text = "&Clear";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(13, 182);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(139, 36);
			this.exitButton.TabIndex = 5;
			this.exitButton.Text = "&Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(299, 280);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.totalfareBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.amenitiesGroupBox);
			this.Controls.Add(this.accomodationGroupBox);
			this.Name = "MainForm";
			this.Text = "CruiseShip";
			this.accomodationGroupBox.ResumeLayout(false);
			this.amenitiesGroupBox.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
