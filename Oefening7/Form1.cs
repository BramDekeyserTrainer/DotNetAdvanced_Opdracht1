using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening7
{
    public partial class formSum : Form
    {
        public formSum()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /*Ik maak een variabele ingegevenGetal aan die de tekst uit tbIngegevenGetal ophaald.
             * Deze parset hij naar een integer.*/
            int ingegevenGetal = int.Parse(tbIngegevenGetal.Text);

            /*Ik declareer een variabele 'resultaat' als integer.
             * De 0 is slechts de beginwaarde!!!*/
            int resultaat = 0;

            /*Ik stel int teller gelijk aan het ingegeven getal.
             * Deze heeft dus niet meer nul als begin waarde.
             * De lus blijft verder gaan zolang de voorwaarde actief is,
             * die zegt dat de teller groter moet zijn dan 0.
             * Bij elke iteratie decrementen we met 1.
             * Dat is waar die 'teller--' voor staat.*/
            for (int teller = ingegevenGetal; teller > 0; teller--)
            {
                // Het resultaat is steeds gelijk aan de optelling van het resultaat en de huidige teller.
                resultaat = resultaat + teller;
            }

            /*Ik zet het resultaat in het juiste veldje.
             * Aangezien de gebruikte variabele een integer is,
             * zet ik deze om naar een string met behulp van de ToString-function.*/ 
            tbResultaat.Text = resultaat.ToString();
        }
    }
}
