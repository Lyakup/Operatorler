using System;

namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Atama ve İşlemli Atama");
  
            int x = 5;
            int y = 10;

            y = y + 2;
            Console.WriteLine(y);
            
            x += y;
            Console.WriteLine(x);

            y /= 1;
            Console.WriteLine(y);
            x *= 4;


            Console.WriteLine("*****Mantıksal Operatörler");
            // && || !
            bool isSucces = true;
            bool isCompleted = true;

            if(isSucces && isCompleted)
                Console.WriteLine("Perfect");

            if (isSucces || isCompleted)
                Console.WriteLine("Fine");

            if (isSucces && !isCompleted)
                Console.WriteLine("Great");


            Console.WriteLine("*****İlişkisel Operatörler");
            // <,> ,<= ,>= ,== ,!=
            int a = 3;
            int b = 5;

            bool sonuc = a > b;
            Console.WriteLine(sonuc);
            
            sonuc = a < b;
            Console.WriteLine(sonuc);

            sonuc = a <= b;
            Console.WriteLine(sonuc);

            sonuc = a >= b;
            Console.WriteLine(sonuc);

            sonuc = a == b;
            Console.WriteLine(sonuc);

            sonuc = a != b;
            Console.WriteLine(sonuc);


            Console.WriteLine("*****Aritmatik Operatörler");
            int sayi1 = 10;
            int sayi2 = 3;
            int deger = sayi1 / sayi2;
            Console.WriteLine(deger);

            deger = sayi2++;
            Console.WriteLine(deger);
            deger = sayi1--;
            Console.WriteLine(deger);

            deger = sayi1 + sayi2;
            Console.WriteLine(deger);

            // Mod Alma %
            int mod = 20 % 3;
            Console.WriteLine(mod);
        }
    }
}
