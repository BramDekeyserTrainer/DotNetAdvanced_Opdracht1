namespace Oefening4
{
    partial class formSalesTaxCalculator
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
            this.lblItem = new System.Windows.Forms.Label();
            this.tbEersteItem = new System.Windows.Forms.TextBox();
            this.tbTweedeItem = new System.Windows.Forms.TextBox();
            this.tbDerdeItem = new System.Windows.Forms.TextBox();
            this.tbVierdeItem = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nmudEersteQuantity = new System.Windows.Forms.NumericUpDown();
            this.nmudTweedeQuantity = new System.Windows.Forms.NumericUpDown();
            this.nmudVierdeQuantity = new System.Windows.Forms.NumericUpDown();
            this.nmudDerdeQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblPriceEach = new System.Windows.Forms.Label();
            this.tbVierdePrice = new System.Windows.Forms.TextBox();
            this.tbDerdePrice = new System.Windows.Forms.TextBox();
            this.tbTweedePrice = new System.Windows.Forms.TextBox();
            this.tbEerstePrice = new System.Windows.Forms.TextBox();
            this.lblExt = new System.Windows.Forms.Label();
            this.tbVierdeExt = new System.Windows.Forms.TextBox();
            this.tbDerdeExt = new System.Windows.Forms.TextBox();
            this.tbTweedeExt = new System.Windows.Forms.TextBox();
            this.tbEersteExt = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblSubtotaal = new System.Windows.Forms.Label();
            this.tbSubtotaal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTaxRate = new System.Windows.Forms.TextBox();
            this.lblTaxRate = new System.Windows.Forms.Label();
            this.tbShipping = new System.Windows.Forms.TextBox();
            this.lblShipping = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSalesTax = new System.Windows.Forms.TextBox();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.tbGrandTotal = new System.Windows.Forms.TextBox();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmudEersteQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudTweedeQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudVierdeQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudDerdeQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(84, 48);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(32, 16);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "Item";
            this.lblItem.Click += new System.EventHandler(this.lblItem_Click);
            // 
            // tbEersteItem
            // 
            this.tbEersteItem.Location = new System.Drawing.Point(87, 67);
            this.tbEersteItem.Name = "tbEersteItem";
            this.tbEersteItem.Size = new System.Drawing.Size(102, 22);
            this.tbEersteItem.TabIndex = 1;
            this.tbEersteItem.TextChanged += new System.EventHandler(this.tbEersteItem_TextChanged);
            // 
            // tbTweedeItem
            // 
            this.tbTweedeItem.Location = new System.Drawing.Point(87, 95);
            this.tbTweedeItem.Name = "tbTweedeItem";
            this.tbTweedeItem.Size = new System.Drawing.Size(102, 22);
            this.tbTweedeItem.TabIndex = 2;
            this.tbTweedeItem.TextChanged += new System.EventHandler(this.tbTweedeItem_TextChanged);
            // 
            // tbDerdeItem
            // 
            this.tbDerdeItem.Location = new System.Drawing.Point(87, 123);
            this.tbDerdeItem.Name = "tbDerdeItem";
            this.tbDerdeItem.Size = new System.Drawing.Size(102, 22);
            this.tbDerdeItem.TabIndex = 3;
            this.tbDerdeItem.TextChanged += new System.EventHandler(this.tbDerdeItem_TextChanged);
            // 
            // tbVierdeItem
            // 
            this.tbVierdeItem.Location = new System.Drawing.Point(87, 151);
            this.tbVierdeItem.Name = "tbVierdeItem";
            this.tbVierdeItem.Size = new System.Drawing.Size(102, 22);
            this.tbVierdeItem.TabIndex = 4;
            this.tbVierdeItem.TextChanged += new System.EventHandler(this.tbVierdeItem_TextChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(225, 48);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(55, 16);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.Click += new System.EventHandler(this.lblQuantity_Click);
            // 
            // nmudEersteQuantity
            // 
            this.nmudEersteQuantity.Location = new System.Drawing.Point(228, 67);
            this.nmudEersteQuantity.Name = "nmudEersteQuantity";
            this.nmudEersteQuantity.Size = new System.Drawing.Size(52, 22);
            this.nmudEersteQuantity.TabIndex = 6;
            this.nmudEersteQuantity.ValueChanged += new System.EventHandler(this.nmudEersteQuantity_ValueChanged);
            // 
            // nmudTweedeQuantity
            // 
            this.nmudTweedeQuantity.Location = new System.Drawing.Point(228, 95);
            this.nmudTweedeQuantity.Name = "nmudTweedeQuantity";
            this.nmudTweedeQuantity.Size = new System.Drawing.Size(52, 22);
            this.nmudTweedeQuantity.TabIndex = 7;
            this.nmudTweedeQuantity.ValueChanged += new System.EventHandler(this.nmudTweedeQuantity_ValueChanged);
            // 
            // nmudVierdeQuantity
            // 
            this.nmudVierdeQuantity.Location = new System.Drawing.Point(228, 152);
            this.nmudVierdeQuantity.Name = "nmudVierdeQuantity";
            this.nmudVierdeQuantity.Size = new System.Drawing.Size(52, 22);
            this.nmudVierdeQuantity.TabIndex = 9;
            this.nmudVierdeQuantity.ValueChanged += new System.EventHandler(this.nmudVierdeQuantity_ValueChanged);
            // 
            // nmudDerdeQuantity
            // 
            this.nmudDerdeQuantity.Location = new System.Drawing.Point(228, 124);
            this.nmudDerdeQuantity.Name = "nmudDerdeQuantity";
            this.nmudDerdeQuantity.Size = new System.Drawing.Size(52, 22);
            this.nmudDerdeQuantity.TabIndex = 8;
            this.nmudDerdeQuantity.ValueChanged += new System.EventHandler(this.nmudDerdeQuantity_ValueChanged);
            // 
            // lblPriceEach
            // 
            this.lblPriceEach.AutoSize = true;
            this.lblPriceEach.Location = new System.Drawing.Point(344, 48);
            this.lblPriceEach.Name = "lblPriceEach";
            this.lblPriceEach.Size = new System.Drawing.Size(72, 16);
            this.lblPriceEach.TabIndex = 10;
            this.lblPriceEach.Text = "Price Each";
            this.lblPriceEach.Click += new System.EventHandler(this.lblPriceEach_Click);
            // 
            // tbVierdePrice
            // 
            this.tbVierdePrice.Location = new System.Drawing.Point(347, 151);
            this.tbVierdePrice.Name = "tbVierdePrice";
            this.tbVierdePrice.Size = new System.Drawing.Size(102, 22);
            this.tbVierdePrice.TabIndex = 14;
            this.tbVierdePrice.TextChanged += new System.EventHandler(this.tbVierdePrice_TextChanged);
            // 
            // tbDerdePrice
            // 
            this.tbDerdePrice.Location = new System.Drawing.Point(347, 123);
            this.tbDerdePrice.Name = "tbDerdePrice";
            this.tbDerdePrice.Size = new System.Drawing.Size(102, 22);
            this.tbDerdePrice.TabIndex = 13;
            this.tbDerdePrice.TextChanged += new System.EventHandler(this.tbDerdePrice_TextChanged);
            // 
            // tbTweedePrice
            // 
            this.tbTweedePrice.Location = new System.Drawing.Point(347, 95);
            this.tbTweedePrice.Name = "tbTweedePrice";
            this.tbTweedePrice.Size = new System.Drawing.Size(102, 22);
            this.tbTweedePrice.TabIndex = 12;
            this.tbTweedePrice.TextChanged += new System.EventHandler(this.tbTweedePrice_TextChanged);
            // 
            // tbEerstePrice
            // 
            this.tbEerstePrice.Location = new System.Drawing.Point(347, 67);
            this.tbEerstePrice.Name = "tbEerstePrice";
            this.tbEerstePrice.Size = new System.Drawing.Size(102, 22);
            this.tbEerstePrice.TabIndex = 11;
            this.tbEerstePrice.TextChanged += new System.EventHandler(this.tbEerstePrice_TextChanged);
            // 
            // lblExt
            // 
            this.lblExt.AutoSize = true;
            this.lblExt.Location = new System.Drawing.Point(523, 48);
            this.lblExt.Name = "lblExt";
            this.lblExt.Size = new System.Drawing.Size(62, 16);
            this.lblExt.TabIndex = 15;
            this.lblExt.Text = "Ext. Price";
            this.lblExt.Click += new System.EventHandler(this.lblExt_Click);
            // 
            // tbVierdeExt
            // 
            this.tbVierdeExt.Location = new System.Drawing.Point(526, 151);
            this.tbVierdeExt.Name = "tbVierdeExt";
            this.tbVierdeExt.ReadOnly = true;
            this.tbVierdeExt.Size = new System.Drawing.Size(102, 22);
            this.tbVierdeExt.TabIndex = 19;
            this.tbVierdeExt.TextChanged += new System.EventHandler(this.tbVierdeExt_TextChanged);
            // 
            // tbDerdeExt
            // 
            this.tbDerdeExt.Location = new System.Drawing.Point(526, 123);
            this.tbDerdeExt.Name = "tbDerdeExt";
            this.tbDerdeExt.ReadOnly = true;
            this.tbDerdeExt.Size = new System.Drawing.Size(102, 22);
            this.tbDerdeExt.TabIndex = 18;
            this.tbDerdeExt.TextChanged += new System.EventHandler(this.tbDerdeExt_TextChanged);
            // 
            // tbTweedeExt
            // 
            this.tbTweedeExt.Location = new System.Drawing.Point(526, 95);
            this.tbTweedeExt.Name = "tbTweedeExt";
            this.tbTweedeExt.ReadOnly = true;
            this.tbTweedeExt.Size = new System.Drawing.Size(102, 22);
            this.tbTweedeExt.TabIndex = 17;
            this.tbTweedeExt.TextChanged += new System.EventHandler(this.tbTweedeExt_TextChanged);
            // 
            // tbEersteExt
            // 
            this.tbEersteExt.Location = new System.Drawing.Point(526, 67);
            this.tbEersteExt.Name = "tbEersteExt";
            this.tbEersteExt.ReadOnly = true;
            this.tbEersteExt.Size = new System.Drawing.Size(102, 22);
            this.tbEersteExt.TabIndex = 16;
            this.tbEersteExt.TextChanged += new System.EventHandler(this.tbEersteExt_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(111, 268);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(110, 42);
            this.btnCalculate.TabIndex = 20;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblSubtotaal
            // 
            this.lblSubtotaal.AutoSize = true;
            this.lblSubtotaal.Location = new System.Drawing.Point(344, 238);
            this.lblSubtotaal.Name = "lblSubtotaal";
            this.lblSubtotaal.Size = new System.Drawing.Size(64, 16);
            this.lblSubtotaal.TabIndex = 21;
            this.lblSubtotaal.Text = "Subtotaal";
            this.lblSubtotaal.Click += new System.EventHandler(this.lblSubtotaal_Click);
            // 
            // tbSubtotaal
            // 
            this.tbSubtotaal.Location = new System.Drawing.Point(483, 232);
            this.tbSubtotaal.Name = "tbSubtotaal";
            this.tbSubtotaal.ReadOnly = true;
            this.tbSubtotaal.Size = new System.Drawing.Size(102, 22);
            this.tbSubtotaal.TabIndex = 22;
            this.tbSubtotaal.TextChanged += new System.EventHandler(this.tbSubtotaal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 23;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbTaxRate
            // 
            this.tbTaxRate.Location = new System.Drawing.Point(483, 260);
            this.tbTaxRate.Name = "tbTaxRate";
            this.tbTaxRate.Size = new System.Drawing.Size(102, 22);
            this.tbTaxRate.TabIndex = 25;
            this.tbTaxRate.TextChanged += new System.EventHandler(this.tbTaxRate_TextChanged);
            // 
            // lblTaxRate
            // 
            this.lblTaxRate.AutoSize = true;
            this.lblTaxRate.Location = new System.Drawing.Point(344, 266);
            this.lblTaxRate.Name = "lblTaxRate";
            this.lblTaxRate.Size = new System.Drawing.Size(62, 16);
            this.lblTaxRate.TabIndex = 24;
            this.lblTaxRate.Text = "Tax Rate";
            this.lblTaxRate.Click += new System.EventHandler(this.lblTaxRate_Click);
            // 
            // tbShipping
            // 
            this.tbShipping.Location = new System.Drawing.Point(483, 316);
            this.tbShipping.Name = "tbShipping";
            this.tbShipping.Size = new System.Drawing.Size(102, 22);
            this.tbShipping.TabIndex = 30;
            this.tbShipping.TextChanged += new System.EventHandler(this.tbShipping_TextChanged);
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Location = new System.Drawing.Point(344, 322);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(60, 16);
            this.lblShipping.TabIndex = 29;
            this.lblShipping.Text = "Shipping";
            this.lblShipping.Click += new System.EventHandler(this.lblShipping_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 28;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbSalesTax
            // 
            this.tbSalesTax.Location = new System.Drawing.Point(483, 288);
            this.tbSalesTax.Name = "tbSalesTax";
            this.tbSalesTax.ReadOnly = true;
            this.tbSalesTax.Size = new System.Drawing.Size(102, 22);
            this.tbSalesTax.TabIndex = 27;
            this.tbSalesTax.TextChanged += new System.EventHandler(this.tbSalesTax_TextChanged);
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.AutoSize = true;
            this.lblSalesTax.Location = new System.Drawing.Point(344, 294);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(68, 16);
            this.lblSalesTax.TabIndex = 26;
            this.lblSalesTax.Text = "Sales Tax";
            this.lblSalesTax.Click += new System.EventHandler(this.lblSalesTax_Click);
            // 
            // tbGrandTotal
            // 
            this.tbGrandTotal.Location = new System.Drawing.Point(483, 344);
            this.tbGrandTotal.Name = "tbGrandTotal";
            this.tbGrandTotal.ReadOnly = true;
            this.tbGrandTotal.Size = new System.Drawing.Size(102, 22);
            this.tbGrandTotal.TabIndex = 33;
            this.tbGrandTotal.TextChanged += new System.EventHandler(this.tbGrandTotal_TextChanged);
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(344, 350);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(78, 16);
            this.lblGrandTotal.TabIndex = 32;
            this.lblGrandTotal.Text = "Grand Total";
            this.lblGrandTotal.Click += new System.EventHandler(this.lblGrandTotal_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 31;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // formSalesTaxCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbGrandTotal);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbShipping);
            this.Controls.Add(this.lblShipping);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSalesTax);
            this.Controls.Add(this.lblSalesTax);
            this.Controls.Add(this.tbTaxRate);
            this.Controls.Add(this.lblTaxRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSubtotaal);
            this.Controls.Add(this.lblSubtotaal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbVierdeExt);
            this.Controls.Add(this.tbDerdeExt);
            this.Controls.Add(this.tbTweedeExt);
            this.Controls.Add(this.tbEersteExt);
            this.Controls.Add(this.lblExt);
            this.Controls.Add(this.tbVierdePrice);
            this.Controls.Add(this.tbDerdePrice);
            this.Controls.Add(this.tbTweedePrice);
            this.Controls.Add(this.tbEerstePrice);
            this.Controls.Add(this.lblPriceEach);
            this.Controls.Add(this.nmudVierdeQuantity);
            this.Controls.Add(this.nmudDerdeQuantity);
            this.Controls.Add(this.nmudTweedeQuantity);
            this.Controls.Add(this.nmudEersteQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.tbVierdeItem);
            this.Controls.Add(this.tbDerdeItem);
            this.Controls.Add(this.tbTweedeItem);
            this.Controls.Add(this.tbEersteItem);
            this.Controls.Add(this.lblItem);
            this.Name = "formSalesTaxCalculator";
            this.Text = "SalesTaxCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.nmudEersteQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudTweedeQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudVierdeQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudDerdeQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.TextBox tbEersteItem;
        private System.Windows.Forms.TextBox tbTweedeItem;
        private System.Windows.Forms.TextBox tbDerdeItem;
        private System.Windows.Forms.TextBox tbVierdeItem;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nmudEersteQuantity;
        private System.Windows.Forms.NumericUpDown nmudTweedeQuantity;
        private System.Windows.Forms.NumericUpDown nmudVierdeQuantity;
        private System.Windows.Forms.NumericUpDown nmudDerdeQuantity;
        private System.Windows.Forms.Label lblPriceEach;
        private System.Windows.Forms.TextBox tbVierdePrice;
        private System.Windows.Forms.TextBox tbDerdePrice;
        private System.Windows.Forms.TextBox tbTweedePrice;
        private System.Windows.Forms.TextBox tbEerstePrice;
        private System.Windows.Forms.Label lblExt;
        private System.Windows.Forms.TextBox tbVierdeExt;
        private System.Windows.Forms.TextBox tbDerdeExt;
        private System.Windows.Forms.TextBox tbTweedeExt;
        private System.Windows.Forms.TextBox tbEersteExt;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblSubtotaal;
        private System.Windows.Forms.TextBox tbSubtotaal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTaxRate;
        private System.Windows.Forms.Label lblTaxRate;
        private System.Windows.Forms.TextBox tbShipping;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSalesTax;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.TextBox tbGrandTotal;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label label7;
    }
}

