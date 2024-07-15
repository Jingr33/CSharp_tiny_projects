using System;
using System.Collections.Generic;
using System.Text;

namespace Semestralni_konzolova_aplikace
{
    class Funkce
    {
        // vypocet taylorova clenu
        private static double Tayloruv_clen (double promenna, int poradiClenu) // vstupem je vstpní hodnota x a pořadí členu rozvoje
        {   // výpočet čitatele členu taylorova rozvoje
            double citatel = 1;
            for (int i = 0; i < poradiClenu; i++)
            {
                citatel = citatel * (promenna - 1);
            }
            // výpočet jmenovatele členu taylorova rozvoje
            int jmenovatel = poradiClenu;
            double clen = citatel / jmenovatel;
            // znaménko členu (ale se každý lichý člen přičetl a každý sudý odečetl)
            if (poradiClenu % 2 == 0)
                clen = -clen;
            return clen; // vrací hodnotu jednoho členu taylorova rozvoje
        }

        // vypocet taylorova rozvoje
        public static double Tayloruv_rozvoj(double promenna, int pocetClenu)
        {
            double rozvoj = 0;
            for (int j = 0; j < pocetClenu; j++) // cyklus pro přičítání jednotlivých členu taylorova rozvoje
            {
                rozvoj = rozvoj + Tayloruv_clen(promenna, j + 1); // funkce Tayloruv_clen výše
            }
            return rozvoj; // vrátí výslednou hodnotu taylorova rozvoje vypočítaného na zadaný počet iterací
        }

        // prevraceni hodnoty pokud je hodnota menší než 1
        public static double Prevraceni(double promenna)
        {
            if (promenna < 1) // pokud je hodnota menší než nula, převrátí se
            {
                promenna = 1 / promenna;
            }
            else { } // pokud je větší než 0, zůstne stejná
            return promenna; // metoda vrací stejnou vstupní hodnotu, nebo převrácenou vstupní hodnotu
        }
    }
}
