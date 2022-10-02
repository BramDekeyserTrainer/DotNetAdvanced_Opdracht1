using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening6
{
    public partial class formOrderForm : Form
    {
        public formOrderForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /*Hieronder staan de berekeningen in de vorm van variabelen.
 * De eerste vier berekeningen zijn optellingen. 
 * De quantities worden vermenigvuldigt met hun de prijs van het item. (Dit wordt geparsed naar een double.*/
            double optelling1 = Double.Parse(tbEersteQuantity.Text) * Double.Parse(tbEerstePrice.Text);
            double optelling2 = Double.Parse(tbTweedeQuantity.Text) * Double.Parse(tbTweedePrice.Text);
            double optelling3 = Double.Parse(tbDerdeQuantity.Text) * Double.Parse(tbDerdePrice.Text);
            double optelling4 = Double.Parse(tbVierdeQuantity.Text) * Double.Parse(tbVierdePrice.Text);

            //Hier bereken ik het subtotaal door alle optellingen bij elkaar te tellen.
            double subtotaal = optelling1 + optelling2 + optelling3 + optelling4;

            /*Voor ik de Sales Tax en Grand Total bereken, lees ik de tekstbox van de shipping in.
             * Vervolgens parse ik deze naar een numerieke waarde. (Double)
             * Ik maak van de Tax Rate een constante.*/
            const double taxRate = 0.07;
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
    }
}
