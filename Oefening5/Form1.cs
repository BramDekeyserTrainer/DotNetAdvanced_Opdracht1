using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening5
{
    public partial class formCelciusToFahrenheit : Form
    {
        public formCelciusToFahrenheit()
        {
            InitializeComponent();
        }

        private void tbCelsius_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCelsiusToFahrenheit_Click(object sender, EventArgs e)
        {
            /*Via een if-statement ga ik na of de tekstbox van graden celsius tekst bevat,
             * EN ofdat de tekstbox van fahrenheit GEEN tekst bevat.
             * Wanneer aan deze BEIDE voorwaarden wordt voldaan, worden de berekeningen gevoerd.
             * Zoniet, zal er niets gebeuren.
             * Hiervoor gebruik ik .Length en ga na of deze al dan niet 0 is.*/
            if (tbFahrenheit.Text.Length == 0 && tbCelsius.Text.Length != 0) 
            {
                /*Ik maak een variabele die de fahrenheit berekent.
                 * Ik lees de inhoud van de tekstbox tbCelsius hiervoor in.*/
                double toFahrenheit = Double.Parse(tbCelsius.Text) * 9 / 5 + 32;

                /*Ik converteer het resultaat van toFahrenheit naar een string.
                 * Deze zet ik vervolgens in het juist veldje.*/
                tbFahrenheit.Text = toFahrenheit.ToString();
            }
            else
            {
               
            }


        }

        private void btnFahrenheitToCelsius_Click(object sender, EventArgs e)
        {
            /*Via een if-statement ga ik na of de tekstbox van fahrenheit tekst bevat,
             * EN ofdat de tekstbox van graden celsius GEEN tekst bevat.
             * Wanneer aan deze BEIDE voorwaarden wordt voldaan, worden de berekeningen gevoerd.
             * Zoniet, zal er niets gebeuren.
             * Hiervoor gebruik ik .Length en ga na of deze al dan niet 0 is.*/
            if (tbCelsius.Text.Length == 0 && tbFahrenheit.Text.Length != 0)
            {
                /*Ik maak een variabele die de graden celsius berekent.
                 * Ik lees de inhoud van de tekstbox tbFahrenheit hiervoor in.*/
                double toCelsius = (Double.Parse(tbFahrenheit.Text) - 32) * 5 / 9;

                /*Ik converteer het resultaat van toCelsius naar een string.
                 * Deze zet ik vervolgens in het juist veldje.*/
                tbCelsius.Text = toCelsius.ToString();
            }
            else
            {

            }

        }
    }
}
