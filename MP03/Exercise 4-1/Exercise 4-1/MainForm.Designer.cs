/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 5/15/2021
 * Time: 1:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Exercise_4_1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RadioButton option1_radioButton;
		private System.Windows.Forms.RadioButton option2_radioButton;
		private System.Windows.Forms.RadioButton option3_radioButton;
		private System.Windows.Forms.TextBox radioButton_textBox;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.TextBox checkBox_textBox;
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
			this.option1_radioButton = new System.Windows.Forms.RadioButton();
			this.option2_radioButton = new System.Windows.Forms.RadioButton();
			this.option3_radioButton = new System.Windows.Forms.RadioButton();
			this.radioButton_textBox = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox_textBox = new System.Windows.Forms.TextBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// option1_radioButton
			// 
			this.option1_radioButton.Location = new System.Drawing.Point(13, 12);
			this.option1_radioButton.Name = "option1_radioButton";
			this.option1_radioButton.Size = new System.Drawing.Size(104, 24);
			this.option1_radioButton.TabIndex = 0;
			this.option1_radioButton.TabStop = true;
			this.option1_radioButton.Text = "Option 1";
			this.option1_radioButton.UseVisualStyleBackColor = true;
			this.option1_radioButton.CheckedChanged += new System.EventHandler(this.Option1_radioButtonCheckedChanged);
			// 
			// option2_radioButton
			// 
			this.option2_radioButton.Location = new System.Drawing.Point(124, 12);
			this.option2_radioButton.Name = "option2_radioButton";
			this.option2_radioButton.Size = new System.Drawing.Size(104, 24);
			this.option2_radioButton.TabIndex = 1;
			this.option2_radioButton.TabStop = true;
			this.option2_radioButton.Text = "Option 2";
			this.option2_radioButton.UseVisualStyleBackColor = true;
			this.option2_radioButton.CheckedChanged += new System.EventHandler(this.Option2_radioButtonCheckedChanged);
			// 
			// option3_radioButton
			// 
			this.option3_radioButton.Location = new System.Drawing.Point(235, 11);
			this.option3_radioButton.Name = "option3_radioButton";
			this.option3_radioButton.Size = new System.Drawing.Size(104, 24);
			this.option3_radioButton.TabIndex = 2;
			this.option3_radioButton.TabStop = true;
			this.option3_radioButton.Text = "Option 3";
			this.option3_radioButton.UseVisualStyleBackColor = true;
			this.option3_radioButton.CheckedChanged += new System.EventHandler(this.Option3_radioButtonCheckedChanged);
			// 
			// radioButton_textBox
			// 
			this.radioButton_textBox.Location = new System.Drawing.Point(13, 42);
			this.radioButton_textBox.Name = "radioButton_textBox";
			this.radioButton_textBox.Size = new System.Drawing.Size(305, 20);
			this.radioButton_textBox.TabIndex = 3;
			this.radioButton_textBox.TextChanged += new System.EventHandler(this.RadioButton_textBoxTextChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(13, 68);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(104, 24);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "checkBox1";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(124, 67);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(104, 24);
			this.checkBox2.TabIndex = 5;
			this.checkBox2.Text = "checkBox2";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2CheckedChanged);
			// 
			// checkBox3
			// 
			this.checkBox3.Location = new System.Drawing.Point(235, 68);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(104, 24);
			this.checkBox3.TabIndex = 6;
			this.checkBox3.Text = "checkBox3";
			this.checkBox3.UseVisualStyleBackColor = true;
			this.checkBox3.CheckedChanged += new System.EventHandler(this.CheckBox3CheckedChanged);
			// 
			// checkBox_textBox
			// 
			this.checkBox_textBox.Location = new System.Drawing.Point(13, 98);
			this.checkBox_textBox.Name = "checkBox_textBox";
			this.checkBox_textBox.Size = new System.Drawing.Size(305, 20);
			this.checkBox_textBox.TabIndex = 7;
			this.checkBox_textBox.TextChanged += new System.EventHandler(this.CheckBox_textBoxTextChanged);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 134);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(332, 22);
			this.statusStrip1.TabIndex = 8;
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
			this.ClientSize = new System.Drawing.Size(332, 156);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.checkBox_textBox);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.radioButton_textBox);
			this.Controls.Add(this.option3_radioButton);
			this.Controls.Add(this.option2_radioButton);
			this.Controls.Add(this.option1_radioButton);
			this.Name = "MainForm";
			this.Text = "Exercise 4-1";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
