using System;

namespace Semestralni_konzolova_aplikace
{
    class Program
    {
        static void Main(string[] args)
        {
            // počáteční popis prgramu
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Program na výpočet přibližné hodnoty funkce ln(x) v daném bodě (pomocí taylorova rozvoje).\n");
            Console.ResetColor();

            do // cyklus pro opakování funkce programu, pokud uživatel zvolí možnost dalšího výpočtu
            {
                // uživatelský vstup hodnoty x
                string vstupX = "";
                double x = 0;
                bool testVstupuX = true;
                while (testVstupuX)
                {
                    // ošetření a přetypování vstupu hodnoty x
                    try
                    {
                        Console.Write("Zadejte hodnotu x (x > 0): ");
                        vstupX = Console.ReadLine();
                        x = double.Parse(vstupX);
                        // ošetření definičního oboru ln(x)
                        if (x > 0)
                        { testVstupuX = false; }
                        else
                        {   // pokud je vstup mimo definiční obor ln(x) zobrazí se chybová hláška
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Pro tuto hodnotu není funkce ln(x) definovaná. D(f) = (0; nekonečno)\nZadejte hodnotu z definičního oboru.");
                            Console.ResetColor();
                        }
                    }
                    catch (FormatException) // ošetření formátu vstupu
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Hodna není ve správném formátu.\nZkuste to znovu.");
                        Console.ResetColor();
                    }
                    catch (Exception) // obecná podmínka
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Něco se nepovedlo.\nZkuste to znovu.");
                        Console.ResetColor();
                    }
                }
                Console.WriteLine(); // estetická mezera

                // uživatelský vstup počtu členů rozvoje
                string vstupPocetClenu = "";
                int pocetClenu = 0;
                bool testVstupuPocetClenu = true;
                while (testVstupuPocetClenu)
                {
                    // ošetření a přetypování vstupu počtu členů
                    try
                    {
                        Console.Write("Zadejte počet členů taylorova rozvoje: ");
                        vstupPocetClenu = Console.ReadLine();
                        pocetClenu = int.Parse(vstupPocetClenu);
                        // ošetření hodnoty počtu členů rozvoje
                        if (pocetClenu > 0)
                            testVstupuPocetClenu = false;
                        else
                        {   // chybová hláška se zobrazí, pokud uživatel zadá číslo <= 0
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Neplatné číslo.\nZadejte celé číslo vetší než 0.");
                            Console.ResetColor();
                        }
                    }
                    catch (FormatException) // ošetření formátu vstupu
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Hodna není ve správném formátu.\nZadejte celé číslo větší než 0.");
                        Console.ResetColor();
                    }
                    catch (Exception) // obecná podmínka
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Něco se nepovedlo.\nZkuste to znovu.");
                        Console.ResetColor();
                    }
                }

                // potvrzení uživatelského vstupu
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nVypočítám pomocí {0} členů taylorova rozvoje hodnotu ln({1}).", pocetClenu, x);
                Console.ResetColor();

                // pokračování k výpočtu (aby si uživatel mohl zkontrolovat své zadání)
                Console.WriteLine("Pro pokračování stikněte Enter...\n");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }

                // VÝPOČET
                // pokud x náleží (0; 1) převrátí se jeho hodnota
                double mezivypocet1 = Funkce.Prevraceni(x);
                bool prevraceno = true;
                if (mezivypocet1 == x)
                    prevraceno = false;

                // proměnná x se dělí eulerovým číslem, až než je menší než jeho hodnota
                int pocetE = 0;
                double e = Math.Exp(1);
                double odmocninaE = 1.6488; // odmocnina z e
                while (mezivypocet1 > odmocninaE)
                {
                    mezivypocet1 /= e;
                    pocetE++;
                }

                // výpočet přibližné hodnoty pomocí taylorova rozvoje
                double mezivypocet2 = Funkce.Tayloruv_rozvoj(mezivypocet1, pocetClenu);

                // k mezivýsledku se přičte proměnná pocetE
                double mezivypocet3 = mezivypocet2 + pocetE;

                // výsledek se převrátí zpět v případě, že se výše jeho hodnota převrátila
                double vysledek;
                if (prevraceno)
                    vysledek = -mezivypocet3;
                else
                    vysledek = mezivypocet3;

                // vypsání hodnoty uživateli
                Console.Write("Hodnota ln({0}) s danou přesnotí je přibližně: ", vstupX);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(vysledek);
                Console.ResetColor();

                // příkaz pro ukončení programu klávesou Esc
                Console.WriteLine("\nPro ukončení porgramu stiskni klávesu Esc, Nový výpočet spustíte stiknutím libovolné jiné klávesy...\n");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
