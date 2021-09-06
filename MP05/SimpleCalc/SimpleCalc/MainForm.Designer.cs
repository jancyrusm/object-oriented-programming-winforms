/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 6/5/2021
 * Time: 11:24 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SimpleCalc
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox calcGroupBox;
		private System.Windows.Forms.RadioButton divideRadioButton;
		private System.Windows.Forms.RadioButton multiplyRadioButton;
		private System.Windows.Forms.RadioButton subtractRadioButton;
		private System.Windows.Forms.RadioButton addRadioButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox firstBox;
		private System.Windows.Forms.TextBox secondBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox resultsBox;
		private System.Windows.Forms.Label label4;
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
			this.calcGroupBox = new System.Windows.Forms.GroupBox();
			this.divideRadioButton = new System.Windows.Forms.RadioButton();
			this.multiplyRadioButton = new System.Windows.Forms.RadioButton();
			this.subtractRadioButton = new System.Windows.Forms.RadioButton();
			this.addRadioButton = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.firstBox = new System.Windows.Forms.TextBox();
			this.secondBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.resultsBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.calcGroupBox.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// calcGroupBox
			// 
			this.calcGroupBox.Controls.Add(this.divideRadioButton);
			this.calcGroupBox.Controls.Add(this.multiplyRadioButton);
			this.calcGroupBox.Controls.Add(this.subtractRadioButton);
			this.calcGroupBox.Controls.Add(this.addRadioButton);
			this.calcGroupBox.Location = new System.Drawing.Point(13, 13);
			this.calcGroupBox.Name = "calcGroupBox";
			this.calcGroupBox.Size = new System.Drawing.Size(119, 149);
			this.calcGroupBox.TabIndex = 0;
			this.calcGroupBox.TabStop = false;
			this.calcGroupBox.Text = "Compute";
			// 
			// divideRadioButton
			// 
			this.divideRadioButton.Location = new System.Drawing.Point(17, 110);
			this.divideRadioButton.Name = "divideRadioButton";
			this.divideRadioButton.Size = new System.Drawing.Size(96, 24);
			this.divideRadioButton.TabIndex = 0;
			this.divideRadioButton.Text = "Divide";
			this.divideRadioButton.UseVisualStyleBackColor = true;
			this.divideRadioButton.CheckedChanged += new System.EventHandler(this.DivideRadioButtonCheckedChanged);
			// 
			// multiplyRadioButton
			// 
			this.multiplyRadioButton.Location = new System.Drawing.Point(17, 80);
			this.multiplyRadioButton.Name = "multiplyRadioButton";
			this.multiplyRadioButton.Size = new System.Drawing.Size(96, 24);
			this.multiplyRadioButton.TabIndex = 0;
			this.multiplyRadioButton.Text = "Multiply";
			this.multiplyRadioButton.UseVisualStyleBackColor = true;
			this.multiplyRadioButton.CheckedChanged += new System.EventHandler(this.MultiplyRadioButtonCheckedChanged);
			// 
			// subtractRadioButton
			// 
			this.subtractRadioButton.Location = new System.Drawing.Point(17, 50);
			this.subtractRadioButton.Name = "subtractRadioButton";
			this.subtractRadioButton.Size = new System.Drawing.Size(96, 24);
			this.subtractRadioButton.TabIndex = 0;
			this.subtractRadioButton.Text = "Subtract";
			this.subtractRadioButton.UseVisualStyleBackColor = true;
			this.subtractRadioButton.CheckedChanged += new System.EventHandler(this.SubtractRadioButtonCheckedChanged);
			// 
			// addRadioButton
			// 
			this.addRadioButton.Location = new System.Drawing.Point(17, 20);
			this.addRadioButton.Name = "addRadioButton";
			this.addRadioButton.Size = new System.Drawing.Size(96, 24);
			this.addRadioButton.TabIndex = 0;
			this.addRadioButton.Text = "Add";
			this.addRadioButton.UseVisualStyleBackColor = true;
			this.addRadioButton.CheckedChanged += new System.EventHandler(this.AddRadioButtonCheckedChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(156, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "First Number:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(156, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Second Number:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// firstBox
			// 
			this.firstBox.Location = new System.Drawing.Point(263, 36);
			this.firstBox.Name = "firstBox";
			this.firstBox.Size = new System.Drawing.Size(100, 20);
			this.firstBox.TabIndex = 3;
			// 
			// secondBox
			// 
			this.secondBox.Location = new System.Drawing.Point(262, 66);
			this.secondBox.Name = "secondBox";
			this.secondBox.Size = new System.Drawing.Size(100, 20);
			this.secondBox.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(157, 124);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Answer:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// resultsBox
			// 
			this.resultsBox.Location = new System.Drawing.Point(263, 127);
			this.resultsBox.Name = "resultsBox";
			this.resultsBox.Size = new System.Drawing.Size(100, 20);
			this.resultsBox.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(218, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "=";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 172);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(387, 22);
			this.statusStrip1.TabIndex = 5;
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
			this.ClientSize = new System.Drawing.Size(387, 194);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.resultsBox);
			this.Controls.Add(this.secondBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.firstBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.calcGroupBox);
			this.Name = "MainForm";
			this.Text = "SimpleCalc";
			this.calcGroupBox.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
