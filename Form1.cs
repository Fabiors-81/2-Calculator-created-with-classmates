namespace Prova2
{
    public partial class Form1 : Form
    {
        double risultato = 0;
        int operazione = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void SanGennaro() //funzione per non dare errore quando digitiamo una operazione prima di un numero
        {
            if (Display.Text == "")
            {
                Display.Text = "0";
            }
        }
        private void buttonC_Click(object sender, EventArgs e) //Pulsante per cancellare tutto
        {
            Display.Text = "";
            risultato = 0;
        }

        private void button_Click(object sender, EventArgs e) //Digitazione dei numeri tra 0 e 9
        {
            Display.Text += (sender as Button).Text;
        }

        private void buttonUguale_Click(object sender, EventArgs e) //Pulsante =
        {
            switch (operazione)
            {
                case 1:
                    if (Display.Text != "")
                    {
                        risultato += Convert.ToDouble(Display.Text);
                    }
                    break;
                case 2:
                    if (Display.Text != "")
                    {
                        risultato -= Convert.ToDouble(Display.Text);
                    }
                    break;
                case 3:
                    if (Display.Text != "")
                    {
                        risultato *= Convert.ToDouble(Display.Text);
                    }
                    break;
                case 4:
                    if (Display.Text != "")
                    {
                        risultato /= Convert.ToDouble(Display.Text);
                    }
                    break;
            }
            Display.Text = risultato.ToString();
            risultato = 0;
            operazione = 0;
        }

        private void buttonPiu_Click(object sender, EventArgs e) //Pulsante +
        {
            SanGennaro();
            risultato += Convert.ToDouble(Display.Text);
            Display.Text = "";
            operazione = 1; //case +
        }

        private void buttonMeno_Click(object sender, EventArgs e) //Pulsante -
        {
            if (risultato == 0)
            {
                SanGennaro();
                risultato = Convert.ToDouble(Display.Text);
            }
            else
            {
                risultato -= Convert.ToDouble(Display.Text);
            }
            Display.Text = "";
            operazione = 2; //case -
        }

        private void buttonVirgola_Click(object sender, EventArgs e) //Pulsante , °OFFERTO GENTILMENTE DA GIANLUCA SU CONSIGLIO DI LUCA°
        {
            bool nVirgola = Display.Text.Contains(",");
            if (nVirgola == false)
            {
                Display.Text += ",";
            }
        }

        private void buttonPer_Click(object sender, EventArgs e) //Pusante *
        {
            SanGennaro();
            if (risultato == 0)
            {
                risultato = 1;
            }
            risultato *= Convert.ToDouble(Display.Text);
            Display.Text = "";
            operazione = 3; //case *
        }

        private void buttonDiviso_Click(object sender, EventArgs e) //Pulsante : (/)
        {
            SanGennaro();
            if (risultato == 0)
            {
                risultato = Convert.ToDouble(Display.Text);
            }
            else
            {
                risultato /= Convert.ToDouble(Display.Text);
            }
            Display.Text = "";
            operazione = 4; //case : (/)
        }

        private void buttonPercentuale_Click(object sender, EventArgs e) //Pulsante % (grazie Gianluca)
        {
            SanGennaro();
            double percentuale = Convert.ToDouble(Display.Text);
            percentuale = percentuale / 100;
            Display.Text = Convert.ToString(percentuale);
            percentuale = 0;
        }

        private void buttonPiuOMeno_Click(object sender, EventArgs e) //Pulsante assolutamente inutile schifoso + o -
        {
            SanGennaro();
            double piuomeno = Convert.ToDouble(Display.Text);
            piuomeno = piuomeno * (-1);
            Display.Text = Convert.ToString(piuomeno);
            piuomeno = 0;
        }

        private void buttonCanc_Click(object sender, EventArgs e) //Pulsante Canc (grazie Lyndon Bermoy)
        {
            if ((String.Compare(Display.Text, " ") < 0))
            {
                Display.Text = Display.Text.Substring(0, Display.Text.Length - 1 + 1);
            }
            else
            {
                Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);
            }
        }
    }
}