namespace EAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_prüfen_Click(object sender, EventArgs e)
        {

            if (tb_ean.Text.Length == 13 || tb_ean.Text.Length == 8)
            {
                // Texteingabe in Zahl konvertieren
                int[] eingabe = new int[tb_ean.Text.Length];
                for (int i = 0; i < tb_ean.Text.Length; i++)
                {
                    // ConvertToInt gibt den UNICODE Wert des char an der Stelle i.
                    // Z.B. '1' ist 49. Davon wird der char '0' abgezogen, also 48 🤮
                    eingabe[i] = Convert.ToInt16(tb_ean.Text[i]) - '0';
                }

                int summe = 0;
                // Gehe durch alle 8 oder 13 Nummern:
                for (int i = 0; i < eingabe.Length; i++)
                {
                    // Falls es die Letzte Ziffer ist
                    if (eingabe.Length == i + 1)
                    {
                        // Prüfsumme überprüfen: Zahl bis nächste volle Zehnerstelle finden.
                        // Z.B. Letzte Ziffer von summe ist 3. Dann wäre 7 die Prüfziffer, da 3 + 7 = 10.
                        // Da die letzte Ziffer eine 0 sein könnte 
                        int prüfziffer = ((summe % 10 - 10) * -1) % 10;
                        //rtb_ausgabe.Text += "Prüfziffer: " + prüfziffer +"\n";
                        //rtb_ausgabe.Text += "i: " + i + "\n";
                        if (prüfziffer == eingabe[i])
                        {
                            lb_ergebnis.Text = "✅";
                            lb_ergebnis.ForeColor = Color.Green;
                        }
                        else
                        {
                            lb_ergebnis.Text = "❌ " + prüfziffer + " erwartet";
                            lb_ergebnis.ForeColor = Color.Red;
                        }
                        break;
                    }

                    // Ungerade Stellen werden so belassen und zur Summe addiert. %2 bedeuted die Stelle durch 2 teilbar ist, also gerade
                    // Gerade Stellen werden mit 3 Multipliziert (else)

                    // Die Stelle 'i' (beginnend mit 0) wird auf gerade oder ungerade geprüft
                    // Gerade Stellen werden zur 'summe' hinzugefügt
                    // Ungerade Stellen werden mit 3 multipliziert und dann der 'summe' hinzugefügt
                    if (i % 2 == 0)
                    {
                        summe += eingabe[i];
                    }
                    else
                    {
                        summe += eingabe[i] * 3;
                    }
                    //rtb_ausgabe.Text += "Eingabe: " + eingabe[i] + "\n";
                    //rtb_ausgabe.Text += "Summe: " + summe + "\n";
                    //rtb_ausgabe.Text += "i: " + i + "\n";
                }
            }
            else
            {
                lb_ergebnis.Text = "❌ EAN-8 oder EAN-13 eingeben";
                lb_ergebnis.ForeColor = Color.Red;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Sonderfunktionen um die Benutzerfreundlichkeit zu verbessern:
        private void tb_ean_TextChanged(object sender, EventArgs e)
        {
            if (tb_ean.Text.Length == 13 || tb_ean.Text.Length == 8)
            {
                tb_ean.ForeColor = Color.Black;
            }
            else if (tb_ean.Text.Length > 13)
            {
                // Wenn die Eingabe länger als 13 Zeichen ist, schneide den Rest ab
                tb_ean.Text = tb_ean.Text.Substring(0, 13);
                // Setze den Textcursor an die letzte Stelle
                tb_ean.SelectionStart = 13;
            }
            else
            {
                tb_ean.ForeColor = Color.Gray;
            }
        }
    }
}
