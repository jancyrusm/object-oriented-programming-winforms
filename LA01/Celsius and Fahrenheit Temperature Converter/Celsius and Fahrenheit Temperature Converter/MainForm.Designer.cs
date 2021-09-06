/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 5/12/2021
 * Time: 4:07 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Celsius_and_Fahrenheit_Temperature_Converter
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label inputLabel;
		private System.Windows.Forms.TextBox inputBox;
		private System.Windows.Forms.Button celsiusButton;
		private System.Windows.Forms.Button farenheitButton;
		private System.Windows.Forms.TextBox resultsBox;
		private System.Windows.Forms.Label resultsLabel;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.inputLabel = new System.Windows.Forms.Label();
			this.inputBox = new System.Windows.Forms.TextBox();
			this.celsiusButton = new System.Windows.Forms.Button();
			this.farenheitButton = new System.Windows.Forms.Button();
			this.resultsBox = new System.Windows.Forms.TextBox();
			this.resultsLabel = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// inputLabel
			// 
			this.inputLabel.Location = new System.Drawing.Point(19, 19);
			this.inputLabel.Name = "inputLabel";
			this.inputLabel.Size = new System.Drawing.Size(242, 20);
			this.inputLabel.TabIndex = 0;
			this.inputLabel.Text = "Enter temperature:";
			// 
			// inputBox
			// 
			this.inputBox.Location = new System.Drawing.Point(19, 43);
			this.inputBox.Name = "inputBox";
			this.inputBox.Size = new System.Drawing.Size(242, 20);
			this.inputBox.TabIndex = 1;
			// 
			// celsiusButton
			// 
			this.celsiusButton.Location = new System.Drawing.Point(19, 84);
			this.celsiusButton.Name = "celsiusButton";
			this.celsiusButton.Size = new System.Drawing.Size(108, 45);
			this.celsiusButton.TabIndex = 2;
			this.celsiusButton.Text = "Convert to Celsius";
			this.celsiusButton.UseVisualStyleBackColor = true;
			this.celsiusButton.Click += new System.EventHandler(this.CelsiusButtonClick);
			// 
			// farenheitButton
			// 
			this.farenheitButton.Location = new System.Drawing.Point(149, 84);
			this.farenheitButton.Name = "farenheitButton";
			this.farenheitButton.Size = new System.Drawing.Size(112, 45);
			this.farenheitButton.TabIndex = 3;
			this.farenheitButton.Text = "Convert to Farenheit";
			this.farenheitButton.UseVisualStyleBackColor = true;
			this.farenheitButton.Click += new System.EventHandler(this.FarenheitButtonClick);
			// 
			// resultsBox
			// 
			this.resultsBox.Location = new System.Drawing.Point(19, 167);
			this.resultsBox.Name = "resultsBox";
			this.resultsBox.Size = new System.Drawing.Size(242, 20);
			this.resultsBox.TabIndex = 5;
			this.resultsBox.TextChanged += new System.EventHandler(this.ResultsBoxTextChanged);
			// 
			// resultsLabel
			// 
			this.resultsLabel.Location = new System.Drawing.Point(19, 143);
			this.resultsLabel.Name = "resultsLabel";
			this.resultsLabel.Size = new System.Drawing.Size(242, 20);
			this.resultsLabel.TabIndex = 4;
			this.resultsLabel.Text = "Result:";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 204);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(542, 22);
			this.statusStrip1.TabIndex = 6;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(177, 17);
			this.toolStripStatusLabel1.Text = "Jan Cyrus M. Villar | BS COE 1 - 6";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(287, 21);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(242, 165);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(542, 226);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.resultsBox);
			this.Controls.Add(this.resultsLabel);
			this.Controls.Add(this.farenheitButton);
			this.Controls.Add(this.celsiusButton);
			this.Controls.Add(this.inputBox);
			this.Controls.Add(this.inputLabel);
			this.Name = "MainForm";
			this.Text = "Celsius and Fahrenheit Temperature Converter";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
