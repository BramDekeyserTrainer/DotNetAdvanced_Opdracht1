namespace Oefening5
{
    partial class formCelciusToFahrenheit
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
            this.lblCelsius = new System.Windows.Forms.Label();
            this.tbCelsius = new System.Windows.Forms.TextBox();
            this.btnCelsiusToFahrenheit = new System.Windows.Forms.Button();
            this.btnFahrenheitToCelsius = new System.Windows.Forms.Button();
            this.tbFahrenheit = new System.Windows.Forms.TextBox();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Location = new System.Drawing.Point(88, 66);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(51, 16);
            this.lblCelsius.TabIndex = 0;
            this.lblCelsius.Text = "Celsius";
            // 
            // tbCelsius
            // 
            this.tbCelsius.Location = new System.Drawing.Point(67, 85);
            this.tbCelsius.Name = "tbCelsius";
            this.tbCelsius.Size = new System.Drawing.Size(100, 22);
            this.tbCelsius.TabIndex = 1;
            this.tbCelsius.TextChanged += new System.EventHandler(this.tbCelsius_TextChanged);
            // 
            // btnCelsiusToFahrenheit
            // 
            this.btnCelsiusToFahrenheit.Location = new System.Drawing.Point(77, 122);
            this.btnCelsiusToFahrenheit.Name = "btnCelsiusToFahrenheit";
            this.btnCelsiusToFahrenheit.Size = new System.Drawing.Size(75, 23);
            this.btnCelsiusToFahrenheit.TabIndex = 2;
            this.btnCelsiusToFahrenheit.Text = "C to F";
            this.btnCelsiusToFahrenheit.UseVisualStyleBackColor = true;
            this.btnCelsiusToFahrenheit.Click += new System.EventHandler(this.btnCelsiusToFahrenheit_Click);
            // 
            // btnFahrenheitToCelsius
            // 
            this.btnFahrenheitToCelsius.Location = new System.Drawing.Point(253, 122);
            this.btnFahrenheitToCelsius.Name = "btnFahrenheitToCelsius";
            this.btnFahrenheitToCelsius.Size = new System.Drawing.Size(75, 23);
            this.btnFahrenheitToCelsius.TabIndex = 5;
            this.btnFahrenheitToCelsius.Text = "F to C";
            this.btnFahrenheitToCelsius.UseVisualStyleBackColor = true;
            this.btnFahrenheitToCelsius.Click += new System.EventHandler(this.btnFahrenheitToCelsius_Click);
            // 
            // tbFahrenheit
            // 
            this.tbFahrenheit.Location = new System.Drawing.Point(243, 85);
            this.tbFahrenheit.Name = "tbFahrenheit";
            this.tbFahrenheit.Size = new System.Drawing.Size(100, 22);
            this.tbFahrenheit.TabIndex = 4;
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(258, 66);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(70, 16);
            this.lblFahrenheit.TabIndex = 3;
            this.lblFahrenheit.Text = "Fahrenheit";
            // 
            // formCelciusToFahrenheit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 210);
            this.Controls.Add(this.btnFahrenheitToCelsius);
            this.Controls.Add(this.tbFahrenheit);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.btnCelsiusToFahrenheit);
            this.Controls.Add(this.tbCelsius);
            this.Controls.Add(this.lblCelsius);
            this.Name = "formCelciusToFahrenheit";
            this.Text = "CelciusToFahrenheit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.TextBox tbCelsius;
        private System.Windows.Forms.Button btnCelsiusToFahrenheit;
        private System.Windows.Forms.Button btnFahrenheitToCelsius;
        private System.Windows.Forms.TextBox tbFahrenheit;
        private System.Windows.Forms.Label lblFahrenheit;
    }
}

