using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp33
{
    class GameSettings
    {
        public int CzasGry;
        public int CzasPodglądu;
        public int MaxPunkty;
        public int Wiersze;
        public int Kolumny;
        public int Bok;
        public int Aktualnepunkty;
        public string Pliklogo = $@"{AppDomain.CurrentDomain.BaseDirectory}\img\logo.jpg";
        public string FolderObrazki = $@"{AppDomain.CurrentDomain.BaseDirectory}\img\memory";

        public GameSettings ()
        {
            UstawStartowe();
        }
        public void UstawStartowe()
        {
            CzasGry = 60;
            CzasPodglądu = 5;
            MaxPunkty = 0;

        }
    }
}
