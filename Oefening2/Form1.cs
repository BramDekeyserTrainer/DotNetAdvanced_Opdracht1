namespace Oefening2
{
    public partial class formIsItBigger : Form
    {
        public formIsItBigger()
        {
            InitializeComponent();
        }

        private void lblVermenigvuldiging1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Ik maak de getallen aan, alle vier in de vorm van een integer variabele.
            int eersteGetal = 12345;
            int tweedeGetal = 54321;
            int derdeGetal = 22222;
            int vierdeGetal = 33333;

            //Hier maak ik alle berekeningen.
            int eersteFormule = eersteGetal * tweedeGetal;
            int tweedeFormule = derdeGetal * vierdeGetal;

            //Ik maak een boolean aan die ik momenteel geen waarde geef.
            bool isHetGroterDan;
            /*Ik gebruik een if statement om na te gaan of het resultaat van de eerste formule al dan niet groter is dan
             het resultaat van de tweede formule. Indien het klopt, zet ik de waarde van de variabele 'isHetGroterDan'
            op true, en zo niet op false.*/
            if(eersteFormule > tweedeFormule)
            {
                isHetGroterDan = true;
            }
            else
            {
                isHetGroterDan = false;
            }

            /*Hier maak ik gebruik van de resultaten van de variabelen om via een concatenatie één zin te vormen.
             Dit doe ik tot drie maal en zet deze als tekst bij de gemaakte labels.*/
            lblVermenigvuldiging1.Text = eersteGetal + " * " + tweedeGetal + " = " + eersteFormule;
            lblVermenigvuldiging2.Text = derdeGetal + " * " + vierdeGetal + " = " + tweedeFormule;
            lblTrueOfFalse.Text = eersteGetal + " * " + tweedeGetal + " = " + " > " + derdeGetal + " * " + vierdeGetal + " = " + isHetGroterDan;
        }
    }
}