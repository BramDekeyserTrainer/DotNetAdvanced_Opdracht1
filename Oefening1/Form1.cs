using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening1
{
    public partial class formBegroeting : Form
    {
        public formBegroeting()
        {
            InitializeComponent();
        }

        private void formBegroeting_Load(object sender, EventArgs e)
        {
            //Ik maak de variabelen aan die ik in mijn label wil zetten. Dit zijn strings.
            string naam = "Bram";
            string actueleTijd = DateTime.Now.ToShortTimeString(); //Ik maak de korte versie van de huidige tijd. (Het uur.)
            string actueleDatum = DateTime.Now.ToShortDateString(); //Ik maak de korte versie van de huidige datum.

            /*Ik stel de tekst van het label: lblBegroeting, gelijk aan een string die een concatenatie is van strings en
             stukje zelf geschreven tekst om ze samen één zin te laten vormen.*/
            lblBegroeting.Text = "Hello " + naam + ". Het is " + actueleTijd + " op " + actueleDatum + ".";
        }
    }
}
