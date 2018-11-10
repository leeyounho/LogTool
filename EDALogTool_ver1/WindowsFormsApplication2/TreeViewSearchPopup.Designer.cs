namespace WindowsFormsApplication2
{
    partial class TreeViewSearchPopup
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
            this.textBoxSearchXML = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxSearchXML
            // 
            this.textBoxSearchXML.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearchXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearchXML.Location = new System.Drawing.Point(0, 0);
            this.textBoxSearchXML.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSearchXML.Name = "textBoxSearchXML";
            this.textBoxSearchXML.Size = new System.Drawing.Size(184, 19);
            this.textBoxSearchXML.TabIndex = 0;
            this.textBoxSearchXML.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchXML_KeyDown);
            // 
            // TreeViewSearchPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 26);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxSearchXML);
            this.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TreeViewSearchPopup";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearchXML;
    }
}