using System;

namespace HesapMakinesi_denemeProje_1
{
                 // İLK DENEMEM VE METODLARI KULLANARAK KENDİME HESAP MAKİNESİ YAPTIM
                                                                  
                                                      // TABİKİ EKSİKLERİM VAR AMA GELİŞTİRMEYE DEVAM..
    internal class Program
    {
        static void Main(string[] args)
        {
            int şart = 1;
            while (şart > 0)
            {
                Console.WriteLine("=================");
                Console.WriteLine("+ -> Toplama İşlemi");
                Console.WriteLine("- -> Çıkartma İşlemi");
                Console.WriteLine("* -> Çarpma İşlemi");
                Console.WriteLine("/ -> Bölme İşlemi");
                Console.WriteLine("-----------------");
                Console.WriteLine("1 -> Üslü Sayı Hesaplama");
                Console.WriteLine("2 -> Faktöriyel Hesaplama");
                Console.WriteLine("3 -> Mod Alma");
                Console.WriteLine("4 -> Dikdörtgen Alan ve Çevre Hesabı");
                Console.WriteLine("x -> Çıkış Yap");
                Console.WriteLine("-----------------");
                Console.Write(">>> Yapmak İstediğiniz İşlemi girin : ");
                string secim = Console.ReadLine();

                if (secim == "+")
                {
                    Console.Write("1. Sayı : ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("2. Sayı : ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    Sum(a, b);
                }
                else if (secim == "-")
                {
                    Console.Write("1. Sayı : ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("2. Sayı : ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    Remove(a, b);
                }
                else if (secim == "*")
                {
                    Console.Write("1. Sayı : ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("2. Sayı : ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    Hit(a, b);
                }
                else if (secim == "/")
                {
                    Console.Write("1. Sayı : ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("2. Sayı : ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    Plenty(a, b);
                }
                else if (secim == "1") // üslü sayı hesapla
                {
                    Console.Write("Taban sayısı : ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Üssü : ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    Usalma(a, b);

                }
                else if (secim == "2") // faktöriyel hesapla
                {
                    Console.Write("Faktöriyeli alınacak sayıyı girin: ");
                    int sayi = Convert.ToInt32(Console.ReadLine());

                    if (sayi < 0)
                    {
                        Console.WriteLine("Negatif sayıların faktöriyeli hesaplanamaz.");
                        return;
                    }

                    long faktoriyel = 1;

                    for (int i = 1; i <= sayi; i++)
                    {
                        faktoriyel *= i;
                    }

                    Console.WriteLine("faktöriyeli : " + faktoriyel);
                }
                else if (secim == "3") // mod alma 
                {
                    Console.Write("Bölüneni girin : ");
                    int bolunen = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Böleni girin : ");
                    int bolen = Convert.ToInt32(Console.ReadLine());
                    int bolum = Math.DivRem(bolunen, bolen, out int kalan);
                    Console.WriteLine($"Bölüm: {bolum}, Kalan: {kalan}");
                }
                else if (secim == "4") // dikdörtgen alan ve çevre hesapla
                {
                    Console.WriteLine("a -> Alan Hesabı");
                    Console.WriteLine("ç -> Çevre Hesabı");
                    Console.WriteLine("-----------------");
                    Console.Write("Hangi İşlem Yapılacak : ");
                    string secim2 =Console.ReadLine();

                    if (secim2 == "a")
                    {
                        Console.Write("Uzun Kenarı Girin : ");
                        double uk = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Kısa Kenarı Girin : ");
                        double kk = Convert.ToDouble(Console.ReadLine());

                        double alan = uk * kk;
                        Console.WriteLine("Dikdörtgenin Alanı : " + alan);
                    }
                    else if (secim2 == "ç")
                    {
                        Console.Write("Uzun Kenarı Girin : ");
                        double uk = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Kısa Kenarı Girin : ");
                        double kk = Convert.ToDouble(Console.ReadLine());

                        double Çevre = (uk + kk)*2;
                        Console.WriteLine("Dikdörtgenin Çevresi : " + Çevre);
                    }
                }
                else if (secim == "x") // çıkış yap 
                {
                    Console.WriteLine("Çıkış Yaptınız.");
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlış İşlem. Tekrar Deneyin !");
                }
            }
        }

        static void Sum(double a, double b) // Toplama 
        {
            double toplam = a + b;
            Console.WriteLine("Toplamı : " + toplam);
        }

        static void Remove(double a, double b) // Çıkartma 
        {
            double cıkar = a - b;
            Console.WriteLine("Sonuç : " + cıkar);
        }

        static void Hit(double a, double b) // Çarpma
        {
            double carp = a * b;
            Console.WriteLine("Sonuç : " + carp);
        }

        static void Plenty(double a, double b) // Bölme 
        {
            double bol = a / b;
            Console.WriteLine("Sonuç : " + bol);
        }

        static void Usalma(double a, double b)
        {
            double üs = Math.Pow(a, b);
            Console.WriteLine("Sonuç : " + üs);
        }

    }
}
