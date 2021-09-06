/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 5/12/2021
 * Time: 9:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PayrollGUI
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox name_inputBox;
		private System.Windows.Forms.TextBox ssn_inputBox;
		private System.Windows.Forms.TextBox hpr_inputBox;
		private System.Windows.Forms.TextBox workHours_inputBox;
		private System.Windows.Forms.Button generateButton;
		private System.Windows.Forms.TextBox swt_resultBox;
		private System.Windows.Forms.TextBox fwt_resultBox;
		private System.Windows.Forms.TextBox grossPay_resultBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox workHours_resultBox;
		private System.Windows.Forms.TextBox hpr_resultBox;
		private System.Windows.Forms.TextBox ssn_resultBox;
		private System.Windows.Forms.TextBox name_resultBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox netPay_resultBox;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.name_inputBox = new System.Windows.Forms.TextBox();
			this.ssn_inputBox = new System.Windows.Forms.TextBox();
			this.hpr_inputBox = new System.Windows.Forms.TextBox();
			this.workHours_inputBox = new System.Windows.Forms.TextBox();
			this.generateButton = new System.Windows.Forms.Button();
			this.swt_resultBox = new System.Windows.Forms.TextBox();
			this.fwt_resultBox = new System.Windows.Forms.TextBox();
			this.grossPay_resultBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.workHours_resultBox = new System.Windows.Forms.TextBox();
			this.hpr_resultBox = new System.Windows.Forms.TextBox();
			this.ssn_resultBox = new System.Windows.Forms.TextBox();
			this.name_resultBox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.netPay_resultBox = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.statusStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(112, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(31, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Social Security Number:";
			// 
			// label3
			// 
			this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label3.Location = new System.Drawing.Point(63, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(101, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Hourly Pay Rate:  ";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(140, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Number of hours worked:";
			// 
			// name_inputBox
			// 
			this.name_inputBox.Location = new System.Drawing.Point(158, 19);
			this.name_inputBox.Name = "name_inputBox";
			this.name_inputBox.Size = new System.Drawing.Size(202, 20);
			this.name_inputBox.TabIndex = 5;
			// 
			// ssn_inputBox
			// 
			this.ssn_inputBox.Location = new System.Drawing.Point(158, 42);
			this.ssn_inputBox.Name = "ssn_inputBox";
			this.ssn_inputBox.Size = new System.Drawing.Size(202, 20);
			this.ssn_inputBox.TabIndex = 5;
			// 
			// hpr_inputBox
			// 
			this.hpr_inputBox.Location = new System.Drawing.Point(158, 65);
			this.hpr_inputBox.Name = "hpr_inputBox";
			this.hpr_inputBox.Size = new System.Drawing.Size(202, 20);
			this.hpr_inputBox.TabIndex = 5;
			// 
			// workHours_inputBox
			// 
			this.workHours_inputBox.Location = new System.Drawing.Point(158, 88);
			this.workHours_inputBox.Name = "workHours_inputBox";
			this.workHours_inputBox.Size = new System.Drawing.Size(202, 20);
			this.workHours_inputBox.TabIndex = 6;
			// 
			// generateButton
			// 
			this.generateButton.Location = new System.Drawing.Point(126, 138);
			this.generateButton.Name = "generateButton";
			this.generateButton.Size = new System.Drawing.Size(133, 35);
			this.generateButton.TabIndex = 7;
			this.generateButton.Text = "Generate";
			this.generateButton.UseVisualStyleBackColor = true;
			this.generateButton.Click += new System.EventHandler(this.GenerateButtonClick);
			// 
			// swt_resultBox
			// 
			this.swt_resultBox.Location = new System.Drawing.Point(160, 174);
			this.swt_resultBox.Name = "swt_resultBox";
			this.swt_resultBox.Size = new System.Drawing.Size(202, 20);
			this.swt_resultBox.TabIndex = 34;
			this.swt_resultBox.TextChanged += new System.EventHandler(this.Swt_resultBoxTextChanged);
			// 
			// fwt_resultBox
			// 
			this.fwt_resultBox.Location = new System.Drawing.Point(160, 151);
			this.fwt_resultBox.Name = "fwt_resultBox";
			this.fwt_resultBox.Size = new System.Drawing.Size(202, 20);
			this.fwt_resultBox.TabIndex = 32;
			this.fwt_resultBox.TextChanged += new System.EventHandler(this.Fwt_resultBoxTextChanged);
			// 
			// grossPay_resultBox
			// 
			this.grossPay_resultBox.Location = new System.Drawing.Point(160, 128);
			this.grossPay_resultBox.Name = "grossPay_resultBox";
			this.grossPay_resultBox.Size = new System.Drawing.Size(202, 20);
			this.grossPay_resultBox.TabIndex = 33;
			this.grossPay_resultBox.TextChanged += new System.EventHandler(this.GrossPay_resultBoxTextChanged);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(26, 177);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(128, 23);
			this.label6.TabIndex = 31;
			this.label6.Text = "State Withholding Tax:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label7
			// 
			this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label7.Location = new System.Drawing.Point(26, 154);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(128, 23);
			this.label7.TabIndex = 30;
			this.label7.Text = "Federal Withholding Tax:  ";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(33, 131);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(121, 23);
			this.label8.TabIndex = 29;
			this.label8.Text = "Gross Pay:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// workHours_resultBox
			// 
			this.workHours_resultBox.Location = new System.Drawing.Point(160, 87);
			this.workHours_resultBox.Name = "workHours_resultBox";
			this.workHours_resultBox.Size = new System.Drawing.Size(202, 20);
			this.workHours_resultBox.TabIndex = 28;
			this.workHours_resultBox.TextChanged += new System.EventHandler(this.WorkHours_resultBoxTextChanged);
			// 
			// hpr_resultBox
			// 
			this.hpr_resultBox.Location = new System.Drawing.Point(160, 64);
			this.hpr_resultBox.Name = "hpr_resultBox";
			this.hpr_resultBox.Size = new System.Drawing.Size(202, 20);
			this.hpr_resultBox.TabIndex = 25;
			this.hpr_resultBox.TextChanged += new System.EventHandler(this.Hpr_resultBoxTextChanged);
			// 
			// ssn_resultBox
			// 
			this.ssn_resultBox.Location = new System.Drawing.Point(160, 41);
			this.ssn_resultBox.Name = "ssn_resultBox";
			this.ssn_resultBox.Size = new System.Drawing.Size(202, 20);
			this.ssn_resultBox.TabIndex = 26;
			this.ssn_resultBox.TextChanged += new System.EventHandler(this.Ssn_resultBoxTextChanged);
			// 
			// name_resultBox
			// 
			this.name_resultBox.Location = new System.Drawing.Point(160, 18);
			this.name_resultBox.Name = "name_resultBox";
			this.name_resultBox.Size = new System.Drawing.Size(202, 20);
			this.name_resultBox.TabIndex = 27;
			this.name_resultBox.TextChanged += new System.EventHandler(this.Name_resultBoxTextChanged);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(26, 90);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(128, 23);
			this.label9.TabIndex = 24;
			this.label9.Text = "Number of hours worked:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label10
			// 
			this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label10.Location = new System.Drawing.Point(65, 67);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(89, 23);
			this.label10.TabIndex = 23;
			this.label10.Text = "Hourly Pay Rate:  ";
			this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(33, 44);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(121, 23);
			this.label11.TabIndex = 22;
			this.label11.Text = "Social Security Number:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(114, 21);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(40, 23);
			this.label12.TabIndex = 21;
			this.label12.Text = "Name:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// netPay_resultBox
			// 
			this.netPay_resultBox.Location = new System.Drawing.Point(160, 197);
			this.netPay_resultBox.Name = "netPay_resultBox";
			this.netPay_resultBox.Size = new System.Drawing.Size(202, 20);
			this.netPay_resultBox.TabIndex = 36;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(26, 197);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(128, 23);
			this.label13.TabIndex = 35;
			this.label13.Text = "Net Pay:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 423);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(396, 22);
			this.statusStrip1.TabIndex = 37;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(177, 17);
			this.toolStripStatusLabel1.Text = "Jan Cyrus M. Villar | BS COE 1 - 6";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.netPay_resultBox);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.swt_resultBox);
			this.groupBox1.Controls.Add(this.fwt_resultBox);
			this.groupBox1.Controls.Add(this.grossPay_resultBox);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.workHours_resultBox);
			this.groupBox1.Controls.Add(this.hpr_resultBox);
			this.groupBox1.Controls.Add(this.ssn_resultBox);
			this.groupBox1.Controls.Add(this.name_resultBox);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Location = new System.Drawing.Point(14, 179);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(373, 231);
			this.groupBox1.TabIndex = 38;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Payroll Output";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.workHours_inputBox);
			this.groupBox2.Controls.Add(this.hpr_inputBox);
			this.groupBox2.Controls.Add(this.ssn_inputBox);
			this.groupBox2.Controls.Add(this.name_inputBox);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(14, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(370, 120);
			this.groupBox2.TabIndex = 39;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Please input the following:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(396, 445);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.generateButton);
			this.Name = "MainForm";
			this.Text = "PayrollGUI";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
