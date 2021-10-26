using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClickerBot.ProcessTypes
{
    class ComboBoxProcess
    {
        private string name;

        private int ID { get; set; }

        public ComboBoxProcess(string name, int id)
        {
            this.name = name;
            ID = id;
        }

        public override string ToString()
        {
            return name;
        }

    }
}
