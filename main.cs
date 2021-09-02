using System;

class MainClass {
  public static void Main (string[] args) {
    Random rastgele = new Random();
    int sayi1 = rastgele.Next(1, 101);
    int sayi2 = rastgele.Next(1, 101);
    int toplam = sayi1 + sayi2;
    Console.WriteLine("Tutulan sayi 1: "+ sayi1 + "\nTutulan sayi 2: " + sayi2);
    Console.WriteLine("Bu sayilarin toplami nedir? ");
    int kullaniciToplam = int.Parse(Console.ReadLine());
    if (kullaniciToplam == toplam)
    Console.WriteLine("Tebrikler bildiniz!");
    else
    Console.WriteLine("Uzgunum bilemediniz...");


    
    Console.ReadLine();
  }
}