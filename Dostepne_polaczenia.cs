using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS
{
    class Dostepne_polaczenia
    {
        string lotnisko_wylotu;
        string lotnisko_docelowe;
        string godzina_odlotu;
        string godzina_przylotu;
        string data_lotu;
        int indeks;

       public Dostepne_polaczenia( Lot lot, string Kgodzina_odlotu = "12:30", string Kgodzina_przylotu="14:40", int Kindeks = 1)
        {
            data_lotu = lot.podaj_date();
            lotnisko_docelowe = lot.lotnisko_docelowe;
            lotnisko_wylotu = lot.lotnisko_wylotu;
            godzina_odlotu = Kgodzina_odlotu;
            godzina_przylotu = Kgodzina_przylotu;
            indeks = Kindeks;
        }
        public Dostepne_polaczenia(string Kdata_lotu = "11.11.2018", string Klotnisko_docelowe = "JFK", string Klotnisko_wylotu = "WRO", string Kgodzina_odlotu = "12:30", string Kgodzina_przylotu = "14:40", int Kindeks = 1)
         {
            data_lotu = Kdata_lotu;
            lotnisko_docelowe = Klotnisko_docelowe;
            lotnisko_wylotu = Klotnisko_wylotu;
            godzina_odlotu = Kgodzina_odlotu;
            godzina_przylotu = Kgodzina_przylotu;
            indeks = Kindeks;
        }
        public void wczytaj(Lot lot)
         {
            data_lotu = lot.podaj_date();
             lotnisko_docelowe = lot.lotnisko_docelowe;
            lotnisko_wylotu = lot.lotnisko_wylotu;
         }

        public void wczytaj(string godz_odl,string godz_przyl)
        {
            godzina_odlotu = godz_odl;
            godzina_przylotu = godz_przyl;
        }

        public string podaj_lotnisko_wylotu() { return lotnisko_wylotu; }
        public string podaj_lotnisko_docelowe() { return lotnisko_docelowe; }
        public string podaj_godz_przylotu() { return godzina_przylotu; }
        public string podaj_godz_odlotu() { return godzina_odlotu; }
        public string podaj_date() { return data_lotu; }
    }
}
