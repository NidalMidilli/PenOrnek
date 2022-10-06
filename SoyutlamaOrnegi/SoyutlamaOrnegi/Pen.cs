using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoyutlamaOrnegi
{
    internal abstract class Pen
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        // Hem abstract ile hemde virtual ile override işlemi gerçekleştirebiliyoruz.
        public abstract string Write();
        public virtual string Erase()
        {
            return "Erase";
        }

    }
}
