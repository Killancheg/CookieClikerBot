using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClickerBot.ProcessTypes
{
    class ComboBoxWindows
    {
        public string Name { get; set; }

        public IntPtr ID { get; set; }

        public int Numeration { get; set; }

        public ComboBoxWindows(string name, IntPtr id, int numeration)
        {
            Name = name;
            ID = id;
            Numeration = numeration;
        }

        public override string ToString()
        {
            if (Numeration == 1)
            {
                return Name;
            }
            else
            {
                string strNumeration = $"({Numeration})";
                return Name + strNumeration;
            }
        }

    }
}
