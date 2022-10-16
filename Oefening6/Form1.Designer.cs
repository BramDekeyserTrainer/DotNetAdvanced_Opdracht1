namespace Oefening6
{
    partial class formOrderForm
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
            this.tbGrandTotal = new System.Windows.Forms.TextBox();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbShipping = new System.Windows.Forms.TextBox();
            this.lblShipping = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSalesTax = new System.Windows.Forms.TextBox();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.tbSubtotaal = new System.Windows.Forms.TextBox();
            this.lblSubtotaal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tbVierdeExt = new System.Windows.Forms.TextBox();
            this.tbDerdeExt = new System.Windows.Forms.TextBox();
            this.tbTweedeExt = new System.Windows.Forms.TextBox();
            this.tbEersteExt = new System.Windows.Forms.TextBox();
            this.lblExt = new System.Windows.Forms.Label();
            this.tbVierdePrice = new System.Windows.Forms.TextBox();
            this.tbDerdePrice = new System.Windows.Forms.TextBox();
            this.tbTweedePrice = new System.Windows.Forms.TextBox();
            this.tbEerstePrice = new System.Windows.Forms.TextBox();
            this.lblPriceEach = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.tbVierdeItem = new System.Windows.Forms.TextBox();
            this.tbDerdeItem = new System.Windows.Forms.TextBox();
            this.tbTweedeItem = new System.Windows.Forms.TextBox();
            this.tbEersteItem = new System.Windows.Forms.TextBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.tbVierdeQuantity = new System.Windows.Forms.TextBox();
            this.tbDerdeQuantity = new System.Windows.Forms.TextBox();
            this.tbTweedeQuantity = new System.Windows.Forms.TextBox();
            this.tbEersteQuantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbGrandTotal
            // 
            this.tbGrandTotal.Location = new System.Drawing.Point(495, 341);
            this.tbGrandTotal.Name = "tbGrandTotal";
            this.tbGrandTotal.ReadOnly = true;
            this.tbGrandTotal.Size = new System.Drawing.Size(102, 22);
            this.tbGrandTotal.TabIndex = 67;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(356, 347);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(78, 16);
            this.lblGrandTotal.TabIndex = 66;
            this.lblGrandTotal.Text = "Grand Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 65;
            // 
            // tbShipping
            // 
            this.tbShipping.Location = new System.Drawing.Point(495, 313);
            this.tbShipping.Name = "tbShipping";
            this.tbShipping.ReadOnly = true;
            this.tbShipping.Size = new System.Drawing.Size(102, 22);
            this.tbShipping.TabIndex = 64;
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Location = new System.Drawing.Point(356, 319);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(60, 16);
            this.lblShipping.TabIndex = 63;
            this.lblShipping.Text = "Shipping";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 62;
            // 
            // tbSalesTax
            // 
            this.tbSalesTax.Location = new System.Drawing.Point(495, 285);
            this.tbSalesTax.Name = "tbSalesTax";
            this.tbSalesTax.ReadOnly = true;
            this.tbSalesTax.Size = new System.Drawing.Size(102, 22);
            this.tbSalesTax.TabIndex = 61;
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.AutoSize = true;
            this.lblSalesTax.Location = new System.Drawing.Point(356, 291);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(68, 16);
            this.lblSalesTax.TabIndex = 60;
            this.lblSalesTax.Text = "Sales Tax";
            // 
            // tbSubtotaal
            // 
            this.tbSubtotaal.Location = new System.Drawing.Point(495, 257);
            this.tbSubtotaal.Name = "tbSubtotaal";
            this.tbSubtotaal.ReadOnly = true;
            this.tbSubtotaal.Size = new System.Drawing.Size(102, 22);
            this.tbSubtotaal.TabIndex = 56;
            // 
            // lblSubtotaal
            // 
            this.lblSubtotaal.AutoSize = true;
            this.lblSubtotaal.Location = new System.Drawing.Point(356, 263);
            this.lblSubtotaal.Name = "lblSubtotaal";
            this.lblSubtotaal.Size = new System.Drawing.Size(64, 16);
            this.lblSubtotaal.TabIndex = 55;
            this.lblSubtotaal.Text = "Subtotaal";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(123, 285);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(110, 42);
            this.btnCalculate.TabIndex = 54;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tbVierdeExt
            // 
            this.tbVierdeExt.Location = new System.Drawing.Point(559, 168);
            this.tbVierdeExt.Name = "tbVierdeExt";
            this.tbVierdeExt.ReadOnly = true;
            this.tbVierdeExt.Size = new System.Drawing.Size(102, 22);
            this.tbVierdeExt.TabIndex = 53;
            // 
            // tbDerdeExt
            // 
            this.tbDerdeExt.Location = new System.Drawing.Point(559, 140);
            this.tbDerdeExt.Name = "tbDerdeExt";
            this.tbDerdeExt.ReadOnly = true;
            this.tbDerdeExt.Size = new System.Drawing.Size(102, 22);
            this.tbDerdeExt.TabIndex = 52;
            // 
            // tbTweedeExt
            // 
            this.tbTweedeExt.Location = new System.Drawing.Point(559, 112);
            this.tbTweedeExt.Name = "tbTweedeExt";
            this.tbTweedeExt.ReadOnly = true;
            this.tbTweedeExt.Size = new System.Drawing.Size(102, 22);
            this.tbTweedeExt.TabIndex = 51;
            // 
            // tbEersteExt
            // 
            this.tbEersteExt.Location = new System.Drawing.Point(559, 84);
            this.tbEersteExt.Name = "tbEersteExt";
            this.tbEersteExt.ReadOnly = true;
            this.tbEersteExt.Size = new System.Drawing.Size(102, 22);
            this.tbEersteExt.TabIndex = 50;
            // 
            // lblExt
            // 
            this.lblExt.AutoSize = true;
            this.lblExt.Location = new System.Drawing.Point(556, 65);
            this.lblExt.Name = "lblExt";
            this.lblExt.Size = new System.Drawing.Size(62, 16);
            this.lblExt.TabIndex = 49;
            this.lblExt.Text = "Ext. Price";
            // 
            // tbVierdePrice
            // 
            this.tbVierdePrice.Location = new System.Drawing.Point(380, 168);
            this.tbVierdePrice.Name = "tbVierdePrice";
            this.tbVierdePrice.Size = new System.Drawing.Size(102, 22);
            this.tbVierdePrice.TabIndex = 48;
            // 
            // tbDerdePrice
            // 
            this.tbDerdePrice.Location = new System.Drawing.Point(380, 140);
            this.tbDerdePrice.Name = "tbDerdePrice";
            this.tbDerdePrice.Size = new System.Drawing.Size(102, 22);
            this.tbDerdePrice.TabIndex = 47;
            // 
            // tbTweedePrice
            // 
            this.tbTweedePrice.Location = new System.Drawing.Point(380, 112);
            this.tbTweedePrice.Name = "tbTweedePrice";
            this.tbTweedePrice.Size = new System.Drawing.Size(102, 22);
            this.tbTweedePrice.TabIndex = 46;
            // 
            // tbEerstePrice
            // 
            this.tbEerstePrice.Location = new System.Drawing.Point(380, 84);
            this.tbEerstePrice.Name = "tbEerstePrice";
            this.tbEerstePrice.Size = new System.Drawing.Size(102, 22);
            this.tbEerstePrice.TabIndex = 45;
            // 
            // lblPriceEach
            // 
            this.lblPriceEach.AutoSize = true;
            this.lblPriceEach.Location = new System.Drawing.Point(377, 65);
            this.lblPriceEach.Name = "lblPriceEach";
            this.lblPriceEach.Size = new System.Drawing.Size(72, 16);
            this.lblPriceEach.TabIndex = 44;
            this.lblPriceEach.Text = "Price Each";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(237, 65);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(55, 16);
            this.lblQuantity.TabIndex = 39;
            this.lblQuantity.Text = "Quantity";
            // 
            // tbVierdeItem
            // 
            this.tbVierdeItem.Location = new System.Drawing.Point(99, 168);
            this.tbVierdeItem.Name = "tbVierdeItem";
            this.tbVierdeItem.Size = new System.Drawing.Size(102, 22);
            this.tbVierdeItem.TabIndex = 38;
            // 
            // tbDerdeItem
            // 
            this.tbDerdeItem.Location = new System.Drawing.Point(99, 140);
            this.tbDerdeItem.Name = "tbDerdeItem";
            this.tbDerdeItem.Size = new System.Drawing.Size(102, 22);
            this.tbDerdeItem.TabIndex = 37;
            // 
            // tbTweedeItem
            // 
            this.tbTweedeItem.Location = new System.Drawing.Point(99, 112);
            this.tbTweedeItem.Name = "tbTweedeItem";
            this.tbTweedeItem.Size = new System.Drawing.Size(102, 22);
            this.tbTweedeItem.TabIndex = 36;
            // 
            // tbEersteItem
            // 
            this.tbEersteItem.Location = new System.Drawing.Point(99, 84);
            this.tbEersteItem.Name = "tbEersteItem";
            this.tbEersteItem.Size = new System.Drawing.Size(102, 22);
            this.tbEersteItem.TabIndex = 35;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(96, 65);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(32, 16);
            this.lblItem.TabIndex = 34;
            this.lblItem.Text = "Item";
            // 
            // tbVierdeQuantity
            // 
            this.tbVierdeQuantity.Location = new System.Drawing.Point(240, 168);
            this.tbVierdeQuantity.Name = "tbVierdeQuantity";
            this.tbVierdeQuantity.Size = new System.Drawing.Size(102, 22);
            this.tbVierdeQuantity.TabIndex = 71;
            // 
            // tbDerdeQuantity
            // 
            this.tbDerdeQuantity.Location = new System.Drawing.Point(240, 140);
            this.tbDerdeQuantity.Name = "tbDerdeQuantity";
            this.tbDerdeQuantity.Size = new System.Drawing.Size(102, 22);
            this.tbDerdeQuantity.TabIndex = 70;
            // 
            // tbTweedeQuantity
            // 
            this.tbTweedeQuantity.Location = new System.Drawing.Point(240, 112);
            this.tbTweedeQuantity.Name = "tbTweedeQuantity";
            this.tbTweedeQuantity.Size = new System.Drawing.Size(102, 22);
            this.tbTweedeQuantity.TabIndex = 69;
            // 
            // tbEersteQuantity
            // 
            this.tbEersteQuantity.Location = new System.Drawing.Point(240, 84);
            this.tbEersteQuantity.Name = "tbEersteQuantity";
            this.tbEersteQuantity.Size = new System.Drawing.Size(102, 22);
            this.tbEersteQuantity.TabIndex = 68;
            // 
            // formOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbVierdeQuantity);
            this.Controls.Add(this.tbDerdeQuantity);
            this.Controls.Add(this.tbTweedeQuantity);
            this.Controls.Add(this.tbEersteQuantity);
            this.Controls.Add(this.tbGrandTotal);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbShipping);
            this.Controls.Add(this.lblShipping);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSalesTax);
            this.Controls.Add(this.lblSalesTax);
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
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.tbVierdeItem);
            this.Controls.Add(this.tbDerdeItem);
            this.Controls.Add(this.tbTweedeItem);
            this.Controls.Add(this.tbEersteItem);
            this.Controls.Add(this.lblItem);
            this.Name = "formOrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGrandTotal;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbShipping;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSalesTax;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.TextBox tbSubtotaal;
        private System.Windows.Forms.Label lblSubtotaal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tbVierdeExt;
        private System.Windows.Forms.TextBox tbDerdeExt;
        private System.Windows.Forms.TextBox tbTweedeExt;
        private System.Windows.Forms.TextBox tbEersteExt;
        private System.Windows.Forms.Label lblExt;
        private System.Windows.Forms.TextBox tbVierdePrice;
        private System.Windows.Forms.TextBox tbDerdePrice;
        private System.Windows.Forms.TextBox tbTweedePrice;
        private System.Windows.Forms.TextBox tbEerstePrice;
        private System.Windows.Forms.Label lblPriceEach;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox tbVierdeItem;
        private System.Windows.Forms.TextBox tbDerdeItem;
        private System.Windows.Forms.TextBox tbTweedeItem;
        private System.Windows.Forms.TextBox tbEersteItem;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.TextBox tbVierdeQuantity;
        private System.Windows.Forms.TextBox tbDerdeQuantity;
        private System.Windows.Forms.TextBox tbTweedeQuantity;
        private System.Windows.Forms.TextBox tbEersteQuantity;
    }
}

