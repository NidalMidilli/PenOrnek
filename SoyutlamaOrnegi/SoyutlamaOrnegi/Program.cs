using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoyutlamaOrnegi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EyePen eyePen = new EyePen();
            eyePen.Brand = "Flormar";
            eyePen.Thickness = 1;
            eyePen.Color = "Black";
            eyePen.DoesHaveBrush = false;
            eyePen.IsWaterBased = true;
            Console.WriteLine(eyePen.Write());
            BoardPen boardPen = new BoardPen();
            boardPen.Brand = "Globox";
            boardPen.CanRefill = true;
            boardPen.Color = "Red";
            Console.WriteLine(boardPen.Write());
            Console.ReadKey();
            /* Pen pen = new MechanicalPencil();
            pen.Brand = "Faber Castell";
            pen.Color = "Pink";
            Console.WriteLine(pen.Write());
            Console.ReadKey();*/
        }
    }
}
