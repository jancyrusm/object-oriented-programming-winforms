/*
 * Created by SharpDevelop.
 * User: Cyrus
 * Date: 6/5/2021
 * Time: 11:08 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Color_Theme
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox colorGroupBox;
		private System.Windows.Forms.RadioButton normalRadiobtn;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.RadioButton whiteRadiobtn;
		private System.Windows.Forms.RadioButton redRadiobtn;
		private System.Windows.Forms.RadioButton yellowRadiobtn;
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
			this.colorGroupBox = new System.Windows.Forms.GroupBox();
			this.normalRadiobtn = new System.Windows.Forms.RadioButton();
			this.whiteRadiobtn = new System.Windows.Forms.RadioButton();
			this.redRadiobtn = new System.Windows.Forms.RadioButton();
			this.yellowRadiobtn = new System.Windows.Forms.RadioButton();
			this.exitButton = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.colorGroupBox.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// colorGroupBox
			// 
			this.colorGroupBox.Controls.Add(this.normalRadiobtn);
			this.colorGroupBox.Controls.Add(this.whiteRadiobtn);
			this.colorGroupBox.Controls.Add(this.redRadiobtn);
			this.colorGroupBox.Controls.Add(this.yellowRadiobtn);
			this.colorGroupBox.Location = new System.Drawing.Point(13, 13);
			this.colorGroupBox.Name = "colorGroupBox";
			this.colorGroupBox.Size = new System.Drawing.Size(216, 148);
			this.colorGroupBox.TabIndex = 3;
			this.colorGroupBox.TabStop = false;
			this.colorGroupBox.Text = "Select a Background Color";
			// 
			// normalRadiobtn
			// 
			this.normalRadiobtn.Location = new System.Drawing.Point(39, 109);
			this.normalRadiobtn.Name = "normalRadiobtn";
			this.normalRadiobtn.Size = new System.Drawing.Size(104, 24);
			this.normalRadiobtn.TabIndex = 3;
			this.normalRadiobtn.TabStop = true;
			this.normalRadiobtn.Text = "Back to Normal";
			this.normalRadiobtn.UseVisualStyleBackColor = true;
			this.normalRadiobtn.CheckedChanged += new System.EventHandler(this.NormalRadiobtnCheckedChanged);
			// 
			// whiteRadiobtn
			// 
			this.whiteRadiobtn.Location = new System.Drawing.Point(39, 79);
			this.whiteRadiobtn.Name = "whiteRadiobtn";
			this.whiteRadiobtn.Size = new System.Drawing.Size(104, 24);
			this.whiteRadiobtn.TabIndex = 4;
			this.whiteRadiobtn.TabStop = true;
			this.whiteRadiobtn.Text = "White";
			this.whiteRadiobtn.UseVisualStyleBackColor = true;
			this.whiteRadiobtn.CheckedChanged += new System.EventHandler(this.WhiteRadiobtnCheckedChanged);
			// 
			// redRadiobtn
			// 
			this.redRadiobtn.Location = new System.Drawing.Point(39, 49);
			this.redRadiobtn.Name = "redRadiobtn";
			this.redRadiobtn.Size = new System.Drawing.Size(104, 24);
			this.redRadiobtn.TabIndex = 5;
			this.redRadiobtn.TabStop = true;
			this.redRadiobtn.Text = "Red";
			this.redRadiobtn.UseVisualStyleBackColor = true;
			this.redRadiobtn.CheckedChanged += new System.EventHandler(this.RedRadiobtnCheckedChanged);
			// 
			// yellowRadiobtn
			// 
			this.yellowRadiobtn.Location = new System.Drawing.Point(39, 19);
			this.yellowRadiobtn.Name = "yellowRadiobtn";
			this.yellowRadiobtn.Size = new System.Drawing.Size(104, 24);
			this.yellowRadiobtn.TabIndex = 6;
			this.yellowRadiobtn.TabStop = true;
			this.yellowRadiobtn.Text = "Yellow";
			this.yellowRadiobtn.UseVisualStyleBackColor = true;
			this.yellowRadiobtn.CheckedChanged += new System.EventHandler(this.YellowRadiobtnCheckedChanged);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(76, 167);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(91, 32);
			this.exitButton.TabIndex = 7;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButtonClick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 209);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(241, 22);
			this.statusStrip1.TabIndex = 8;
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
			this.ClientSize = new System.Drawing.Size(241, 231);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.colorGroupBox);
			this.Controls.Add(this.exitButton);
			this.Name = "MainForm";
			this.Text = "Color Theme";
			this.colorGroupBox.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
