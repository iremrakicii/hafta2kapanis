//3 - Rastgele bir sayı üretip , ekrana yazdırınız.
class Program
{
    static void Main()
    {
        Random sayi = new Random();

        int a;
        int b;

        while (true)
        {
            a = sayi.Next(5, 15);
            b = sayi.Next(5, 15);
            Console.WriteLine($"{a}-{b}");
            if (a == b)
                break;
        }
    }
}