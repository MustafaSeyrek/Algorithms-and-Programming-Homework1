using System;

namespace hmw1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rnd1 = rnd.Next(1, 4);//1. bölmenin rengini belirliyor.Eğer 1 gelirse kırmızıya, 2 gelirse maviye ,3 gelirse yeşile karşılık geliyor.
            int rnd2 = rnd.Next(1, 4);//2. bölmenin rengini belirliyor.Eğer 1 gelirse kırmızıya, 2 gelirse maviye ,3 gelirse yeşile karşılık geliyor.
            int rnd3 = rnd.Next(1, 4);//3. bölmenin rengini belirliyor.Eğer 1 gelirse kırmızıya, 2 gelirse maviye ,3 gelirse yeşile karşılık geliyor.
            int rnd4 = rnd.Next(4, 9);//1. bölmenin harfini belirliyor.4=A, 5=B, 6=C, 7=D, 8=E harflerine karşılık geliyor.
            int rnd5 = rnd.Next(4, 9);//2. bölmenin harfini belirliyor.4=A, 5=B, 6=C, 7=D, 8=E harflerine karşılık geliyor.
            int rnd6 = rnd.Next(4, 9);//3. bölmenin harfini belirliyor.4=A, 5=B, 6=C, 7=D, 8=E harflerine karşılık geliyor.

            //1. bölmenin renk ve harfleri           
            Console.ForegroundColor = ConsoleColor.Red;
            if (rnd1 == 1 && rnd4 == 4)
                Console.Write(" A");
            else if (rnd1 == 1 && rnd4 == 5)
                Console.Write(" B");
            else if (rnd1 == 1 && rnd4 == 6)
                Console.Write(" C");
            else if (rnd1 == 1 && rnd4 == 7)
                Console.Write(" D");
            else if (rnd1 == 1 && rnd4 == 8)
                Console.Write(" E");
            Console.ForegroundColor = ConsoleColor.Blue;
              if (rnd1 == 2 && rnd4 == 4)
                Console.Write(" A");
            else if (rnd1 == 2 && rnd4 == 5)
                Console.Write(" B");
            else if (rnd1 == 2 && rnd4 == 6)
                Console.Write(" C");
            else if (rnd1 == 2 && rnd4 == 7)
                Console.Write(" D");
            else if (rnd1 == 2 && rnd4 == 8)
                Console.Write(" E");
            Console.ForegroundColor = ConsoleColor.Green;
             if (rnd1 == 3 && rnd4 == 4)
                Console.Write(" A");
            else if (rnd1 == 3 && rnd4 == 5)
                Console.Write(" B");
            else if (rnd1 == 3 && rnd4 == 6)
                Console.Write(" C");
            else if (rnd1 == 3 && rnd4 == 7)
                Console.Write(" D");
            else if (rnd1 == 3 && rnd4 == 8)
                Console.Write(" E");

            //2. bölmenin renk ve harfleri
            Console.ForegroundColor = ConsoleColor.Red;
            if (rnd2 == 1 && rnd5 == 4)
                Console.Write(" A");
            else if (rnd2 == 1 && rnd5 == 5)
                Console.Write(" B");
            else if (rnd2 == 1 && rnd5 == 6)
                Console.Write(" C");
            else if (rnd2 == 1 && rnd5 == 7)
                Console.Write(" D");
            else if (rnd2 == 1 && rnd5 == 8)
                Console.Write(" E");
            Console.ForegroundColor = ConsoleColor.Blue;
            if (rnd2 == 2 && rnd5 == 4)
                Console.Write(" A");
            else if (rnd2 == 2 && rnd5 == 5)
                Console.Write(" B");
            else if (rnd2 == 2 && rnd5 == 6)
                Console.Write(" C");
            else if (rnd2 == 2 && rnd5 == 7)
                Console.Write(" D");
            else if (rnd2 == 2 && rnd5 == 8)
                Console.Write(" E");
            Console.ForegroundColor = ConsoleColor.Green;
             if (rnd2 == 3 && rnd5 == 4)
                Console.Write(" A");
            else if (rnd2 == 3 && rnd5 == 5)
                Console.Write(" B");
            else if (rnd2 == 3 && rnd5 == 6)
                Console.Write(" C");
            else if (rnd2 == 3 && rnd5 == 7)
                Console.Write(" D");
            else if (rnd2 == 3 && rnd5 == 8)
                Console.Write(" E");

            //3.bölmenin renk ve harfleri
            Console.ForegroundColor = ConsoleColor.Red;
            if (rnd3 == 1 && rnd6 == 4)
                Console.Write(" A");
            else if (rnd3 == 1 && rnd6 == 5)
                Console.Write(" B");
            else if (rnd3 == 1 && rnd6 == 6)
                Console.Write(" C");
            else if (rnd3 == 1 && rnd6 == 7)
                Console.Write(" D");
            else if (rnd3 == 1 && rnd6 == 8)
                Console.Write(" E");
            Console.ForegroundColor = ConsoleColor.Blue;
             if (rnd3 == 2 && rnd6 == 4)
                Console.Write(" A");
            else if (rnd3 == 2 && rnd6 == 5)
                Console.Write(" B");
            else if (rnd3 == 2 && rnd6 == 6)
                Console.Write(" C");
            else if (rnd3 == 2 && rnd6 == 7)
                Console.Write(" D");
            else if (rnd3 == 2 && rnd6 == 8)
                Console.Write(" E");
            Console.ForegroundColor = ConsoleColor.Green;
             if (rnd3 == 3 && rnd6 == 4)
                Console.Write(" A");
            else if (rnd3 == 3 && rnd6 == 5)
                Console.Write(" B");
            else if (rnd3 == 3 && rnd6 == 6)
                Console.Write(" C");
            else if (rnd3 == 3 && rnd6 == 7)
                Console.Write(" D");
            else if (rnd3 == 3 && rnd6 == 8)
                Console.Write(" E");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            //kontroller
            if (rnd4 == rnd5 && rnd5 == rnd6)//aynı harf olma durumu
            {
                if (rnd1 == rnd2 && rnd2 == rnd3)//aynı renk
                    Console.WriteLine("Win 22 $");
                else if (rnd1 != rnd2 && rnd2 != rnd3 && rnd1 != rnd3)//farklı renk
                    Console.WriteLine("Win 20 $");
                else
                    Console.WriteLine("Win 18 $");
            }

            else if (((rnd5 - rnd4 == 1) && (rnd6 - rnd5 == 1)) || ((rnd4 - rnd5 == 1) && (rnd5 - rnd6 == 1)) || ((rnd6-rnd4==1) && (rnd4-rnd5==1)) || ((rnd5-rnd6==1) && (rnd6-rnd4==1)) || ((rnd5-rnd4==1) && (rnd4-rnd6==1)) || ((rnd4-rnd6==1) && (rnd6-rnd5==1)))//ardısık harf olma durumu
            {
                if (rnd1 == rnd2 && rnd2 == rnd3)//aynı renk
                    Console.WriteLine("Win 16 $");

                else if (rnd1 != rnd2 && rnd2 != rnd3 && rnd1 != rnd3)//farklı renk
                    Console.WriteLine("Win 14 $");
                else
                    Console.WriteLine("Win 12 $");
            }

            else if (((rnd4 != rnd5) && (rnd5 != rnd6) && (rnd4 != rnd6)) && ((rnd5 - rnd4 != 1) && (rnd6 - rnd5 != 1)) || ((rnd4 - rnd5 != 1) && (rnd5 - rnd6 != 1)))
            {
                if ((rnd1 == rnd2 && rnd2 == rnd3))//aynı renk 
                    Console.WriteLine("Win 10 $");

               else if (rnd1 != rnd2 && rnd2 != rnd3 && rnd1 != rnd3)//farklı renk
                    Console.WriteLine("Win 8 $");

                else
                    Console.WriteLine("Win 0 $");
            }
           
            else
                Console.WriteLine("Win 0 $");

            Console.ReadLine();
        }
    }
}