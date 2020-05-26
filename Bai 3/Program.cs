using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.Write("nhap toa do x : ");
            x = Int32.Parse(Console.ReadLine());
            Console.Write("nhap toa do y : ");
            y = Int32.Parse(Console.ReadLine());
            if (x == 0 && y == 0) { Console.WriteLine(" diem nam o goc toa do"); }
            if (x != 0 && y == 0) { Console.WriteLine(" diem do thuoc truc hoang"); }
            if (x == 0 && y != 0) { Console.WriteLine(" diem do thuoc truc tung"); }
            if (x > 0 && y > 0) { Console.WriteLine(" diem do thuoc goc Q1"); }
            if (x < 0 && y > 0) { Console.WriteLine(" diem do thuoc goc Q2"); }
            if (x < 0 && y < 0) { Console.WriteLine(" diem do thuoc goc Q3"); }
            if (x > 0 && y < 0) { Console.WriteLine(" diem do thuoc goc Q4"); }
        }
    }
}
