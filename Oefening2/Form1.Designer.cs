namespace Oefening2
{
    partial class formIsItBigger
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVermenigvuldiging1 = new System.Windows.Forms.Label();
            this.lblVermenigvuldiging2 = new System.Windows.Forms.Label();
            this.lblTrueOfFalse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVermenigvuldiging1
            // 
            this.lblVermenigvuldiging1.AutoSize = true;
            this.lblVermenigvuldiging1.Location = new System.Drawing.Point(47, 43);
            this.lblVermenigvuldiging1.Name = "lblVermenigvuldiging1";
            this.lblVermenigvuldiging1.Size = new System.Drawing.Size(142, 20);
            this.lblVermenigvuldiging1.TabIndex = 0;
            this.lblVermenigvuldiging1.Text = "Vermenigvuldiging1";
            this.lblVermenigvuldiging1.Click += new System.EventHandler(this.lblVermenigvuldiging1_Click);
            // 
            // lblVermenigvuldiging2
            // 
            this.lblVermenigvuldiging2.AutoSize = true;
            this.lblVermenigvuldiging2.Location = new System.Drawing.Point(47, 93);
            this.lblVermenigvuldiging2.Name = "lblVermenigvuldiging2";
            this.lblVermenigvuldiging2.Size = new System.Drawing.Size(142, 20);
            this.lblVermenigvuldiging2.TabIndex = 1;
            this.lblVermenigvuldiging2.Text = "Vermenigvuldiging2";
            // 
            // lblTrueOfFalse
            // 
            this.lblTrueOfFalse.AutoSize = true;
            this.lblTrueOfFalse.Location = new System.Drawing.Point(47, 137);
            this.lblTrueOfFalse.Name = "lblTrueOfFalse";
            this.lblTrueOfFalse.Size = new System.Drawing.Size(91, 20);
            this.lblTrueOfFalse.TabIndex = 2;
            this.lblTrueOfFalse.Text = "True of False";
            // 
            // formIsItBigger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 222);
            this.Controls.Add(this.lblTrueOfFalse);
            this.Controls.Add(this.lblVermenigvuldiging2);
            this.Controls.Add(this.lblVermenigvuldiging1);
            this.Name = "formIsItBigger";
            this.Text = "IsItBigger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblVermenigvuldiging1;
        private Label lblVermenigvuldiging2;
        private Label lblTrueOfFalse;
    }
}