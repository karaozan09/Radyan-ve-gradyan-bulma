using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haftaucaltıncıkısım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Derece degerini giriniz");
            int derece = Convert.ToInt32(Console.ReadLine());
            double radyan = derece * Math.PI / 180;
            double gradyan = derece * 200 / 180;
            Console.WriteLine("derecenın radyan degeri=" + radyan);
            Console.WriteLine("derecenin gradyan degeri=" + gradyan);
            Console.ReadKey();
        }
    }
}
