class Program
{
    static void Main()
    {
        Console.Write("1. kullanıcı: Merhaba adınız soyadınız?:");
        string cevap1 = Console.ReadLine();

        Console.Write("2. kullanıcı: Merhaba adınız soyadınız?:");
        string cevap2 = Console.ReadLine();

        DegerleriDegistir(ref cevap1, ref cevap2);

        Console.WriteLine($"cevap1: {cevap1}");
        Console.WriteLine($"cevap2: {cevap2}");
    }

    static void DegerleriDegistir(ref string cevap1, ref string cevap2)
    {
        string temp = cevap1;
        cevap1 = cevap2;
        cevap2 = temp;
    }
}
