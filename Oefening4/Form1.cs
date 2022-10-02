using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening4
{
    public partial class formSalesTaxCalculator : Form
    {
        public formSalesTaxCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /*Hieronder staan de berekeningen in de vorm van variabelen.
             * De eerste vier berekeningen zijn optellingen. 
             * De waarde van de Numeric-Up-Down's worden omgezet naar doubles,
             * en vervolgens vermenigvuldigt met de prijs per stuk.
             * We haleen de waarden uit de tekstvelden en Numer-Up-Down's
             * en parsen om ze als een numerieke waarde te lezen.*/
            double optelling1 = (double)nmudEersteQuantity.Value * Double.Parse(tbEerstePrice.Text);
            double optelling2 = (double)nmudTweedeQuantity.Value * Double.Parse(tbTweedePrice.Text);
            double optelling3 = (double)nmudDerdeQuantity.Value * Double.Parse(tbDerdePrice.Text);
            double optelling4 = (double)nmudVierdeQuantity.Value * Double.Parse(tbVierdePrice.Text);

            //Hier bereken ik het subtotaal door alle optellingen bij elkaar te tellen.
            double subtotaal = optelling1 + optelling2 + optelling3 + optelling4;

            /*Voor ik de Sales Tax en Grand Total bereken, lees ik de tekstboxen in.
             * Vervolgens parse ik deze naar een numerieke waarde. (Double)*/
            double taxRate = Double.Parse(tbTaxRate.Text);
            double shipping = Double.Parse(tbShipping.Text);

            //Hier bereken ik de Sales Tax en Grand Total aan de hand 
            double salesTax = taxRate * subtotaal;
            double grandTotal = subtotaal + salesTax + shipping;


            //Hier laat ik de resultaten in string-vorm in de correcte veldjes verschijnen.
            tbEersteExt.Text = optelling1.ToString();
            tbTweedeExt.Text = optelling2.ToString();
            tbDerdeExt.Text = optelling3.ToString();
            tbVierdeExt.Text = optelling4.ToString();
            tbSubtotaal.Text = subtotaal.ToString();
            tbSalesTax.Text = salesTax.ToString();
            tbGrandTotal.Text = grandTotal.ToString();
            
        }

        private void lblGrandTotal_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tbShipping_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblShipping_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbSalesTax_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSalesTax_Click(object sender, EventArgs e)
        {

        }

        private void tbTaxRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTaxRate_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbSubtotaal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSubtotaal_Click(object sender, EventArgs e)
        {

        }

        private void tbGrandTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbVierdeExt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDerdeExt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTweedeExt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEersteExt_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblExt_Click(object sender, EventArgs e)
        {

        }

        private void tbVierdePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDerdePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTweedePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEerstePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPriceEach_Click(object sender, EventArgs e)
        {

        }

        private void nmudVierdeQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nmudDerdeQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nmudTweedeQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nmudEersteQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }

        private void tbVierdeItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDerdeItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTweedeItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEersteItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblItem_Click(object sender, EventArgs e)
        {

        }
    }
}
