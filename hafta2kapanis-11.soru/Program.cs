class Program
{
    static void Main()
    {
        Console.WriteLine("Birinci kişinin yaşını giriniz.");
        int age1 = int.Parse(Console.ReadLine());

        Console.WriteLine("İkinci kişinin yaşını giriniz.");
        int age2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Üçüncü kişinin yaşını giriniz.");
        int age3 = int.Parse(Console.ReadLine());

        int oldestAge = GetOldestAge(age1, age2, age3);
        Console.WriteLine("En yaşlı kişinin yaşı: " + oldestAge);

    }

    static int GetOldestAge(int age1, int age2, int age3)
    {
        int maxAge = Math.Max(age1, Math.Max(age2, age3));
        return maxAge;
    }
}
