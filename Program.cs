using System;

namespace karar_yapilari_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi tanımlama

            string[] renkler = new string[5]; // Dizi tanımlama eleman vermeden
            string[] hayvanlar = {"Aslan","Kuş","Maymun","Kaplan"}; // Diziyi tanımlarken elemanlarınıda verme.

            int[] dizi;
            dizi = new int[5];

            //Dizilere Değer Atama ve Erişim

            renkler[0] = "mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[3]);
            Console.WriteLine(renkler[0]);
            Console.WriteLine(dizi[3]);
            
            //Döngülerle dizi kullanımı
            //Consoledan girilen n tane sayının ortalamasını hesaplayan program
            Console.Write("Dizinin eleman sayısı kaç lütfen giriniz: ");
            int dizininElemanSayisi = int.Parse(Console.ReadLine());
            
            int [] sayiDizisi = new int[dizininElemanSayisi];

            for (int i = 0; i < dizininElemanSayisi; i++)
            {
                Console.Write("Lütfen {0}. Sayıyı Giriniz: ",i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int sayac = 1;
            int toplam = 0;
            foreach (var sayi in sayiDizisi) // Dizi elemanlarını döner
            {
                toplam += sayi;
                Console.WriteLine("Dizinin {0}.elemanı: {1}",sayac,sayi);
                sayac++;
            }

            Console.WriteLine("Dizideki elemanların toplamı: {0}",toplam); // Dizi elemanlarının toplamı 
            Console.WriteLine("Dizideki elemanların ortalaması: {0}",toplam/dizininElemanSayisi); // Dizi eleman ort.
        }
    }
}

