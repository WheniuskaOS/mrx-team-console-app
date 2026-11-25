using System;

namespace MrxTeamConsoleApp.Bolumler.MiniOyunlar
{
    public class Sayi_Tahmin
    {
        public static void Calistir()
        {
            Random rastgele = new Random(); 
            int bilgisayarinSayisi = rastgele.Next(1, 101); // 1 ile 100 arasında tutar
            int kullaniciTahmini = 0;
            int tahminSayaci = 0;

            Console.Clear();
            Console.WriteLine(" === SAYI TAHMİN OYUNUNA HOŞ GELDİN! ===");
            Console.WriteLine("1 ile 100 arasında bir sayı tuttum. Hadi tahmin et!");
            Console.WriteLine("------------------------------------------------");

            while (kullaniciTahmini != bilgisayarinSayisi)
            {
                Console.Write("Tahmininiz: ");
                string? girdi = Console.ReadLine();
                if (string.IsNullOrEmpty(girdi)) girdi = "0"; // Boş basılınca hata vermesin

                kullaniciTahmini = int.Parse(girdi);
                tahminSayaci++;

                if (kullaniciTahmini < bilgisayarinSayisi)
                    Console.WriteLine("Daha BÜYÜK bir sayı söyle! ⬆️");
                else if (kullaniciTahmini > bilgisayarinSayisi)
                    Console.WriteLine("Daha KÜÇÜK bir sayı söyle! ⬇️");
            }

            Console.WriteLine($"\nTebrikler! {tahminSayaci}. Denemede doğru sayıyı ({bilgisayarinSayisi}) buldun! 🎉");
            Console.WriteLine("\nAna menüye dönmek için Enter'e bas...");
            Console.ReadLine();
        }
    }
}