namespace WindowsFormsApplication2
{
    partial class CurrentLinkPopup
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBoxConsumerLogLinks = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxSoapMessageLinks = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBoxSkewLogLinks = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBoxConsumerLogLinks);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 455);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consumer Log Links";
            // 
            // richTextBoxConsumerLogLinks
            // 
            this.richTextBoxConsumerLogLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxConsumerLogLinks.Location = new System.Drawing.Point(3, 17);
            this.richTextBoxConsumerLogLinks.Name = "richTextBoxConsumerLogLinks";
            this.richTextBoxConsumerLogLinks.ReadOnly = true;
            this.richTextBoxConsumerLogLinks.Size = new System.Drawing.Size(315, 435);
            this.richTextBoxConsumerLogLinks.TabIndex = 0;
            this.richTextBoxConsumerLogLinks.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBoxSoapMessageLinks);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(330, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 455);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Soap Message Links";
            // 
            // richTextBoxSoapMessageLinks
            // 
            this.richTextBoxSoapMessageLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxSoapMessageLinks.Location = new System.Drawing.Point(3, 17);
            this.richTextBoxSoapMessageLinks.Name = "richTextBoxSoapMessageLinks";
            this.richTextBoxSoapMessageLinks.ReadOnly = true;
            this.richTextBoxSoapMessageLinks.Size = new System.Drawing.Size(315, 435);
            this.richTextBoxSoapMessageLinks.TabIndex = 0;
            this.richTextBoxSoapMessageLinks.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBoxSkewLogLinks);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(657, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 455);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Skew Log Links";
            // 
            // richTextBoxSkewLogLinks
            // 
            this.richTextBoxSkewLogLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxSkewLogLinks.Location = new System.Drawing.Point(3, 17);
            this.richTextBoxSkewLogLinks.Name = "richTextBoxSkewLogLinks";
            this.richTextBoxSkewLogLinks.ReadOnly = true;
            this.richTextBoxSkewLogLinks.Size = new System.Drawing.Size(318, 435);
            this.richTextBoxSkewLogLinks.TabIndex = 0;
            this.richTextBoxSkewLogLinks.Text = "";
            // 
            // CurrentLinkPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "CurrentLinkPopup";
            this.Text = "Links";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBoxConsumerLogLinks;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBoxSoapMessageLinks;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBoxSkewLogLinks;
    }
}