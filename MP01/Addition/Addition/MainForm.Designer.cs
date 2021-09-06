/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 4/24/2021
 * Time: 4:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Addition
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox secondBox;
		private System.Windows.Forms.TextBox firstBox;
		private System.Windows.Forms.TextBox resultsBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button multiplyButton;
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
			this.AddButton = new System.Windows.Forms.Button();
			this.ClearButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.secondBox = new System.Windows.Forms.TextBox();
			this.firstBox = new System.Windows.Forms.TextBox();
			this.resultsBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.multiplyButton = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// AddButton
			// 
			this.AddButton.BackColor = System.Drawing.Color.Transparent;
			this.AddButton.Location = new System.Drawing.Point(298, 46);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(259, 23);
			this.AddButton.TabIndex = 0;
			this.AddButton.Text = "Add";
			this.AddButton.UseVisualStyleBackColor = false;
			this.AddButton.Click += new System.EventHandler(this.AddButtonClick);
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(298, 147);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(128, 23);
			this.ClearButton.TabIndex = 1;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButtonClick);
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(433, 147);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(124, 23);
			this.ExitButton.TabIndex = 2;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButtonClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(11, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(259, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Enter first number:";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(12, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(260, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Enter second number:";
			// 
			// secondBox
			// 
			this.secondBox.Location = new System.Drawing.Point(35, 97);
			this.secondBox.Name = "secondBox";
			this.secondBox.Size = new System.Drawing.Size(235, 20);
			this.secondBox.TabIndex = 5;
			// 
			// firstBox
			// 
			this.firstBox.Location = new System.Drawing.Point(35, 49);
			this.firstBox.Name = "firstBox";
			this.firstBox.Size = new System.Drawing.Size(236, 20);
			this.firstBox.TabIndex = 6;
			// 
			// resultsBox
			// 
			this.resultsBox.Location = new System.Drawing.Point(35, 147);
			this.resultsBox.Name = "resultsBox";
			this.resultsBox.Size = new System.Drawing.Size(235, 20);
			this.resultsBox.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(12, 126);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(260, 15);
			this.label3.TabIndex = 7;
			this.label3.Text = "Result:";
			// 
			// multiplyButton
			// 
			this.multiplyButton.Location = new System.Drawing.Point(298, 97);
			this.multiplyButton.Name = "multiplyButton";
			this.multiplyButton.Size = new System.Drawing.Size(259, 23);
			this.multiplyButton.TabIndex = 9;
			this.multiplyButton.Text = "Multiply";
			this.multiplyButton.UseVisualStyleBackColor = true;
			this.multiplyButton.Click += new System.EventHandler(this.MultiplyButtonClick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 210);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(808, 22);
			this.statusStrip1.TabIndex = 10;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(177, 17);
			this.toolStripStatusLabel1.Text = "Jan Cyrus M. Villar | BS COE 1 - 6";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Location = new System.Drawing.Point(610, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(177, 201);
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(808, 232);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.multiplyButton);
			this.Controls.Add(this.resultsBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.firstBox);
			this.Controls.Add(this.secondBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.AddButton);
			this.Name = "MainForm";
			this.Text = "Addition";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		}
	}
