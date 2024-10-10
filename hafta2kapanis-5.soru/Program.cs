// 5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
class Program
{
    static void Main()
    {
        Console.WriteLine("Merhaba Kaç Yaşındasınız?");
        int yas = Convert.ToInt32(Console.ReadLine());

        if (yas >= 18)
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}
