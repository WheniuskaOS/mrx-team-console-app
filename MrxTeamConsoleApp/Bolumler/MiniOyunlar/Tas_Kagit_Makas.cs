using System;

namespace MrxTeamConsoleApp.Bolumler.MiniOyunlar
{
    public class Tas_Kagit_Makas
    {
        public static void Calistir()
        {
            // Bilgisayarın rastgele seçim yapabilmesi için dizimizi ve random nesnemizi kuruyoruz
            string[] secenekler = { "Taş", "Kağıt", "Makas" };
            Random random = new Random();

            Console.Clear();
            Console.WriteLine("=== TAŞ KAĞIT MAKAS OYUNUNA HOŞ GELDİN! ===");
            Console.WriteLine("3 puana ulaşan oyunu kazanır!");
            Console.WriteLine("------------------------------------------");

            int oyuncuSkor = 0;
            int bilgisayarSkor = 0;

            // Taraflardan biri 3 puana ulaşana kadar oyun dönecek
            while (oyuncuSkor < 3 && bilgisayarSkor < 3)
            {
                Console.WriteLine($"\n[Skor] Oyuncu: {oyuncuSkor} | Bilgisayar: {bilgisayarSkor}");
                Console.WriteLine("Lütfen birini seç: [1] Taş | [2] Kağıt | [3] Makas");
                Console.Write("Seçiminiz: ");

                string? girdi = Console.ReadLine();
                if (girdi != "1" && girdi != "2" && girdi != "3")
                {
                    Console.WriteLine("Geçersiz seçim. Lütfen 1, 2 veya 3 yaz.");
                    continue; // Döngüyü başa sarar. skoru veya eli işletmez
                }

                // Kullanıcının girdisini dizi indeksine çeviriyoruz (1 girdiyse 0. indeks yani Taş)
                int oyuncuIndeks = int.Parse(girdi) - 1;
                string oyuncuSecimi = secenekler[oyuncuIndeks];

                // Bilgisayar rastgele seçiyor (0, 1 veya 2)
                int bilgisayarIndeks = random.Next(0, 3);
                string bilgisayarSecimi = secenekler[bilgisayarIndeks];

                Console.WriteLine($"\nSenin Seçimin: {oyuncuSecimi}");
                Console.WriteLine($"Bilgisayarın Seçimi: {bilgisayarSecimi}");

                // Kazanma / Kaybetme Mantığı Kontrolü
                if (oyuncuSecimi == bilgisayarSecimi)
                {
                    Console.WriteLine("Berabere! Bu elde puan yok.");
                }
                else if ((oyuncuSecimi == "Taş" && bilgisayarSecimi == "Makas") ||
                         (oyuncuSecimi == "Kağıt" && bilgisayarSecimi == "Taş") ||
                         (oyuncuSecimi == "Makas" && bilgisayarSecimi == "Kağıt"))
                {
                    Console.WriteLine("Bu eli sen kazandın! 🎯");
                    oyuncuSkor++;
                }
                else
                {
                    Console.WriteLine("Bu eli bilgisayar kazandı! 🤖");
                    bilgisayarSkor++;
                }
            }

            // Döngü bittiğine göre biri 3 puana ulaştı demektir
            Console.WriteLine("\n==========================================");
            if (oyuncuSkor == 3)
            {
                Console.WriteLine("TEBRİKLER! OYUNU SEN KAZANDIN! 🏆🎉");
            }
            else
            {
                Console.WriteLine("OYUNU BİLGİSAYAR KAZANDI! 🤖 Elden gelen bir şey yok.");
            }
            Console.WriteLine("==========================================");

            Console.WriteLine("\nAna menüye dönmek için Enter'e bas...");
            Console.ReadLine();
        }
    }
}