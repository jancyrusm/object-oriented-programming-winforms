/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 5/22/2021
 * Time: 2:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MultiplicationTable
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox multiplicandBox;
		private System.Windows.Forms.TextBox multiplierBox;
		private System.Windows.Forms.TextBox productBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button calculateButton;
		private System.Windows.Forms.Button exitButton;
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
			this.multiplicandBox = new System.Windows.Forms.TextBox();
			this.multiplierBox = new System.Windows.Forms.TextBox();
			this.productBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.calculateButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// multiplicandBox
			// 
			this.multiplicandBox.Location = new System.Drawing.Point(13, 26);
			this.multiplicandBox.Name = "multiplicandBox";
			this.multiplicandBox.Size = new System.Drawing.Size(68, 20);
			this.multiplicandBox.TabIndex = 0;
			// 
			// multiplierBox
			// 
			this.multiplierBox.Location = new System.Drawing.Point(115, 26);
			this.multiplierBox.Name = "multiplierBox";
			this.multiplierBox.Size = new System.Drawing.Size(68, 20);
			this.multiplierBox.TabIndex = 1;
			// 
			// productBox
			// 
			this.productBox.Location = new System.Drawing.Point(216, 26);
			this.productBox.Name = "productBox";
			this.productBox.Size = new System.Drawing.Size(68, 20);
			this.productBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(88, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "x";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(189, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(21, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "=";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// calculateButton
			// 
			this.calculateButton.Location = new System.Drawing.Point(50, 66);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.Size = new System.Drawing.Size(95, 33);
			this.calculateButton.TabIndex = 5;
			this.calculateButton.Text = "Show Answer";
			this.calculateButton.UseVisualStyleBackColor = true;
			this.calculateButton.Click += new System.EventHandler(this.CalculateButtonClick);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(168, 66);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 33);
			this.exitButton.TabIndex = 6;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButtonClick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 122);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(298, 22);
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
			this.ClientSize = new System.Drawing.Size(298, 144);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.calculateButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.productBox);
			this.Controls.Add(this.multiplierBox);
			this.Controls.Add(this.multiplicandBox);
			this.Name = "MainForm";
			this.Text = "MultiplicationTable";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
