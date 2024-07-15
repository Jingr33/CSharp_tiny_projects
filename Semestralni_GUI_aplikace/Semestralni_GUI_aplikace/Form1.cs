using System;
using System.Drawing;
using System.Windows.Forms;

namespace Semestralni_GUI_aplikace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Inicializace komponent
            InitializeComponent();
            // vytvoření prostoru pro vykreslování
            g = pnl1_vykreslit.CreateGraphics(); // prostor na hlavním plátně
            nahled = pnl2_nahled.CreateGraphics(); // prostor v ukázce tvaru
        }

        Graphics g;  // ukazatel na grafiku hlavního plátna
        Graphics nahled; // ukazaetl na grafiku ukázky tvaru

        ColorDialog barva_pozadi = new ColorDialog(); // Vytvoření objektu dialogu pro barvu pozadí
        ColorDialog barva_stetce = new ColorDialog();   //Vytvoření objektu dialogu pro barvu štětce

        private void pnl1_obrazec_Paint(object sender, PaintEventArgs e)
        {

        }

        // Metoda pro kliknutí na tlačítko "Barva pozadí"
        private void btn3_pozadi_Click(object sender, EventArgs e)
        {
            // Zvolená barva ve výběru barev se uloží jako barva pozadí na hlavní i náhledovém plátně
            if (barva_pozadi.ShowDialog() == DialogResult.OK)
            {
                pnl3_pozadi.BackColor = barva_pozadi.Color; // přiřazení pro náhledový panel (vedle tlačítka "barva pozadí")
                colorDialog1_pozadi.Color = barva_pozadi.Color; // přiřazení barvy pro hlavní vykreslovací okno
            }
        }

        // Metoda pro stiknutí tlačítka "Vykreslit"
        private void btn2_vykreslit_Click(object sender, EventArgs e)
        {
            // Barva zvolená pomocí tlačítka "Barva pozadí" se nastaví jako pozadí
            pnl1_vykreslit.BackColor = barva_pozadi.Color;

            // ošetření podmínek uživatelského vstupu pro tloušťku štětce
            float tloustkaStetce = 0;
                try
                {
                    tloustkaStetce = float.Parse(tb1_tlousta_stetce.Text);
                    lbl_stetec_chyba.Text = ""; // pokud uživatel už dříve zadal chybný vstup, tak se smaže
                }
                catch (FormatException) // formátová chyba
                { 
                    lbl_stetec_chyba.Text = "Nevhodná tloušťka, znovu.";
                }
                catch (Exception) // obecná chyba
                { 
                    lbl_stetec_chyba.Text = "Něco se nepovedlo.";
                }


            // Vytvoření štetce s nastavením jeho barvy a tloušťky čáry a vytvoření štetce na vymazávání
            Pen stetec = new Pen(barva_stetce.Color, tloustkaStetce);
            Pen mazac = new Pen(barva_pozadi.Color, tloustkaStetce);

            // Vytvoření štětce pro vykreslování plných tvarů a plných mezer
            colorDialog2_stetec.Color = barva_stetce.Color; // nastavení barvy colorDialogu
            SolidBrush brush = new SolidBrush(colorDialog2_stetec.Color);
            colorDialog1_pozadi.Color = barva_pozadi.Color; // nastavení barvy colorDialogu pro pozadí
            SolidBrush mezerovac = new SolidBrush(colorDialog1_pozadi.Color);

            //pomocné proměnné pro určení velikosti vykreslovacího okna
            int sirkaOkna = pnl1_vykreslit.Width;
            int vyskaOkna = pnl1_vykreslit.Height;

            // proměnná pro zadaný počet iterací
            int iterace = (int)numericUpDown1.Value;

            // vykreslení zadaného fraktálu
            switch (cmb1_tvar.Text)
            {
                case "Kochova vločka": // vykreslení Kochovy vločky
                    Fraktaly.Kochova_krivka(g, stetec, iterace, sirkaOkna, vyskaOkna);
                    break;
                case "Cantorovo mračno": // vykreslení Cantorova mračna
                    Fraktaly.Cantorovo_mracno(g, stetec, mazac, iterace, vyskaOkna, sirkaOkna);
                    break;
                case "Sierpinského trojúhelník": // vykreslení Sierpinskeho trojúhelníku
                    Fraktaly.Sierpinskeho_trouhelknik(g, brush, mezerovac, iterace,vyskaOkna, sirkaOkna) ;
                    break;
                case "Spirála": // vykreslení spirály
                    Fraktaly.Spirála(g, stetec, sirkaOkna, vyskaOkna, iterace);
                    break;
                default: // ošetření nevhodného vstupu
                    cmb1_tvar.Text = "Chyba!!!";
                    lbl_chyba_tvar.Text = "Zadej položku z výběru.";
                    break;
            }
        }

        // Metoda pro stisnutí tlačítka "Barva štetce"
        private void btn4_stetec_Click(object sender, EventArgs e)
        {
            // Nastavení barva štětce náhledového (vedle tlačítka "barva štětce") okna na zvolenou barvu
            if (barva_stetce.ShowDialog() == DialogResult.OK)
            {
                pnl4_stetec.BackColor = barva_stetce.Color;
            }
        }

        // Metoda pro kliknutí na tlačítko "Náhled"
        private void btn1_nahled_tvaru_Click(object sender, EventArgs e)
        {
            Pen stetec = new Pen(Color.Black, 3); // vytvoření štětce (černá barva, šířka 3)
            SolidBrush brush = new SolidBrush(Color.Black); // vytvoření štětce pro kreslení plných tvarů černé barvy

            // pomocné porměnné pro určení velikosti vykreslovacího okna
            int sirkaOkna = pnl2_nahled.Width;
            int vyskaOkna = pnl2_nahled.Height;

            nahled.Clear(Color.White); // vymazání plátna
            lbl_chyba_tvar.Text = ""; // vymazání předchozí chybové hlášky
            
            // vykreslení vybraného tvaru
            switch (cmb1_tvar.Text)
            {
                case "Kochova vločka": // Zvolení možnosti Kochova křivka
                    nahled.DrawLines(stetec, Fraktaly.Body_Trohuhelníku(sirkaOkna, vyskaOkna)); // vykreslení tvaru
                    break;
                case "Cantorovo mračno": // zvolení možnosti Cantorovo mračno
                    // základní body úsečky
                    double bZac = sirkaOkna / 10;
                    double bKon = sirkaOkna * 9 / 10;
                    Point bodZac = new Point((int)bZac, vyskaOkna / 2);
                    Point bodKon = new Point((int)bKon, vyskaOkna / 2);
                    nahled.DrawLine(stetec, bodZac, bodKon); // vykreslení úsečky
                    break;
                case "Sierpinského trojúhelník": // Zvolení možnosti Sierpinského trojúhelník
                    Fraktaly.Zakladni_Sierpinskeho_Trojuhelnik(nahled, brush, sirkaOkna / 5, vyskaOkna / 10, sirkaOkna * 4 / 5, sirkaOkna / 2);
                    break;
                case "Spirála": // Zvolení možnosti "Spirála"
                    Fraktaly.Ctverec(nahled, stetec, sirkaOkna / 2, vyskaOkna / 2, vyskaOkna * 4/5, 0);
                    break;
                default: // ošetření chyb při vstupu
                    cmb1_tvar.Text = "Chyba!!!";
                    lbl_chyba_tvar.Text = "Zadej položku z výběru.";
                    break;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        // tlačítko "Smazat plátno"
        private void btn5_smazat_Click(object sender, EventArgs e)
        {
            g.Clear(barva_pozadi.Color); // nastaví barvu pozadí
        }

        private void pnl1_vykreslit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl3_iterace_Click(object sender, EventArgs e)
        {

        }

        private void cmb1_tvar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
