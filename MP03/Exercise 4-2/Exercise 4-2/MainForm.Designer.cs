/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 5/15/2021
 * Time: 1:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Exercise_4_2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton firstYear_radioButton;
		private System.Windows.Forms.RadioButton secondYear_radioButton;
		private System.Windows.Forms.RadioButton thirdYear_radioButton;
		private System.Windows.Forms.RadioButton fourthYear_radioButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox output_textBox;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.firstYear_radioButton = new System.Windows.Forms.RadioButton();
			this.secondYear_radioButton = new System.Windows.Forms.RadioButton();
			this.thirdYear_radioButton = new System.Windows.Forms.RadioButton();
			this.fourthYear_radioButton = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.output_textBox = new System.Windows.Forms.TextBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "High School Level:";
			// 
			// firstYear_radioButton
			// 
			this.firstYear_radioButton.Location = new System.Drawing.Point(13, 35);
			this.firstYear_radioButton.Name = "firstYear_radioButton";
			this.firstYear_radioButton.Size = new System.Drawing.Size(104, 24);
			this.firstYear_radioButton.TabIndex = 1;
			this.firstYear_radioButton.TabStop = true;
			this.firstYear_radioButton.Text = "First Year";
			this.firstYear_radioButton.UseVisualStyleBackColor = true;
			this.firstYear_radioButton.CheckedChanged += new System.EventHandler(this.FirstYear_radioButtonCheckedChanged);
			// 
			// secondYear_radioButton
			// 
			this.secondYear_radioButton.Location = new System.Drawing.Point(13, 66);
			this.secondYear_radioButton.Name = "secondYear_radioButton";
			this.secondYear_radioButton.Size = new System.Drawing.Size(104, 24);
			this.secondYear_radioButton.TabIndex = 2;
			this.secondYear_radioButton.TabStop = true;
			this.secondYear_radioButton.Text = "Second Year";
			this.secondYear_radioButton.UseVisualStyleBackColor = true;
			this.secondYear_radioButton.CheckedChanged += new System.EventHandler(this.SecondYear_radioButtonCheckedChanged);
			// 
			// thirdYear_radioButton
			// 
			this.thirdYear_radioButton.Location = new System.Drawing.Point(13, 97);
			this.thirdYear_radioButton.Name = "thirdYear_radioButton";
			this.thirdYear_radioButton.Size = new System.Drawing.Size(104, 24);
			this.thirdYear_radioButton.TabIndex = 3;
			this.thirdYear_radioButton.TabStop = true;
			this.thirdYear_radioButton.Text = "Third Year";
			this.thirdYear_radioButton.UseVisualStyleBackColor = true;
			this.thirdYear_radioButton.CheckedChanged += new System.EventHandler(this.ThirdYear_radioButtonCheckedChanged);
			// 
			// fourthYear_radioButton
			// 
			this.fourthYear_radioButton.Location = new System.Drawing.Point(13, 128);
			this.fourthYear_radioButton.Name = "fourthYear_radioButton";
			this.fourthYear_radioButton.Size = new System.Drawing.Size(104, 24);
			this.fourthYear_radioButton.TabIndex = 4;
			this.fourthYear_radioButton.TabStop = true;
			this.fourthYear_radioButton.Text = "Fourth Year";
			this.fourthYear_radioButton.UseVisualStyleBackColor = true;
			this.fourthYear_radioButton.CheckedChanged += new System.EventHandler(this.FourthYear_radioButtonCheckedChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 167);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "is also called as:";
			// 
			// output_textBox
			// 
			this.output_textBox.Location = new System.Drawing.Point(119, 167);
			this.output_textBox.Name = "output_textBox";
			this.output_textBox.Size = new System.Drawing.Size(131, 20);
			this.output_textBox.TabIndex = 6;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 196);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(284, 22);
			this.statusStrip1.TabIndex = 7;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(183, 17);
			this.toolStripStatusLabel1.Text = "Jan Cyrus M. Villar | BS  COE 1 -  6";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 218);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.output_textBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.fourthYear_radioButton);
			this.Controls.Add(this.thirdYear_radioButton);
			this.Controls.Add(this.secondYear_radioButton);
			this.Controls.Add(this.firstYear_radioButton);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Exercise 4-2";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
