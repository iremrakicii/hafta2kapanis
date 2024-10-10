class Program
{
    public void Main()
    {
        string metin1 = "Gülse Birsel";
        string metin2 = "Demet Evgar";

        Console.WriteLine("birinci metin:" + metin1);
        Console.WriteLine("ikinci metin:" + metin2);


    }
    public void DegerleriDegistir(ref string metin1, ref string metin2)
    {
        Console.WriteLine($"birinci metin:{metin1}");
        Console.WriteLine($"ikinci  metin:{metin2}");

    }

}
