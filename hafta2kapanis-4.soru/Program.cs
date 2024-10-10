// 4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
class Program
{
    static void Main()
    {
        Random rastgele = new Random();

        int sayi = rastgele.Next(0, 101);

        int kalan = sayi % 3;


        Console.WriteLine("Random tamsayı değeri:" + sayi);

        Console.WriteLine("3 ile bölümünden kalan değer:" + kalan);

        Console.WriteLine("Çıkmak için bir tuşa basın...");

        Console.ReadKey();



    }
}
