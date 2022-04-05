using System;

namespace diziler_array_sinifi_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
           //Sort
           int [] sayiDizisi = {23,21,4,86,72,3,11,17};
           Console.WriteLine("*****Sırasız Dizi*****");
           foreach (var sayi in sayiDizisi)
               Console.WriteLine(sayi);

           Console.WriteLine("*****Sıralı Dizi*****");
           Array.Sort(sayiDizisi);
           foreach (var sayi in sayiDizisi)
               Console.WriteLine(sayi);
           
           //Clear
           Console.WriteLine("*****Array Clear*****");
           //sayı dizisi elemanlarını kullanarak 2.index den başlayarak 2 tane elemanı 0'lar.
           Array.Clear(sayiDizisi,2,2);
           foreach (var sayi in sayiDizisi)
               Console.WriteLine(sayi);

            Console.WriteLine("*****Array Reverse*****");
            //Reverse
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
               Console.WriteLine(sayi);

            //indexOf
            Console.WriteLine("*****Array İndexOf*****");
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            //Resize
            Console.WriteLine("*****Resize İndexOf*****");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8]=99;
            foreach (var sayi in sayiDizisi)
               Console.WriteLine(sayi);



        }
    }
}
