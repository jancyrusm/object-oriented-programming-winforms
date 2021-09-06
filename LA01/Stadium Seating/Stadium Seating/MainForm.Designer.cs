/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 5/12/2021
 * Time: 4:23 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Stadium_Seating
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox classC_inputBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox classB_inputBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox classA_inputBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox totalBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox classC_resultsBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox classB_resultsBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox classA_resultsBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button calculateButton;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.PictureBox pictureBox1;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.classC_inputBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.classB_inputBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.classA_inputBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.calculateButton = new System.Windows.Forms.Button();
			this.clearButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.classA_resultsBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.classB_resultsBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.classC_resultsBox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.totalBox = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.groupBox1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.classC_inputBox);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.classB_inputBox);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.classA_inputBox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(21, 19);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(219, 162);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Enter the number of tickets sold for each class of seats.";
			// 
			// classC_inputBox
			// 
			this.classC_inputBox.Location = new System.Drawing.Point(85, 103);
			this.classC_inputBox.Name = "classC_inputBox";
			this.classC_inputBox.Size = new System.Drawing.Size(100, 20);
			this.classC_inputBox.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(32, 103);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "Class C:";
			// 
			// classB_inputBox
			// 
			this.classB_inputBox.Location = new System.Drawing.Point(85, 77);
			this.classB_inputBox.Name = "classB_inputBox";
			this.classB_inputBox.Size = new System.Drawing.Size(100, 20);
			this.classB_inputBox.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(32, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "Class B:";
			// 
			// classA_inputBox
			// 
			this.classA_inputBox.Location = new System.Drawing.Point(85, 51);
			this.classA_inputBox.Name = "classA_inputBox";
			this.classA_inputBox.Size = new System.Drawing.Size(100, 20);
			this.classA_inputBox.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(32, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Class A:";
			// 
			// calculateButton
			// 
			this.calculateButton.Location = new System.Drawing.Point(20, 197);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.Size = new System.Drawing.Size(152, 74);
			this.calculateButton.TabIndex = 8;
			this.calculateButton.Text = "Calculate Revenue";
			this.calculateButton.UseVisualStyleBackColor = true;
			this.calculateButton.Click += new System.EventHandler(this.CalculateButtonClick);
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(178, 197);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(145, 74);
			this.clearButton.TabIndex = 9;
			this.clearButton.Text = "Clear";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(329, 197);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(151, 74);
			this.exitButton.TabIndex = 10;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButtonClick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 289);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(769, 22);
			this.statusStrip1.TabIndex = 11;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(174, 17);
			this.toolStripStatusLabel1.Text = "Jan Cyrus M. Villar | BS COE 1- 6";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(499, 19);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(248, 252);
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.totalBox);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.classC_resultsBox);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.classB_resultsBox);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.classA_resultsBox);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(219, 162);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Revenue Generated:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(31, 40);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 20);
			this.label7.TabIndex = 1;
			this.label7.Text = "Class A:";
			// 
			// classA_resultsBox
			// 
			this.classA_resultsBox.Location = new System.Drawing.Point(84, 40);
			this.classA_resultsBox.Name = "classA_resultsBox";
			this.classA_resultsBox.Size = new System.Drawing.Size(100, 20);
			this.classA_resultsBox.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(31, 66);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 20);
			this.label6.TabIndex = 3;
			this.label6.Text = "Class B:";
			// 
			// classB_resultsBox
			// 
			this.classB_resultsBox.Location = new System.Drawing.Point(84, 66);
			this.classB_resultsBox.Name = "classB_resultsBox";
			this.classB_resultsBox.Size = new System.Drawing.Size(100, 20);
			this.classB_resultsBox.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(31, 92);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 20);
			this.label5.TabIndex = 5;
			this.label5.Text = "Class C:";
			// 
			// classC_resultsBox
			// 
			this.classC_resultsBox.Location = new System.Drawing.Point(84, 92);
			this.classC_resultsBox.Name = "classC_resultsBox";
			this.classC_resultsBox.Size = new System.Drawing.Size(100, 20);
			this.classC_resultsBox.TabIndex = 6;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(43, 118);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(34, 20);
			this.label9.TabIndex = 7;
			this.label9.Text = "Total:";
			// 
			// totalBox
			// 
			this.totalBox.Location = new System.Drawing.Point(84, 118);
			this.totalBox.Name = "totalBox";
			this.totalBox.Size = new System.Drawing.Size(100, 20);
			this.totalBox.TabIndex = 8;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.groupBox2);
			this.panel2.Location = new System.Drawing.Point(259, 19);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(222, 162);
			this.panel2.TabIndex = 7;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(769, 311);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.calculateButton);
			this.Controls.Add(this.panel2);
			this.Name = "MainForm";
			this.Text = "Stadium Seating";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
