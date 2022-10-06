using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoyutlamaOrnegi
{
    internal class BoardPen : Pen
    {
        public bool CanRefill { get; set; }
        public override string Write()
        {
            return "I am a board pen!";
        }
    }
}
