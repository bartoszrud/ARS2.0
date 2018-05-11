using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS
{
    class Admin
    {
        const string haslo = "admin123";


        public Admin()
        {

        }
        public Lot dodaj_lot(string docelowe, string nr_lotu, string data, string wylotu)
        {
            Lot lot = new Lot(156, "Airbus A319", 156, docelowe, nr_lotu, data, wylotu);
            return lot;
        }
        public bool zaloguj(string h)
        {
            if (h == haslo)
            { return true; }
            else return false;
        }
        public void anuluj_rezerwacje(Rezerwacje  r)
        {
            r.anuluj();
        }
    }
}
