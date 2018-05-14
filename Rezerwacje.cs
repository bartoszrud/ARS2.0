using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS
{
    class Rezerwacje
    {
        protected string imie;
        string kraj;
        bool anulowana;
        string nr_lotu;
        string data_odlotu;
        string nazwisko;
        string nr_tel;

        public Rezerwacje()
        {
            anulowana = false;
        }
        public Rezerwacje(Lot lot, string Kimie, string Knazwisko, string Knr_tel, string Kkraj = "PL")
        {
            imie = Kimie;
            nazwisko = Knazwisko;
            nr_tel = Knr_tel;
            kraj = Kkraj;
            nr_lotu = lot.podaj_nr_lotu();
            data_odlotu = lot.podaj_date();
            anulowana = false;
        }
        public Rezerwacje(string nrlotu, string data, string Kimie, string Knazwisko, string Knr_tel, string Kkraj = "PL", bool Kczy_anulowana=false)
        {
            imie = Kimie;
            nazwisko = Knazwisko;
            nr_tel = Knr_tel;
            kraj = Kkraj;
            nr_lotu = nrlotu;
            data_odlotu = data;
            anulowana = Kczy_anulowana;
        }
        public void wczytaj_dane(string Kimie, string Knazwisko, string Knr_tel, string Kkraj)
        {
            imie = Kimie;
            nazwisko = Knazwisko;
            nr_tel = Knr_tel;
            kraj = Kkraj;
        }
        //  public void zarezerwuj(); //sprawdzić
        public bool czy_anulowana() { return anulowana; }
        public void anuluj()
        {
            anulowana = true;
        }
        public string pokazNazwisko() { return nazwisko; }
        public string pokazNr_tel() { return nr_tel; }
        public string podajNr_lotu() { return nr_lotu; }
        public string podajDate_lotu() { return data_odlotu; }

        // ponieważ nie ma konstruktora kopiującego
        public string podajImie() { return imie; }
        public string podajKraj() { return kraj; }
    }


    class Karta_pokladowa :  Rezerwacje
        {
        // prawdopodobnie będą potrzebne przyjaźnie do obsługi zapisu/odczytu

       
        bool priority;
        bool bagaz;
        int nr_miejsca;
        bool status_platnosci;


        public Karta_pokladowa()
        {

        }
        public Karta_pokladowa(Lot lot, string Kimie, string Knazwisko, string Knr_tel, string Kkraj = "PL", bool bag = false, bool prio = false)
            : base (lot, Kimie, Knazwisko, Knr_tel, Kkraj = "PL") // ogarnąć konstruktor kopiujący!!
        {
            bagaz = bag;
            priority = prio;
            status_platnosci = false;
        }

        public Karta_pokladowa(string nrlotu, string data, string Kimie, string Knazwisko, string Knr_tel, int Knr_miejsca, string Kkraj = "PL",  bool Kczy_anulowana = false, bool bag = false, bool prio = false, bool status_pl = true)
            : base (nrlotu,  data,  Kimie,  Knazwisko, Knr_tel, Kkraj = "PL",  Kczy_anulowana = false)
        {
            bagaz = bag;
            priority = prio;
            status_platnosci = status_pl;
            nr_miejsca = Knr_miejsca;
        }
        public void dodaj_bagaz() { bagaz = true; }
        public void dodaj_priority() { priority = true; }
        public void wybierz_miejsce(int siedzenie) { nr_miejsca = siedzenie; }
        public int pokaz_karte() //zwraca nr miejsca ktróre wybrał pasażer
        {
            return nr_miejsca;
        }
        public bool podaj_status_platnosci() { return status_platnosci; }
            
        public bool czyBagaz()  // zwraca true jeżeli pasażer ma już wykupiony bagaż
        {
            if (bagaz == true)
            {
                return true;
            }
            else return false;
        }
            
        public bool czyPriority()  // zwraca true jeżeli pasażer ma już wykupiony Priority Pass
        {
            if (priority == true)
            {
                return true;
            }
            else return false;
        }
        
        public void potwierdzPlatnosc()
        {
            status_platnosci = true;
        }

    }

}
