using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClickerBot.ProcessTypes
{
    class ComboBoxWindow
    {
        public string Name { get; set; }

        public IntPtr ID { get; set; }

        public int Numeration { get; set; }

        public ComboBoxWindow(string name, IntPtr id, int numeration)
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
