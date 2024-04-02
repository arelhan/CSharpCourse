using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_TYPES_AND_VARIABLES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First Hello World App
            Console.WriteLine("Hello World!");

            //Value Types

            //int 
            Console.WriteLine("İnteger veri tipi {0} ila {1} sayıları arasında değer alabilir.", int.MinValue, int.MaxValue);

            //long
            Console.WriteLine("Long veri tipi {0} ila {1} sayıları arasında değer alabilir.", long.MinValue, long.MaxValue);

            //short
            Console.WriteLine("Short veri tipi {0} ila {1} sayıları arasında değer alabilir.", short.MinValue, short.MaxValue);

            //byte
            Console.WriteLine("Byte veri tipi {0} ila {1} sayıları arasında değer alabilir.", byte.MinValue, byte.MaxValue);

            //bool
            Console.WriteLine("Bool veri tipi {0} ile {1} arasında veya 0 ile 1 arasında değer alabilir", bool.TrueString, bool.FalseString);

            //char
            Console.WriteLine("Char veri tipi sadece 1 karakter alabilir.");

            //float
            Console.WriteLine("Float veri tipi {0} ila {1} sayıları arasında değer alabilir.", float.MinValue, float.MaxValue);

            //double
            Console.WriteLine("Double veri tipi {0} ila {1} sayıları arasında değer alabilir.", double.MinValue, double.MaxValue);

            //Decimal
            Console.WriteLine("Decimal veri tipi {0} ila {1} sayıları arasında değer alabilir.", decimal.MinValue, decimal.MaxValue);

            //Enum 
            Console.WriteLine("Enumlar Genellikle sayılabilir tipleri temsil etmek için kullanılırlar. Örneğin, haftanın günleri, ay isimleri, renkler gibi. ");

            //var
            Console.WriteLine("var veri tipi değişkenin değerinden otomatik olarak türünü çıkartmak için kullanılır.");
            Console.ReadLine();
        }
    }
}
