using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp33
{
    class MemoryGame : Label
    {
        public Image Tyl;
        public Image Obrazek;
        public Guid ID;
        public MemoryCard (Guid id, string Tyl, string Obrazek)
        {
            ID = id;
            Tyl = Image.FromFile(Tyl);
            Obrazek = Image.FromFile(Obrazek);
        }
        public void zakryj()
        {

        }
        public void odkryj()
        {

        }
    }
}
