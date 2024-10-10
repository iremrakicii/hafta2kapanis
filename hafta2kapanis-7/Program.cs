class Program
{
    public static void Main()
    {
        string metin1 = "Gülse Birsel";
        string metin2 = "Demet Evgar";

        DegerleriDegistir(ref metin1, ref metin2);

        Console.WriteLine($"birinci metin:{metin1}");
        Console.WriteLine($"ikinci  metin:{metin2}");


    }
    public static void DegerleriDegistir(ref string metin1, ref string metin2)
    {
        string temp = metin1;
        metin1 = metin2;
        metin2 = temp;

    }

}
