/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 6/5/2021
 * Time: 12:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Pizza
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox ingredientsGroupBox;
		private System.Windows.Forms.CheckBox salamiCheckBox;
		private System.Windows.Forms.CheckBox tomato_pineappleCheckBox;
		private System.Windows.Forms.CheckBox onions_chiliCheckBox;
		private System.Windows.Forms.CheckBox mushroomsCheckBox;
		private System.Windows.Forms.CheckBox bacon_hamCheckBox;
		private System.Windows.Forms.CheckBox pepperCheckBox;
		private System.Windows.Forms.CheckBox cheeseCheckBox;
		private System.Windows.Forms.GroupBox pizzaGroupBox;
		private System.Windows.Forms.RadioButton primoRadioButton;
		private System.Windows.Forms.RadioButton specialRadioButton;
		private System.Windows.Forms.RadioButton deluxeRadioButton;
		private System.Windows.Forms.Button calculateButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox priceBox;
		private System.Windows.Forms.TextBox quantityBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.TextBox total_amountBox;
		
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
			this.ingredientsGroupBox = new System.Windows.Forms.GroupBox();
			this.salamiCheckBox = new System.Windows.Forms.CheckBox();
			this.tomato_pineappleCheckBox = new System.Windows.Forms.CheckBox();
			this.onions_chiliCheckBox = new System.Windows.Forms.CheckBox();
			this.mushroomsCheckBox = new System.Windows.Forms.CheckBox();
			this.bacon_hamCheckBox = new System.Windows.Forms.CheckBox();
			this.pepperCheckBox = new System.Windows.Forms.CheckBox();
			this.cheeseCheckBox = new System.Windows.Forms.CheckBox();
			this.pizzaGroupBox = new System.Windows.Forms.GroupBox();
			this.primoRadioButton = new System.Windows.Forms.RadioButton();
			this.specialRadioButton = new System.Windows.Forms.RadioButton();
			this.deluxeRadioButton = new System.Windows.Forms.RadioButton();
			this.calculateButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.priceBox = new System.Windows.Forms.TextBox();
			this.quantityBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.total_amountBox = new System.Windows.Forms.TextBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.ingredientsGroupBox.SuspendLayout();
			this.pizzaGroupBox.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ingredientsGroupBox
			// 
			this.ingredientsGroupBox.Controls.Add(this.salamiCheckBox);
			this.ingredientsGroupBox.Controls.Add(this.tomato_pineappleCheckBox);
			this.ingredientsGroupBox.Controls.Add(this.onions_chiliCheckBox);
			this.ingredientsGroupBox.Controls.Add(this.mushroomsCheckBox);
			this.ingredientsGroupBox.Controls.Add(this.bacon_hamCheckBox);
			this.ingredientsGroupBox.Controls.Add(this.pepperCheckBox);
			this.ingredientsGroupBox.Controls.Add(this.cheeseCheckBox);
			this.ingredientsGroupBox.Location = new System.Drawing.Point(157, 12);
			this.ingredientsGroupBox.Name = "ingredientsGroupBox";
			this.ingredientsGroupBox.Size = new System.Drawing.Size(164, 237);
			this.ingredientsGroupBox.TabIndex = 3;
			this.ingredientsGroupBox.TabStop = false;
			this.ingredientsGroupBox.Text = "Ingredients";
			// 
			// salamiCheckBox
			// 
			this.salamiCheckBox.AutoCheck = false;
			this.salamiCheckBox.Location = new System.Drawing.Point(21, 199);
			this.salamiCheckBox.Name = "salamiCheckBox";
			this.salamiCheckBox.Size = new System.Drawing.Size(133, 24);
			this.salamiCheckBox.TabIndex = 0;
			this.salamiCheckBox.Text = "Salami";
			this.salamiCheckBox.UseVisualStyleBackColor = true;
			// 
			// tomato_pineappleCheckBox
			// 
			this.tomato_pineappleCheckBox.AutoCheck = false;
			this.tomato_pineappleCheckBox.Location = new System.Drawing.Point(21, 169);
			this.tomato_pineappleCheckBox.Name = "tomato_pineappleCheckBox";
			this.tomato_pineappleCheckBox.Size = new System.Drawing.Size(133, 24);
			this.tomato_pineappleCheckBox.TabIndex = 0;
			this.tomato_pineappleCheckBox.Text = "Tomato and Pineapple";
			this.tomato_pineappleCheckBox.UseVisualStyleBackColor = true;
			// 
			// onions_chiliCheckBox
			// 
			this.onions_chiliCheckBox.AutoCheck = false;
			this.onions_chiliCheckBox.Location = new System.Drawing.Point(21, 139);
			this.onions_chiliCheckBox.Name = "onions_chiliCheckBox";
			this.onions_chiliCheckBox.Size = new System.Drawing.Size(104, 24);
			this.onions_chiliCheckBox.TabIndex = 0;
			this.onions_chiliCheckBox.Text = "Onions and Chili";
			this.onions_chiliCheckBox.UseVisualStyleBackColor = true;
			// 
			// mushroomsCheckBox
			// 
			this.mushroomsCheckBox.AutoCheck = false;
			this.mushroomsCheckBox.Location = new System.Drawing.Point(21, 109);
			this.mushroomsCheckBox.Name = "mushroomsCheckBox";
			this.mushroomsCheckBox.Size = new System.Drawing.Size(104, 24);
			this.mushroomsCheckBox.TabIndex = 0;
			this.mushroomsCheckBox.Text = "Mushrooms";
			this.mushroomsCheckBox.UseVisualStyleBackColor = true;
			// 
			// bacon_hamCheckBox
			// 
			this.bacon_hamCheckBox.AutoCheck = false;
			this.bacon_hamCheckBox.Location = new System.Drawing.Point(21, 79);
			this.bacon_hamCheckBox.Name = "bacon_hamCheckBox";
			this.bacon_hamCheckBox.Size = new System.Drawing.Size(104, 24);
			this.bacon_hamCheckBox.TabIndex = 0;
			this.bacon_hamCheckBox.Text = "Bacon and Ham";
			this.bacon_hamCheckBox.UseVisualStyleBackColor = true;
			// 
			// pepperCheckBox
			// 
			this.pepperCheckBox.AutoCheck = false;
			this.pepperCheckBox.Location = new System.Drawing.Point(21, 49);
			this.pepperCheckBox.Name = "pepperCheckBox";
			this.pepperCheckBox.Size = new System.Drawing.Size(104, 24);
			this.pepperCheckBox.TabIndex = 0;
			this.pepperCheckBox.Text = "Pepper";
			this.pepperCheckBox.UseVisualStyleBackColor = true;
			// 
			// cheeseCheckBox
			// 
			this.cheeseCheckBox.AutoCheck = false;
			this.cheeseCheckBox.Location = new System.Drawing.Point(21, 20);
			this.cheeseCheckBox.Name = "cheeseCheckBox";
			this.cheeseCheckBox.Size = new System.Drawing.Size(104, 24);
			this.cheeseCheckBox.TabIndex = 0;
			this.cheeseCheckBox.Text = "Cheese";
			this.cheeseCheckBox.UseVisualStyleBackColor = true;
			// 
			// pizzaGroupBox
			// 
			this.pizzaGroupBox.Controls.Add(this.primoRadioButton);
			this.pizzaGroupBox.Controls.Add(this.specialRadioButton);
			this.pizzaGroupBox.Controls.Add(this.deluxeRadioButton);
			this.pizzaGroupBox.Location = new System.Drawing.Point(12, 12);
			this.pizzaGroupBox.Name = "pizzaGroupBox";
			this.pizzaGroupBox.Size = new System.Drawing.Size(139, 118);
			this.pizzaGroupBox.TabIndex = 2;
			this.pizzaGroupBox.TabStop = false;
			this.pizzaGroupBox.Text = "Pizza";
			// 
			// primoRadioButton
			// 
			this.primoRadioButton.Location = new System.Drawing.Point(22, 79);
			this.primoRadioButton.Name = "primoRadioButton";
			this.primoRadioButton.Size = new System.Drawing.Size(98, 24);
			this.primoRadioButton.TabIndex = 0;
			this.primoRadioButton.TabStop = true;
			this.primoRadioButton.Text = "Primo";
			this.primoRadioButton.UseVisualStyleBackColor = true;
			this.primoRadioButton.CheckedChanged += new System.EventHandler(this.PrimoRadioButtonCheckedChanged);
			// 
			// specialRadioButton
			// 
			this.specialRadioButton.Location = new System.Drawing.Point(22, 49);
			this.specialRadioButton.Name = "specialRadioButton";
			this.specialRadioButton.Size = new System.Drawing.Size(98, 24);
			this.specialRadioButton.TabIndex = 0;
			this.specialRadioButton.TabStop = true;
			this.specialRadioButton.Text = "Special";
			this.specialRadioButton.UseVisualStyleBackColor = true;
			this.specialRadioButton.CheckedChanged += new System.EventHandler(this.SpecialRadioButtonCheckedChanged);
			// 
			// deluxeRadioButton
			// 
			this.deluxeRadioButton.Location = new System.Drawing.Point(22, 19);
			this.deluxeRadioButton.Name = "deluxeRadioButton";
			this.deluxeRadioButton.Size = new System.Drawing.Size(98, 24);
			this.deluxeRadioButton.TabIndex = 0;
			this.deluxeRadioButton.TabStop = true;
			this.deluxeRadioButton.Text = "Deluxe";
			this.deluxeRadioButton.UseVisualStyleBackColor = true;
			this.deluxeRadioButton.CheckedChanged += new System.EventHandler(this.DeluxeRadioButtonCheckedChanged);
			// 
			// calculateButton
			// 
			this.calculateButton.Location = new System.Drawing.Point(12, 203);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.Size = new System.Drawing.Size(139, 46);
			this.calculateButton.TabIndex = 4;
			this.calculateButton.Text = "Compute Now!";
			this.calculateButton.UseVisualStyleBackColor = true;
			this.calculateButton.Click += new System.EventHandler(this.CalculateButtonClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 137);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Price:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(3, 170);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Quantity:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priceBox
			// 
			this.priceBox.Location = new System.Drawing.Point(66, 139);
			this.priceBox.Name = "priceBox";
			this.priceBox.Size = new System.Drawing.Size(85, 20);
			this.priceBox.TabIndex = 6;
			// 
			// quantityBox
			// 
			this.quantityBox.Location = new System.Drawing.Point(66, 172);
			this.quantityBox.Name = "quantityBox";
			this.quantityBox.Size = new System.Drawing.Size(85, 20);
			this.quantityBox.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(3, 255);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Total Amount:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// total_amountBox
			// 
			this.total_amountBox.Location = new System.Drawing.Point(91, 258);
			this.total_amountBox.Name = "total_amountBox";
			this.total_amountBox.Size = new System.Drawing.Size(230, 20);
			this.total_amountBox.TabIndex = 6;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 288);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(334, 22);
			this.statusStrip1.TabIndex = 7;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(177, 17);
			this.toolStripStatusLabel1.Text = "Jan Cyrus M. Villar | BS COE 1 - 6";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 310);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.total_amountBox);
			this.Controls.Add(this.quantityBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.priceBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.calculateButton);
			this.Controls.Add(this.ingredientsGroupBox);
			this.Controls.Add(this.pizzaGroupBox);
			this.Name = "MainForm";
			this.Text = "Pizza";
			this.ingredientsGroupBox.ResumeLayout(false);
			this.pizzaGroupBox.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
