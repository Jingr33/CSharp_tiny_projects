using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Semestralni_GUI_aplikace
{
    // Třída pro výpočatní a vykreslovací metody
    class Fraktaly
    {
        // Metoda pro vytvoření bodů trojúhelníku v náhledu
        public static PointF[] Body_Trohuhelníku(int sirkaOkna, int vyskaOkna)
        {
            // definice dílčích proměnných
            double odmocnina3 = Math.Pow(3, 0.5);
            double vrcholKrivkyDouble = vyskaOkna * 3 / 4 - sirkaOkna / 2 * odmocnina3 / 2;
            int vrcholKrivkyInt = (int)vrcholKrivkyDouble;

            PointF[] body = new PointF[4]; // vytvoření pole bodů vrcholů trojúhelníku
            body[0] = new PointF(sirkaOkna / 4, vyskaOkna * 3 / 4);
            body[1] = new PointF(sirkaOkna * 3 / 4, vyskaOkna * 3 / 4);
            body[2] = new PointF(sirkaOkna / 2, vrcholKrivkyInt);
            body[3] = body[0];

            return body; // vrátí pole bodů
        }

        // Metoda pro vykreslení fraktálu Kochovy vločky
        public static void Kochova_krivka(Graphics g, Pen stetec, int iterace, int sirkaOkna, int vyskaOkna)
        {
            double odmocnina3 = Math.Pow(3, 0.5); // pomocná proměnná

            // vykreslování iterací
            if (iterace == 0) // pokud je zadána iterace 0
                g.DrawLines(stetec, Body_Trohuhelníku(sirkaOkna, vyskaOkna));
            else // je zadána jakákoliv jiná iterace
            {
                // proměnná pro počet čar
                double iteraceDouble = iterace;
                double pocetCar = 3 * Math.Pow(4, iteraceDouble);
                // deklarace vektoru
                double vx, vy;
                // první základní čára
                double delkaStrany = sirkaOkna / 2;
                double b1X = sirkaOkna /4;
                double b1Y = vyskaOkna * 3 / 4;
                double b2X = delkaStrany / Math.Pow(3, iteraceDouble) + b1X;
                double b2Y = b1Y;
                Point b1 = new Point((int)Math.Round(b1X),(int)Math.Round(b1Y));
                Point b2 = new Point((int)Math.Round(b2X), (int)Math.Round(b2Y));
                g.DrawLine(stetec, b1, b2);

                // cyklus pro vykreslení lomenné čáry
                for (int j = 1; j < pocetCar; j++)
                {
                    // vektor délky úsečky
                    vx = (b2X - b1X);
                    vy = (b2Y - b1Y);

                    // Bod 2 se zkopíruje jako bod 1
                    b1X = b2X;
                    b1Y = b2Y;
                    b1 = b2;

                    int zbytek = 0;
                    if (j % Math.Pow(4, iterace) != 0)
                    {
                        // pomocná proměnná pro dělení se zbytkem
                        int jx = j;
                        // Při zbytku nula:
                        zbytek = jx % 4;
                        while (zbytek == 0)
                        {
                            jx /= 4;
                            zbytek = jx % 4;
                        }

                        // zahnutí o 120° doleva
                        if (zbytek % 2 == 0)
                        {
                            b2X = b1X - vx / 2 + vy * odmocnina3 / 2; // transformace douřadnic
                            b2Y = b1Y - vx * odmocnina3 / 2 - vy / 2;
                            b2.X = (int)Math.Round(b2X);
                            b2.Y = (int)Math.Round(b2Y);
                            g.DrawLine(stetec, b1, b2); // vykreslení čáry
                        }
                        // zahnutí o 60° doprava
                        else
                        {
                            b2X = b1X + vx / 2 - vy * odmocnina3 / 2; // transformace douřadnic
                            b2Y = b1Y + vx * odmocnina3 / 2 + vy / 2;
                            b2.X = (int)Math.Round(b2X);
                            b2.Y = (int)Math.Round(b2Y);
                            g.DrawLine(stetec, b1, b2); // vykreslení čáry
                        }
                    }
                    else
                    {
                        // zatáčka o 120° doleva
                        b2X = b1X - vx / 2 + vy * odmocnina3 / 2; // transformace douřadnic
                        b2Y = b1Y - vx * odmocnina3 / 2 - vy / 2;
                        b2.X = (int)Math.Round(b2X);
                        b2.Y = (int)Math.Round(b2Y);
                        g.DrawLine(stetec, b1, b2); // vykreslení čáry
                    }
                }
            }
        }

        // Metoda pro vykreslení vnitřního trojúhelníku ve fraktálu Sierpinského trojúhelníku
        private static void Trojuhelnicek(Graphics g, SolidBrush mezerovac, double vrcholX, double vrcholY, double delkaStrany)
        {
            // definice základních bodů troúhelníku
            int b1X = (int)(vrcholX + delkaStrany / 2);
            int b2X = (int)(vrcholX - delkaStrany / 2);
            int bY = (int)(vrcholY + delkaStrany * Math.Pow(3, 0.5) / 2);

            // definice pole bodů pro funkci FillPolygon
            PointF[] body = new PointF[4];
            // definice jednotlivých bodů
            body[0] = new PointF((int)vrcholX, (int)vrcholY);
            body[1] = new Point(b1X, bY);
            body[2] = new Point(b2X, bY);
            body[3] = body[0];

            // vykreslení trojúhelníku
            g.FillPolygon(mezerovac, body);
        }

        // Metoda pro vykreslení nulté iterace fraktálu Sierpinského trojúhelníku
        public static void Zakladni_Sierpinskeho_Trojuhelnik(Graphics g, SolidBrush brush, double zb0x, double zb0y, double zb1x, double zb2x)
        {
            // definice délky strany
            double delkaStrany = zb1x - zb0x;

            //vytvoření pole bodů pro vykreslení plného trojúhelníku
            PointF[] zaklBody = new PointF[4];
            // definice bodů v poli
            zaklBody[0] = new Point((int)zb0x, (int)zb0y);
            zaklBody[1] = new Point((int)zb1x, (int)zb0y);
            zaklBody[2] = new Point((int)zb2x, (int)(zb0y + delkaStrany * Math.Pow(3, 0.5) / 2));
            zaklBody[3] = new Point((int)zb0x, (int)zb0y);

            // vykreslení trojúhelníku
            g.FillPolygon(brush, zaklBody);
        }

        // Metoda pro vykreslení fráktálu Sierpinského trojúhelníku
        public static void Sierpinskeho_trouhelknik(Graphics g, SolidBrush brush, SolidBrush mezerovac, int iterace, int vyskaOkna, int sirkaOkna)
        {
            // základní body trojúhelníku
            double zb0x = sirkaOkna / 15;
            double zb0y = vyskaOkna / 40;
            double zb1x = sirkaOkna * 14 / 15;
            double zb2x = sirkaOkna / 2;
            double delkaStrany = zb1x - zb0x; // délka strany základního trojúhelníku

            // vykreslí se základní trojúhelník
            Zakladni_Sierpinskeho_Trojuhelnik(g, brush, zb0x, zb0y, zb1x, zb2x);

            // cyklus pro počet iterací
            for (int i = 0; i < iterace; i++)
            {
                delkaStrany /= 2; //nová délka strany
                int pocetRad = (int)Math.Pow(2, i);
                // definice / deklarace bodů vrcholu vnitřních trojúhelníků
                double vrcholY = zb0y;
                double vrcholX;

                // cyklus pro tvorbu řad trojúhelníků
                for (int j = 0; j < pocetRad; j++)
                {
                    // definice souřadnice x vnitřích vrcholů trojúhelníku
                    vrcholX = zb0x + delkaStrany * (j + 1);
                    // cyklus pro počet trojúhelníků v řadě
                    for (int k = 0; k < pocetRad - j; k++)
                    {
                        // vykreslení jednoho vnitřního trojúhelníku
                        Trojuhelnicek(g, mezerovac, vrcholX, vrcholY, delkaStrany);
                        // úprava x-ových souřednic vrhcolu vnitřího trojúhelníku
                        vrcholX += delkaStrany * 2; 
                    }
                    // úprava y-ových souřadnic vnitřního vrcholu trojúhelníku
                    vrcholY += delkaStrany * Math.Pow(3, 0.5);
                }
            }


        }

        // Metoda pro vykreslení fraktálu Cantorovo mračno
        public static void Cantorovo_mracno(Graphics g, Pen stetec, Pen mazac, int iterace, int vyskaOkna, int sirkaOkna)
        {
            // vykreslení základní úsečky
            int souradniceY = vyskaOkna * 2/5 + iterace * 25; //vypočítání y-ové souřadnice úsečky
            double bZacatekDouble = sirkaOkna / 10; // levý x-ový bod
            double bKonecDouble = sirkaOkna * 9 / 10; // pravý x-ový bod
            Point bZacatek = new Point((int)bZacatekDouble, souradniceY); // levý bod úsečky
            Point bKonec = new Point((int)bKonecDouble, souradniceY); // pravý bod úsečky
            g.DrawLine(stetec, bZacatek, bKonec); // vykreslovací funkce
            
            // pomocné proměnné
            double vx = bKonecDouble - bZacatekDouble; // délka úsečky
            int velikostPole; //  deklarace velikosti pole bodů dělících úsečku

            // postupné procházení iterací
            for (int i = 1; i <= iterace; i++)
            {
                velikostPole = (int)Math.Pow(3, i); // definice velikosti pole bodů dělících úsečku

                // pole bodů pro rodělení úsečky
                double[] bodyDouble = new double[velikostPole + 1]; // pole pro hodnoty x-ové souřadnice
                bodyDouble[0] = bZacatekDouble; // definice prvního bodu
                Point[] body = new Point[velikostPole + 1]; // pole bodů

                // cyklus pro rozdělení úsečky na jednotlivé části
                for (int j = 1; j <= velikostPole; j++)
                {
                    bodyDouble[j] = bZacatekDouble + vx / velikostPole * j; // vytvoří x-ová souřadnice bodu dělícícho úsečku
                    body[j] = new Point((int)bodyDouble[j], souradniceY);
                }
                // vkreslí do úsečky mezery
                for (int k = 1; k < velikostPole; k += 2)
                {
                    g.DrawLine(mazac, body[k], body[k + 1]);
                }
            }
        }

        // Metoda pro vykreslení vnitříního čtverce
        public static void Ctverec(Graphics g, Pen stetec, float stredX, float stredY, float vektorstrany, float otoceni)
        {
            // základní body
            float p1X = stredX - vektorstrany * 3 / 10;
            float p1Y = stredY - vektorstrany * 3 / 10;
            PointF p1 = (Rotace_Bodu(stredX, stredY, p1X,p1Y, otoceni));
            float p2X = stredX + vektorstrany * 3 / 10;
            float p2Y = stredY - vektorstrany * 3 / 10;
            PointF p2 = (Rotace_Bodu(stredX, stredY, p2X, p2Y, otoceni));
            float p4X = stredX - vektorstrany * 3 / 10;
            float p4Y = stredY + vektorstrany * 3 / 10;
            PointF p4 = (Rotace_Bodu(stredX, stredY, p4X, p4Y, otoceni));
            float p3X = stredX + vektorstrany * 3 / 10;
            float p3Y = stredY + vektorstrany * 3 / 10;
            PointF p3 = (Rotace_Bodu(stredX, stredY, p3X, p3Y, otoceni));
            // body pro oblouk levého horního bodu
            float p1hX = stredX - vektorstrany * 3/10;
            float p1hY = stredY - vektorstrany / 2;
            PointF p1h = (Rotace_Bodu(stredX, stredY, p1hX, p1hY, otoceni));
            float p1lX = stredX - vektorstrany / 2;
            float p1lY = stredY - vektorstrany * 3 / 10;
            PointF p1l = (Rotace_Bodu(stredX, stredY, p1lX, p1lY, otoceni));
            // body pro oblouk pravého horního bodu
            float p2hX = stredX + vektorstrany * 3 / 10;
            float p2hY = stredY - vektorstrany / 2;
            PointF p2h = (Rotace_Bodu(stredX, stredY, p2hX, p2hY, otoceni));
            float p2pX = stredX + vektorstrany / 2;
            float p2pY = stredY - vektorstrany * 3 / 10;
            PointF p2p = (Rotace_Bodu(stredX, stredY, p2pX, p2pY, otoceni));
            // body pro oblouk pravého dolního bodu
            float p3pX = stredX + vektorstrany / 2;
            float p3pY = stredY  + vektorstrany * 3 /10;
            PointF p3p = (Rotace_Bodu(stredX, stredY, p3pX, p3pY, otoceni));
            float p3dX = stredX + vektorstrany * 3 / 10;
            float p3dY = stredY + vektorstrany / 2;
            PointF p3d = (Rotace_Bodu(stredX, stredY, p3dX, p3dY, otoceni));
            // body pro oblouk lavého dolního bodu
            float p4dX = stredX - vektorstrany * 3 / 10;
            float p4dY = stredY + vektorstrany / 2;
            PointF p4d = (Rotace_Bodu(stredX, stredY, p4dX, p4dY, otoceni));
            float p4lX = stredX  - vektorstrany / 2;
            float p4lY = stredY + vektorstrany * 3 / 10;
            PointF p4l = (Rotace_Bodu(stredX, stredY, p4lX, p4lY, otoceni));

            // vykreslení přímek
            g.DrawLine(stetec, p1h, p2h);
            g.DrawLine(stetec, p2p, p3p);
            g.DrawLine(stetec, p3d, p4d);
            g.DrawLine(stetec, p4l, p1l);

            // vykreslení oblouků
            float vzdalenost = vektorstrany / 5; // poloměr oblouku
            g.DrawArc(stetec, p1.X - vzdalenost, p1.Y - vzdalenost, 2 * vzdalenost, 2 * vzdalenost, 180 - otoceni, 90);
            g.DrawArc(stetec, p2.X - vzdalenost, p2.Y - vzdalenost, 2 * vzdalenost, 2 * vzdalenost, 270 - otoceni, 90);
            g.DrawArc(stetec, p3.X - vzdalenost, p3.Y - vzdalenost, 2 * vzdalenost, 2 * vzdalenost, 0 - otoceni, 90);
            g.DrawArc(stetec, p4.X - vzdalenost, p4.Y - vzdalenost, 2 * vzdalenost, 2 * vzdalenost, 90 - otoceni, 90);
        }

        // Metoda na transformaci bodů o daný úhel
        private static PointF Rotace_Bodu(float stredX, float stredY, float bodX, float bodY, float otoceni)
        {
            // přepočet stupňů na radiány
            double RadOtoc = otoceni * Math.PI / 180;
            float x = bodX - stredX; //výpočet otáčeného bodu
            float y = bodY - stredY; // výpočet otáčeného bodu
            // transformace souřadnic bodu
            float transX = (float)(x * Math.Cos(RadOtoc) + y * Math.Sin(RadOtoc));
            float transY = (float)(-x * Math.Sin(RadOtoc) + y * Math.Cos(RadOtoc));
            // vytvoření nového bodu
            PointF transBod = new PointF(transX + stredX, transY + stredY);

            // vrácení transformovaného bodu
            return transBod;
        }

        //Metoda pro vykreslení spirály
        public static void Spirála(Graphics g, Pen stetec,int sirkaOkna, int vyskaOkna, int iterace)
        {
            // proměnné ohraničující největší čtverec
            float stredX = sirkaOkna / 2;
            float stredY = vyskaOkna / 2;
            float vektorStrany = vyskaOkna * 9/10;
            float otoceni; // základní úhel otočení
            float krokOtoceni = 7;
            double radKrok = krokOtoceni * Math.PI / 180; // přepočet stupňů na radiány
            // výpočet zmenšení strany
            float zmenseni = (float)(1.033 / (Math.Sin(radKrok) + Math.Cos(radKrok)));
            
            // cyklus pro vykreslení zadaných iterací
            for (int i = 0; i <= iterace; i++)
            {
                otoceni = i * krokOtoceni; // vyýpočet úhlu otočení
                Ctverec(g, stetec, stredX, stredY, vektorStrany, otoceni); // vykreslení iterace
                vektorStrany *= zmenseni; // zmenšení obrazce pro následující iteraci
            }
        }
    }
}
