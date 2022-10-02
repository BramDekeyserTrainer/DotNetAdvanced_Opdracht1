namespace Oefening1
{
    partial class formBegroeting
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
            this.lblBegroeting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBegroeting
            // 
            this.lblBegroeting.AutoSize = true;
            this.lblBegroeting.Location = new System.Drawing.Point(116, 88);
            this.lblBegroeting.Name = "lblBegroeting";
            this.lblBegroeting.Size = new System.Drawing.Size(73, 16);
            this.lblBegroeting.TabIndex = 0;
            this.lblBegroeting.Text = "Begroeting";
            // 
            // formBegroeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 208);
            this.Controls.Add(this.lblBegroeting);
            this.Name = "formBegroeting";
            this.Text = "Begroeting";
            this.Load += new System.EventHandler(this.formBegroeting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBegroeting;
    }
}

