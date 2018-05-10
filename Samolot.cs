using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS
{
    public class Samolot
    {
       protected string nazwa;
       protected int ilosc_miejsc;
        public virtual int ile_miejsc() { return ilosc_miejsc; } //zwraca ilość miejsc w samolocie dla obiektu samolot, a dla obiektu lot ilość wolnych miejsc w danym połączeniu
        public Samolot (int n = 156, string name = "Airbus A319")
        {
            ilosc_miejsc = n;
            nazwa = name;
        }
        public string wysw()
        {
            return nazwa;
        }
       
    }

    class Lot : Samolot
    {
        private bool [] miejsca = new bool [157];//jeśli miejsca[i] == true to miejsce jest wolne
        private int wolne_miejsca;
        private string nr_lotu;
        public string lotnisko_docelowe { get; set; } // !!!!!
        public string lotnisko_wylotu;
        private double cena_pdst;
        private string data_odlotu;
        private double ustaw_cene()
        {
            double losowanie = 200; 

            return losowanie;
        }
        public virtual int ile_miejsc() { return wolne_miejsca; }
        public double ustaw_cene(bool bagaz, bool priority)
        {
           
                double cena_aktualna = cena_pdst;
                if (bagaz == true)
                {
                    cena_aktualna += 110;
                }
                if (priority == true)
                {
                    cena_aktualna += 50;
                }

                return cena_aktualna;
            
        }
        //ustawia cenę zależnie od tego czy pasażer wybrał bagaż i/lub priority
        public Lot(int n = 156, string name = "Airbus A319", int wolne = 156, string docelowe = "KEF", string nr = "NO217", string data = "01.01.2019", string wylotu = "WRO")
        {
            for (int i = 0; i <= wolne; i++)
            {
                miejsca[i] = true;
            }
            wolne_miejsca = wolne;
            lotnisko_docelowe = docelowe;
            lotnisko_wylotu = wylotu;
            data_odlotu = data;
            nr_lotu = nr;
            cena_pdst = ustaw_cene();


        }
        public Lot(Samolot  sam, int wolne = 156, string docelowe = "WRO", string nr = "NO217", string data = "01.01.2019", string wylotu = "WRO") : base (sam.ile_miejsc(), sam.wysw()) //znaleźć ładniejsze rozwiązanie
        {
            for (int i = 0; i <= wolne; i++)
            {
                miejsca[i] = true;
            }

            wolne_miejsca = wolne;
            lotnisko_docelowe = docelowe;
            lotnisko_wylotu = wylotu;
            data_odlotu = data;
            nr_lotu = nr;
            cena_pdst = ustaw_cene();
        }
        public bool zajmij_miejsce(int miejsce)
        {
            if (miejsca[miejsce] == true && miejsce > 0)
            {
                miejsca[miejsce] = false;
                wolne_miejsca--;
                return true;
            }
            else return false;
        }
        //zajmuje wybrane miejsce i zwraca true jeżeli miejsce zostało poprawnie zajęte lub false jeżeli wybrane miejsce było już zajęte
        public bool zwolnij_miejsce(int miejsce) //zwalnia miejsce i zwraca true jeśli miejsce zostało poprawnie zwolnione lub false w przeciwnym wypadku
        {
            if (miejsca[miejsce] == false && miejsce > 0)
            {
                miejsca[miejsce] = true;
                wolne_miejsca++;
                return true;
            }
            else return false;
        }
            
        public  string podaj_nr_lotu() { return nr_lotu; }
        public string podaj_date() { return data_odlotu; }
        public double podaj_cene(bool bagaz, bool priority)
        {
            double cena_aktualna = cena_pdst;
            if (bagaz == true)
            {
                cena_aktualna += 110;
            }
            if (priority == true)
            {
                cena_aktualna += 50;
            }

            return cena_aktualna;
        }



        // ustawia losową cenę przy tworzeniu obiektu
    }
}

