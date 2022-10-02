namespace Oefening3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int j = 0;
            for(int teller = 0; teller < 7 * 546; teller++)
            {
                while(j <= 100){
                    j++;
                    Console.WriteLine(j);
            }
            }
        }
    }
}