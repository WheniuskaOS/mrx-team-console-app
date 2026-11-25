using System;
using MrxTeamConsoleApp.Bolumler.MiniOyunlar;

namespace MrxTeamConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Konsol penceresinin üst başlığını değiştirelim
            Console.Title = "MRX - TEAM";

            //Programın sürekli dönmesi için bir değişken tanımılıyoruz
            bool programCalisiyor = true;

            while (programCalisiyor)
            {
                // Her düngü başında ekranı temizleyelim ki menü üst üste binmesin
                Console.Clear();

                // Karşılama Ekranı
                Console.WriteLine("========================================");
                Console.WriteLine("MRX - TEAM Konsol Uygulamasına Hoş Geldin!");
                Console.WriteLine("========================================");
                Console.WriteLine();
                Console.WriteLine("Lütfen yapmak istediğin işlem için bir sayı tuşla:");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("[1] - Mini Oyun - Sayı Tahmin Oyunu Oyna");
                Console.WriteLine("[2] - Mini Oyun - Taş Kağıt Makas Oyunu Oyna");
                Console.WriteLine("[0] - Çıkış");
                Console.WriteLine("----------------------------------------------------------------");

                Console.Write("Seçiminiz: ");
                var secim = Console.ReadLine()?.Trim(); // Görseldeki gibi Trim() ekleyerek boşlukları temizleyelim

                switch (secim)
                {
                    case "1":
                        Sayi_Tahmin.Calistir(); // Sadece çağırıyoruz, tertemiz!
                        break;

                    case "2":
                        Tas_Kagit_Makas.Calistir();
                        break;

                    case "0":
                        Console.WriteLine("\nÇıkış yapılıyor... İyi günler dilerim! 👋");
                        programCalisiyor = false; // veya görseldeki gibi direkt 'return:' ile de bitirebilirsin
                        break;
                    
                    default:
                        Console.WriteLine("\nGeçersiz seçim. Devam etmek için Enter");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}