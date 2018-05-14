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
            wczytywanieLotow();

            this.Controls.Add(panelKarta);
            wczytywanieRezerw();
            wczytywanieKart();
            MessageBox.Show(liczba_lotow.ToString());

            
          //  Lot l1 = new Lot(156);
            
          //  loty.Insert(0,l1);
            
            
            wyswietlanie();
        }


        private void przyciskRezerwuj_Click(object sender, EventArgs e)
        {
            panelRezerw.Show();
            panelRezerw.BringToFront();
          
            panelLoty.Hide();
            wybrany_lot = comboBox.SelectedIndex;
            //MessageBox.Show(wybrany_lot.ToString());
           

        }

        private void wyswietlanie()
        {
            for (int i = 0; i < liczba_lotow; i++)
            {
                Dostepne_polaczenia polaczenie = new Dostepne_polaczenia(loty[i]);
                pol.Insert(i, polaczenie);

                int x = i + 1;
               // tabelaLotow.Rows.Add(pol[i].podaj_lotnisko_wylotu(), pol[i].podaj_lotnisko_docelowe(), pol[i].podaj_godz_odlotu(), pol[i].podaj_godz_przylotu(), pol[i].podaj_date() );
              //  tabelaLotowAdmin.Rows.Add(pol[i].podaj_lotnisko_wylotu(), pol[i].podaj_lotnisko_docelowe(), pol[i].podaj_godz_odlotu(), pol[i].podaj_godz_przylotu(), pol[i].podaj_date());
                comboBox.Items.Add(x.ToString());
                comboBox.SelectedIndex=0;
                comboBoxAdmin.Items.Add(x.ToString());
                comboBoxAdmin.SelectedIndex = 0;
            }
            wczytywaniePolaczen();
            for(int i =0; i<liczba_lotow;i++)
            {
                tabelaLotow.Rows.Add(pol[i].podaj_lotnisko_wylotu(), pol[i].podaj_lotnisko_docelowe(), pol[i].podaj_godz_odlotu(), pol[i].podaj_godz_przylotu(), pol[i].podaj_date());
                tabelaLotowAdmin.Rows.Add(pol[i].podaj_lotnisko_wylotu(), pol[i].podaj_lotnisko_docelowe(), pol[i].podaj_godz_odlotu(), pol[i].podaj_godz_przylotu(), pol[i].podaj_date());
            }
        }


        private void przyciskDalej_Click(object sender, EventArgs e)
        {
            
            string imie = textImie.Text;
            string nazwisko = textNazwisko.Text;
            string nrtel = textNrtel.Text;
            string kraj = textKraj.Text;

            if (imie.Length > 1 && nazwisko.Length > 1 && nrtel.Length > 8 && nrtel.Length < 14 && kraj.Length > 0)
            {
                Rezerwacje p1 = new Rezerwacje(loty[wybrany_lot], imie, nazwisko, nrtel, kraj);
                licznik_rezerwacji++;
                rezerwacje.Add(p1);

                textImie.Clear();
                textNazwisko.Clear();
                textNrtel.Clear();
                textKraj.Clear();
                panelRezerw.Hide();
             
                //panelKarta.Location = new Point(16, 16);
                panelKarta.Show();
                panelKarta.BringToFront();
             
            }
            else MessageBox.Show("Wprowadzono nieprawidłowe dane!");


                
               
                
                
        }

        private void przyciskZarezerwuj_Click(object sender, EventArgs e)
        {
            panelLoty.BringToFront();
            Karta_pokladowa k1 = new Karta_pokladowa(loty[wybrany_lot], rezerwacje[licznik_kart].podajImie(), rezerwacje[licznik_kart].pokazNazwisko(), rezerwacje[licznik_kart].pokazNr_tel(), rezerwacje[licznik_kart].podajKraj());
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
                string cena = loty[wybrany_lot].podaj_cene(karty[licznik_kart].czyBagaz(), karty[licznik_kart].czyPriority()).ToString();
                labelKwota.Text = cena;
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
            textNazwiskoZarz.Clear();
            textNrtelZarz.Clear();
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
            if (textNrKarty.Text.Length == 16 && textCVC.Text.Length == 3) 
            {
                int tymczasowa = licznik_kart - 1;
                karty[tymczasowa].potwierdzPlatnosc();
                panelPlatnosc.Hide();
                panelLoty.Show();
                textCVC.Clear();
                textNrKarty.Clear();

            }
            else MessageBox.Show("Wprowadzono błędne dane, spróbuj ponownie.");
        }

        private void przyciskSpr_Click(object sender, EventArgs e)
        {
            string Snazw = textNazwiskoZarz.Text;
            string Snr = textNrtelZarz.Text;

            for(int i = 0; i<licznik_kart;i++)
            {

                if (karty[i].pokazNazwisko() == Snazw && karty[i].pokazNr_tel() == Snr)
                {
                    numericZarz.Value = karty[i].pokaz_karte();


                    panelZarzadzaj.Hide();
                    panelKartaZarz.Show();

                    ktora_rezerwacja = i;
                    
                    if(karty[ktora_rezerwacja].czyBagaz() == true)
                    {
                        checkBagazZarezerw.Checked = true;
                    } else checkBagazZarezerw.Checked = false;

                    if (karty[ktora_rezerwacja].czyPriority() == true)
                    {
                        checkPriorityZarezerw.Checked = true;
                    } else checkPriorityZarezerw.Checked = false;

                    break;
                }

            }

           
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
            if (checkBagazZarezerw.Checked)
            {
                karty[ktora_rezerwacja].dodaj_bagaz();
            }

            if (checkPriorityZarezerw.Checked)
            {
                karty[ktora_rezerwacja].dodaj_priority();
            }

            if (loty[wybrany_lot].zajmij_miejsce((int)numericZarz.Value))
            {
                loty[wybrany_lot].zwolnij_miejsce(karty[ktora_rezerwacja].pokaz_karte());
                karty[ktora_rezerwacja].wybierz_miejsce((int)numericZarz.Value);

            }
           
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
                textWprowadzoneHaslo.Clear();
            }
        }

        private void przyciskUsunLot_Click(object sender, EventArgs e)
        {
            int dousuniecia = comboBoxAdmin.SelectedIndex;
            MessageBox.Show(dousuniecia.ToString());
            loty.RemoveAt(dousuniecia);
            tabelaLotow.Rows.RemoveAt(dousuniecia);
            tabelaLotowAdmin.Rows.RemoveAt(dousuniecia);
            liczba_lotow--;
        }

        private void przyciskAnulowanieRezerw_Click(object sender, EventArgs e)
        {

            panelAdminPanel.Hide();
            panelAnulowanie.Show();
            panelAnulowanie.BringToFront();
            
        }

        private void przyciskDodajLot_Click(object sender, EventArgs e)
        {
            panelAdminPanel.Hide();
            panelDodajLot.Show();
            panelDodajLot.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Anazw = textNazwiskoAnulacja.Text;
            string Anr = textNrtelAnulacja.Text;

            for (int j = 0; j < licznik_rezerwacji; j++)
            {

                if (rezerwacje[j].pokazNazwisko() == Anazw && rezerwacje[j].pokazNr_tel() == Anr)
                {
                    rezerwacje[j].anuluj();
                    MessageBox.Show("Pierwsza pętla");
                }
                else MessageBox.Show("Nie znaleziono takiej rezerwacji!");
            }

            for (int x = 0; x < licznik_kart; x++)
            {

                if (karty[x].pokazNazwisko() == Anazw && karty[x].pokazNr_tel() == Anr)
                {

                    admin1.anuluj_rezerwacje(karty[x]);
                    for (int k = 0; k < liczba_lotow; k++)
                    {
                        if (karty[x].podajNr_lotu() == loty[k].podaj_nr_lotu() && karty[x].podajDate_lotu() == loty[k].podaj_date())
                        {

                            loty[k].zwolnij_miejsce(karty[x].pokaz_karte());
                            MessageBox.Show("Zwolniono, anulowano");
                            
                            break;
                        }

                    }

                    textNazwiskoAnulacja.Clear();
                    textNrtelAnulacja.Clear();
                    panelAnulowanie.Hide();
                    panelAdminPanel.Show();
                    break;
                }

            }


        }

        private void przyciskDodaj2_Click(object sender, EventArgs e)
        {
            string Ddocelowe = textLotniskoDocelowe.Text;
            string DLotniskoWylotu = textLotniskoWylotu.Text;
            string Ddata = textDataLotu.Text;
            string Dnrlotu = textNrLotu.Text;
            string DgodzWylotu = textGodzinaWylotu.Text;
            string DgodzPrzylotu = textGodzinaPrzylotu.Text;

            loty.Insert(liczba_lotow, admin1.dodaj_lot(Ddocelowe, Dnrlotu, Ddata, DLotniskoWylotu));

            Dostepne_polaczenia poloczenie = new Dostepne_polaczenia(loty[liczba_lotow], DgodzWylotu, DgodzPrzylotu);
            pol.Add(poloczenie);

            tabelaLotow.Rows.Add(pol[liczba_lotow].podaj_lotnisko_wylotu(), pol[liczba_lotow].podaj_lotnisko_docelowe(), pol[liczba_lotow].podaj_godz_odlotu(), pol[liczba_lotow].podaj_godz_przylotu(), pol[liczba_lotow].podaj_date());
            tabelaLotowAdmin.Rows.Add(pol[liczba_lotow].podaj_lotnisko_wylotu(), pol[liczba_lotow].podaj_lotnisko_docelowe(), pol[liczba_lotow].podaj_godz_odlotu(), pol[liczba_lotow].podaj_godz_przylotu(), pol[liczba_lotow].podaj_date());

            liczba_lotow++;
            comboBox.Items.Add(liczba_lotow.ToString());
            
            comboBoxAdmin.Items.Add(liczba_lotow.ToString());

            

            panelDodajLot.Hide();
            panelAdminPanel.Show();

            textLotniskoDocelowe.Clear();
            textLotniskoDocelowe.Clear();
            textDataLotu.Clear();
            textNrLotu.Clear();
            textGodzinaWylotu.Clear();
            textGodzinaPrzylotu.Clear();
        }

     

        void zapisywanieLotow()
        {
            string pathLoty = "lotyplik.dat";

            FileInfo datFile = new FileInfo(pathLoty);

            BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());

            bw.Write(liczba_lotow);
            for (int i = 0; i<liczba_lotow;i++)
            {
                bw.Write(loty[i].wszystkie_miejsca());
                bw.Write(loty[i].wysw());
               
                bw.Write(loty[i].ile_miejsc());
                bw.Write(loty[i].lotnisko_docelowe); // publiczne!!!
                bw.Write(loty[i].podaj_nr_lotu()); 
                bw.Write(loty[i].podaj_date());  // publiczne!!
                bw.Write(loty[i].lotnisko_wylotu);

            }
            bw.Close();
        }

        void wczytywanieLotow()
        {
            string pathLoty = "lotyplik.dat";

            FileInfo datFile = new FileInfo(pathLoty);
            BinaryReader br = new BinaryReader(datFile.OpenRead());

            liczba_lotow = br.ReadInt32();

            for (int i = 0; i < liczba_lotow; i++)
            {
                int tempWszystkiemiejsca = br.ReadInt32();
                string tempNazwa = br.ReadString();
                int tempWolne = br.ReadInt32();
                string tempDocelowe = br.ReadString();
                string tempNrlotu = br.ReadString();
                string temp_data = br.ReadString();
                string tempWylotu = br.ReadString();
                Lot lot1 = new Lot(tempWszystkiemiejsca, tempNazwa, tempWolne, tempDocelowe, tempNrlotu,temp_data,tempWylotu );
                loty.Insert(i, lot1);

            }

            br.Close();

        }

        void zapisywaniePolaczen()
        {
            string pathLoty = "polaczeniaplik.dat";

            FileInfo datFile = new FileInfo(pathLoty);

            BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());

            for (int i=0;i<liczba_lotow;i++)
            {
                bw.Write(pol[i].podaj_godz_odlotu());
                bw.Write(pol[i].podaj_godz_przylotu());

            }

            bw.Close();
        }

        void wczytywaniePolaczen()
        {
            string pathLoty = "polaczeniaplik.dat";

            FileInfo datFile = new FileInfo(pathLoty);
            BinaryReader br = new BinaryReader(datFile.OpenRead());

            for (int i = 0; i < liczba_lotow; i++)
            {
                string temp_godz_odlt = br.ReadString();
                string temp_godz_przyl = br.ReadString();

                pol[i].wczytaj(temp_godz_odlt, temp_godz_przyl);
            }

            br.Close();
        }

        void zapisywanieRezerw()
        {
            string pathRezerw = "rezerwacjeplik.dat";

            FileInfo datFile = new FileInfo(pathRezerw);

            BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());

            bw.Write(licznik_rezerwacji);
            bw.Write(licznik_kart);


            for(int j=0; j<licznik_rezerwacji;j++)
            {
                bw.Write(rezerwacje[j].podajImie());
                bw.Write(rezerwacje[j].pokazNazwisko());
                bw.Write(rezerwacje[j].podajKraj());
                bw.Write(rezerwacje[j].pokazNr_tel());
                bw.Write(rezerwacje[j].podajNr_lotu());
                bw.Write(rezerwacje[j].podajDate_lotu());
                bw.Write(rezerwacje[j].czy_anulowana());
            }
            bw.Close();
        }

        void wczytywanieRezerw()
        {
            string pathRezerw = "rezerwacjeplik.dat";

            FileInfo datFile = new FileInfo(pathRezerw);
            BinaryReader br = new BinaryReader(datFile.OpenRead());

            licznik_rezerwacji = br.ReadInt32();
            licznik_kart = br.ReadInt32();

            for (int i=0; i<licznik_rezerwacji;i++)
            {
                string tempImie = br.ReadString();
                string tempNazwisko = br.ReadString();
                string tempKraj = br.ReadString();
                string tempNrtel = br.ReadString();
                string tempNrlotu = br.ReadString();
                string tempData = br.ReadString();
                bool tempAnulowana = br.ReadBoolean();

                Rezerwacje rez1 = new Rezerwacje(tempNrlotu,tempData,tempImie,tempNazwisko, tempNrtel,tempKraj,tempAnulowana); 
                rezerwacje.Insert(i,rez1);
            }

            br.Close();
            
        }

        void zapisywanieKart()
        {
            string pathKarty = "kartyplik.dat";

            FileInfo datFile = new FileInfo(pathKarty);

            BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());

            for(int i=0;i<licznik_kart;i++)
            {
                bw.Write(karty[i].podajImie());
                bw.Write(karty[i].pokazNazwisko());
                bw.Write(karty[i].podajKraj());
                bw.Write(karty[i].pokazNr_tel());
                bw.Write(karty[i].podajNr_lotu());
                bw.Write(karty[i].podajDate_lotu());
                bw.Write(karty[i].czy_anulowana());
                bw.Write(karty[i].czyPriority());
                bw.Write(karty[i].czyBagaz());
                bw.Write(karty[i].pokaz_karte());
                bw.Write(karty[i].podaj_status_platnosci());
            }
            bw.Close();

        }

        void wczytywanieKart()
        {
            string pathKarty = "kartyplik.dat";

            FileInfo datFile = new FileInfo(pathKarty);
            BinaryReader br = new BinaryReader(datFile.OpenRead());

            for(int i = 0; i< licznik_kart; i++)
            {
                string tempImie = br.ReadString();
                string tempNazwisko = br.ReadString();
                string tempKraj = br.ReadString();
                string tempNrtel = br.ReadString();
                string tempNrlotu = br.ReadString();
                string tempData = br.ReadString();
                bool tempAnulowana = br.ReadBoolean();

                bool tempPriority = br.ReadBoolean();
                bool tempBagaz = br.ReadBoolean();
                int tempNr_miejsca = br.ReadInt32();
                bool tempStatus = br.ReadBoolean();

                Karta_pokladowa k1 = new Karta_pokladowa(tempNrlotu, tempData, tempImie, tempNazwisko, tempNrtel, tempNr_miejsca, tempKraj, tempAnulowana,tempBagaz,tempPriority, tempStatus);
                karty.Insert(i, k1);


                for (int k = 0; k < liczba_lotow; k++)
                {

                    if (karty[i].podajNr_lotu() == loty[k].podaj_nr_lotu() && karty[i].podajDate_lotu() == loty[k].podaj_date() && karty[i].czy_anulowana() == false)
                    {
                        //  qDebug()<<"Znaleziono zgodność"<<karty[i].pokaz_karte();
                        MessageBox.Show(karty[i].pokazNazwisko());
                        loty[k].zajmij_miejsce(karty[i].pokaz_karte());
                    }
                }

            }



            br.Close();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            zapisywanieLotow();
            zapisywaniePolaczen();
            zapisywanieRezerw();
            zapisywanieKart();
        }

      
    }
}
