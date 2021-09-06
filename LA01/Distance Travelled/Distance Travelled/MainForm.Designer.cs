/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 5/12/2021
 * Time: 4:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Distance_Travelled
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox twelveHours;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox eightHours;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox fiveHours;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox inputBox;
		private System.Windows.Forms.Button calculateButton;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.twelveHours = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.eightHours = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.fiveHours = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.inputBox = new System.Windows.Forms.TextBox();
			this.calculateButton = new System.Windows.Forms.Button();
			this.clearButton = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.twelveHours);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.eightHours);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.fiveHours);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 65);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(374, 124);
			this.panel1.TabIndex = 1;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(334, 97);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(37, 20);
			this.label9.TabIndex = 9;
			this.label9.Text = "miles";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(334, 71);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(37, 20);
			this.label8.TabIndex = 8;
			this.label8.Text = "miles";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(334, 45);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 20);
			this.label7.TabIndex = 7;
			this.label7.Text = "miles";
			// 
			// twelveHours
			// 
			this.twelveHours.Location = new System.Drawing.Point(249, 94);
			this.twelveHours.Name = "twelveHours";
			this.twelveHours.Size = new System.Drawing.Size(79, 20);
			this.twelveHours.TabIndex = 6;
			this.twelveHours.TextChanged += new System.EventHandler(this.TwelveHoursTextChanged);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(30, 94);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(213, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = " The distance the car will travel in 12 hours:";
			// 
			// eightHours
			// 
			this.eightHours.Location = new System.Drawing.Point(249, 68);
			this.eightHours.Name = "eightHours";
			this.eightHours.Size = new System.Drawing.Size(79, 20);
			this.eightHours.TabIndex = 4;
			this.eightHours.TextChanged += new System.EventHandler(this.EightHoursTextChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(30, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(213, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = " The distance the car will travel in 8 hours:";
			// 
			// fiveHours
			// 
			this.fiveHours.Location = new System.Drawing.Point(249, 42);
			this.fiveHours.Name = "fiveHours";
			this.fiveHours.Size = new System.Drawing.Size(79, 20);
			this.fiveHours.TabIndex = 2;
			this.fiveHours.TextChanged += new System.EventHandler(this.FiveHoursTextChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(30, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(213, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = " The distance the car will travel in 5 hours:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(14, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "Results:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(26, 25);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(229, 23);
			this.label5.TabIndex = 2;
			this.label5.Text = "Please input the car\'s speed in miles per hour:";
			// 
			// inputBox
			// 
			this.inputBox.Location = new System.Drawing.Point(42, 51);
			this.inputBox.Name = "inputBox";
			this.inputBox.Size = new System.Drawing.Size(298, 20);
			this.inputBox.TabIndex = 3;
			// 
			// calculateButton
			// 
			this.calculateButton.Location = new System.Drawing.Point(48, 205);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.Size = new System.Drawing.Size(139, 42);
			this.calculateButton.TabIndex = 4;
			this.calculateButton.Text = "Calculate Distance Traveled";
			this.calculateButton.UseVisualStyleBackColor = true;
			this.calculateButton.Click += new System.EventHandler(this.CalculateButtonClick);
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(213, 205);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(139, 42);
			this.clearButton.TabIndex = 5;
			this.clearButton.Text = "Clear";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(346, 55);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(27, 20);
			this.label6.TabIndex = 6;
			this.label6.Text = "mph";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 263);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(766, 22);
			this.statusStrip1.TabIndex = 7;
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
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(416, 25);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(332, 222);
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(766, 285);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.calculateButton);
			this.Controls.Add(this.inputBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.Text = "Distance Travelled";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
