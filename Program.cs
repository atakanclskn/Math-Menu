//@atakanclskn 14 March 2024
using System;
using System.Collections.Generic;

namespace Math_Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secim;
            do
            {
                Console.WriteLine("<<< Lütfen Aşağıda Yapmak İstediğiniz İşlemi Seçiniz >>>");
                Console.WriteLine("[1] İki sayının toplanması (a+b)");
                Console.WriteLine("[2] İki sayının çıkarılması (a-b)");
                Console.WriteLine("[3] İki sayının birbirine bölünmesi (a/b)");
                Console.WriteLine("[4] İki sayının birbiriyle çarpılması (a*b)");
                Console.WriteLine("[5] Girilen sayıya kadarki asal sayıların listelenmesi (a)");
                Console.WriteLine("[6] Girilen sayıya kadarki tek sayıların listelenmesi (a)");
                Console.WriteLine("[7] Girilen sayının faktöriyelinin alınması");
                Console.WriteLine("[0] Çıkış");

                Console.Write("Seçiminiz: ");
                secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        Console.Write("Birinci sayıyı girin: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("İkinci sayıyı girin: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Toplam: {a + b}");
                        break;

                    case 2:
                        Console.Write("Birinci sayıyı girin: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("İkinci sayıyı girin: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Fark: {a - b}");
                        break;

                    case 3:
                        Console.Write("Birinci sayıyı girin: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("İkinci sayıyı girin: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        if (b == 0)
                            Console.WriteLine("Bir sayı sıfıra bölünemez!");
                        else
                            Console.WriteLine($"Bölüm: {(double)a / b}");
                        break;

                    case 4:
                        Console.Write("Birinci sayıyı girin: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("İkinci sayıyı girin: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Çarpım: {a * b}");
                        break;

                    case 5:
                        Console.Write("Bir sayı girin: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{a}'e kadarki asal sayılar:");
                        for (int i = 2; i <= a; i++)
                            if (AsalMi(i)) Console.Write(i + " ");
                        Console.WriteLine();
                        break;

                    case 6:
                        Console.Write("Bir sayı girin: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{a}'e kadarki tek sayılar:");
                        for (int i = 1; i <= a; i += 2)
                            Console.Write(i + " ");
                        Console.WriteLine();
                        break;

                    case 7:
                        Console.Write("Bir sayı girin: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{a}! = {Faktoriyel(a)}");
                        break;
                }
                Console.WriteLine();

            } while (secim != 0);
        }

        static bool AsalMi(int sayi)
        {
            if (sayi < 2) return false;
            for (int i = 2; i <= Math.Sqrt(sayi); i++)
                if (sayi % i == 0) return false;
            return true;
        }

        static long Faktoriyel(int sayi)
        {
            long sonuc = 1;
            for (int i = 1; i <= sayi; i++)
                sonuc *= i;
            return sonuc;
        }
    }
}
