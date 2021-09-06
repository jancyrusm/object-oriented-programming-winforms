/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 4/24/2021
 * Time: 6:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Compute
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox addendBox1;
		private System.Windows.Forms.TextBox addendBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button computeButton;
		private System.Windows.Forms.TextBox sumBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button exitButton;
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
			this.addendBox1 = new System.Windows.Forms.TextBox();
			this.addendBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.computeButton = new System.Windows.Forms.Button();
			this.sumBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.clearButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// addendBox1
			// 
			this.addendBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.addendBox1.Location = new System.Drawing.Point(169, 24);
			this.addendBox1.Name = "addendBox1";
			this.addendBox1.Size = new System.Drawing.Size(100, 20);
			this.addendBox1.TabIndex = 0;
			// 
			// addendBox2
			// 
			this.addendBox2.Location = new System.Drawing.Point(27, 24);
			this.addendBox2.Name = "addendBox2";
			this.addendBox2.Size = new System.Drawing.Size(100, 20);
			this.addendBox2.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(143, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(15, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "+";
			// 
			// computeButton
			// 
			this.computeButton.Location = new System.Drawing.Point(169, 59);
			this.computeButton.Name = "computeButton";
			this.computeButton.Size = new System.Drawing.Size(100, 59);
			this.computeButton.TabIndex = 4;
			this.computeButton.Text = "Compute";
			this.computeButton.UseVisualStyleBackColor = true;
			this.computeButton.Click += new System.EventHandler(this.ComputeButtonClick);
			// 
			// sumBox
			// 
			this.sumBox.Cursor = System.Windows.Forms.Cursors.No;
			this.sumBox.Location = new System.Drawing.Point(308, 25);
			this.sumBox.Name = "sumBox";
			this.sumBox.Size = new System.Drawing.Size(100, 20);
			this.sumBox.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(282, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(15, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "=";
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(27, 59);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(100, 59);
			this.clearButton.TabIndex = 7;
			this.clearButton.Text = "Clear";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(308, 59);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(100, 59);
			this.exitButton.TabIndex = 8;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButtonClick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 136);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(563, 22);
			this.statusStrip1.TabIndex = 9;
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
			this.pictureBox1.Location = new System.Drawing.Point(429, 25);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(113, 93);
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(563, 158);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.sumBox);
			this.Controls.Add(this.computeButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.addendBox2);
			this.Controls.Add(this.addendBox1);
			this.Name = "MainForm";
			this.Text = "Compute";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
