using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ARS
{
    public partial class Form1 : Form
    {
        int liczba_lotow = 0;
        int licznik_rezerwacji = 0;
        int licznik_kart = 0;
        int ktora_rezerwacja = 0;
        int wybrany_lot = 0;
        Admin admin1 = new Admin();

        List<Rezerwacje> rezerwacje = new List<Rezerwacje>();
        List<Karta_pokladowa> karty = new List<Karta_pokladowa>();
        List<Lot> loty = new List<Lot>();
        List<Dostepne_polaczenia> pol = new List<Dostepne_polaczenia>();
       
       
        

        public Form1()
        {
            InitializeComponent();
            panelRezerw.Hide();
            panelKarta.Hide();
            panelZarzadzaj.Hide();
            panelPlatnosc.Hide();
            panelKartaZarz.Hide();
            panelLogowanieAdmin.Hide();
            panelAdminPanel.Hide();
            panelDodajLot.Hide();
            panelAnulowanie.Hide();

            Lot l1 = new Lot(156);
            
            loty.Insert(0,l1);
            Dostepne_polaczenia pol1 = new Dostepne_polaczenia(loty[liczba_lotow]);
            pol.Insert(liczba_lotow, pol1);
            liczba_lotow++;
            wyswietlanie();
        }


        private void przyciskRezerwuj_Click(object sender, EventArgs e)
        {
            panelRezerw.Show();
            panelKarta.Hide();
            panelLoty.Hide();
            wybrany_lot = comboBox.SelectedIndex;
            //MessageBox.Show(wybrany_lot.ToString());
           

        }

        private void wyswietlanie()
        {
            for (int i = 0; i < liczba_lotow; i++)
            {
                int x = i + 1;
                tabelaLotow.Rows.Add(pol[i].podaj_lotnisko_wylotu(), pol[i].podaj_lotnisko_docelowe(), pol[i].podaj_godz_odlotu(), pol[i].podaj_godz_przylotu(), pol[i].podaj_date() );
                tabelaLotowAdmin.Rows.Add(pol[i].podaj_lotnisko_wylotu(), pol[i].podaj_lotnisko_docelowe(), pol[i].podaj_godz_odlotu(), pol[i].podaj_godz_przylotu(), pol[i].podaj_date());
                comboBox.Items.Add(x.ToString());
                comboBox.SelectedIndex=0;
                comboBoxAdmin.Items.Add(x.ToString());
                comboBoxAdmin.SelectedIndex = 0;
            }
        }


        private void przyciskDalej_Click(object sender, EventArgs e)
        {
            panelKarta.Show();
            panelRezerw.Hide();
            panelLoty.Hide();
            string imie = textImie.Text;
            string nazwisko = textNazwisko.Text;
            string nrtel = textNrtel.Text;
            string kraj = textKraj.Text;
            Rezerwacje p1 = new Rezerwacje(loty[wybrany_lot], imie, nazwisko, nrtel, kraj);
            licznik_rezerwacji++;
            rezerwacje.Add(p1);
        }

        private void przyciskZarezerwuj_Click(object sender, EventArgs e)
        {
            panelLoty.BringToFront();
            Karta_pokladowa k1 = new Karta_pokladowa(rezerwacje[licznik_kart]);
            karty.Add(k1);
            if (checkBagaz.Checked)
            {
                karty[licznik_kart].dodaj_bagaz();
            }

            if (checkPriority.Checked)
            {
                karty[licznik_kart].dodaj_priority();
            }

            if (loty[wybrany_lot].zajmij_miejsce((int)boxNrmiejsca.Value))
            {
                karty[licznik_kart].wybierz_miejsce((int)boxNrmiejsca.Value);
                panelKarta.Hide();
                panelPlatnosc.Show();
                licznik_kart++;
            }
            else MessageBox.Show("Wybrane miejsce jest już zajęte!");
                
        }

        private void przyciskZarzadzaj_Click(object sender, EventArgs e)
        {
            panelLoty.Hide();
            panelZarzadzaj.Show();
        }

        private void przyciskZarzadzaj_Click_1(object sender, EventArgs e)
        {
            panelLoty.Hide();
            panelZarzadzaj.Show();
        }

        private void przyciskPowrot_Click(object sender, EventArgs e)
        {
            panelZarzadzaj.Hide();
            panelLoty.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelPlatnosc.Hide();
            panelLoty.Show();
        }

        private void przyciskSpr_Click(object sender, EventArgs e)
        {
            panelZarzadzaj.Hide();
            panelKartaZarz.Show();
        }

       
        private void przyciskStrglZarz_Click_1(object sender, EventArgs e)
        {
            panelKartaZarz.Hide();
            panelLoty.Show();
        }

        private void przyciskAdmin_Click(object sender, EventArgs e)
        {
            panelLoty.Hide();
            panelLogowanieAdmin.Show();
        }

        private void przyciskAkceptujZarezerw_Click(object sender, EventArgs e)
        {
            panelKartaZarz.Hide();
            panelLoty.Show();
        }

        private void przyciskZaloguj_Click(object sender, EventArgs e)
        {
            string haslo = textWprowadzoneHaslo.Text;
            if (admin1.zaloguj(haslo))
            {
                // panelLogowanieAdmin.Hide();
                panelAdminPanel.BringToFront();
                panelAdminPanel.Show();
            }
        }

        private void przyciskUsunLot_Click(object sender, EventArgs e)
        {
            int dousuniecia = comboBoxAdmin.SelectedIndex;
            MessageBox.Show(dousuniecia.ToString());
            loty.RemoveAt(dousuniecia);
            
        }

        private void przyciskAnulowanieRezerw_Click(object sender, EventArgs e)
        {
            panelAdminPanel.Hide();
            panelAnulowanie.Show();
        }

        private void przyciskDodajLot_Click(object sender, EventArgs e)
        {
            panelAdminPanel.Hide();
            panelDodajLot.Show();
            panelDodajLot.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
