
namespace Restaurant_Bill
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxquantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxmenu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxprice = new System.Windows.Forms.TextBox();
            this.listBoxquantity = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxmenu = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxprice = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonTotal = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxtotalcost = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantity:";
            // 
            // textBoxquantity
            // 
            this.textBoxquantity.Location = new System.Drawing.Point(88, 17);
            this.textBoxquantity.Name = "textBoxquantity";
            this.textBoxquantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxquantity.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Menu Item:";
            // 
            // textBoxmenu
            // 
            this.textBoxmenu.Location = new System.Drawing.Point(88, 56);
            this.textBoxmenu.Name = "textBoxmenu";
            this.textBoxmenu.Size = new System.Drawing.Size(100, 20);
            this.textBoxmenu.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Price:";
            // 
            // textBoxprice
            // 
            this.textBoxprice.Location = new System.Drawing.Point(88, 93);
            this.textBoxprice.Name = "textBoxprice";
            this.textBoxprice.Size = new System.Drawing.Size(100, 20);
            this.textBoxprice.TabIndex = 1;
            // 
            // listBoxquantity
            // 
            this.listBoxquantity.FormattingEnabled = true;
            this.listBoxquantity.Location = new System.Drawing.Point(12, 162);
            this.listBoxquantity.Name = "listBoxquantity";
            this.listBoxquantity.Size = new System.Drawing.Size(71, 95);
            this.listBoxquantity.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Menu Item:";
            // 
            // listBoxmenu
            // 
            this.listBoxmenu.FormattingEnabled = true;
            this.listBoxmenu.Location = new System.Drawing.Point(96, 162);
            this.listBoxmenu.Name = "listBoxmenu";
            this.listBoxmenu.Size = new System.Drawing.Size(99, 95);
            this.listBoxmenu.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label6.Location = new System.Drawing.Point(227, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Price:";
            // 
            // listBoxprice
            // 
            this.listBoxprice.FormattingEnabled = true;
            this.listBoxprice.Location = new System.Drawing.Point(208, 162);
            this.listBoxprice.Name = "listBoxprice";
            this.listBoxprice.Size = new System.Drawing.Size(71, 95);
            this.listBoxprice.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(208, 15);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add Item";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonTotal
            // 
            this.buttonTotal.Location = new System.Drawing.Point(208, 56);
            this.buttonTotal.Name = "buttonTotal";
            this.buttonTotal.Size = new System.Drawing.Size(75, 23);
            this.buttonTotal.TabIndex = 3;
            this.buttonTotal.Text = "Total Bill";
            this.buttonTotal.UseVisualStyleBackColor = true;
            this.buttonTotal.Click += new System.EventHandler(this.buttonTotal_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total Cost:";
            // 
            // textBoxtotalcost
            // 
            this.textBoxtotalcost.Enabled = false;
            this.textBoxtotalcost.Location = new System.Drawing.Point(193, 274);
            this.textBoxtotalcost.Name = "textBoxtotalcost";
            this.textBoxtotalcost.Size = new System.Drawing.Size(86, 20);
            this.textBoxtotalcost.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 309);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(297, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(171, 17);
            this.toolStripStatusLabel1.Text = "Jan Cyrus M. Villar | BSCOE 1- 6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 331);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonTotal);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxmenu);
            this.Controls.Add(this.listBoxprice);
            this.Controls.Add(this.listBoxquantity);
            this.Controls.Add(this.textBoxtotalcost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxmenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxquantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Restaurant Bill";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxquantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxmenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxprice;
        private System.Windows.Forms.ListBox listBoxquantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxmenu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxprice;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxtotalcost;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

