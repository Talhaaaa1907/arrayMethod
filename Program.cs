using System;

namespace arrayMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayiDizisi = { 12, 68, 54, 17, 98, 8, 76 };

            Console.WriteLine("****** Sırasız Liste ******");
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("****** Sıralı Liste ******");
            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);


            //Clear
            Console.WriteLine("****** Array Clear ******");
            //sayı dizisi elemanlarını kullanarak 2.ci indexten itibaren 2 elemanı sıfırlar.
            Array.Clear(sayiDizisi, 2, 2);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);


            //Reverse
            Console.WriteLine("****** Array Reverse ******");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);


            //IndexOf
            Console.WriteLine("****** Array IndexOf ******");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 12));


            //Resize
            Console.WriteLine("****** Array Resize ******");
            Array.Resize<int>(ref sayiDizisi, 8);
            sayiDizisi[7] = 99;
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
        }
    }
}
