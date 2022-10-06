using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoyutlamaOrnegi
{
    internal class MechanicalPencil : Pen
    {
        public decimal LineWidth { get; set; }
        public override string Write()
        {
            return "I am a Mechanical Pencil";
        }
    }
}
