int EnBuyugu()
{
    int sayac = 1;
    int sayi;
    bool sonuc = true;
    int enBuyuk = int.MinValue;

    while (sonuc)
    {
        Console.Write($"Sayı {sayac++}: ");
        string cevap = Console.ReadLine();
        sonuc = int.TryParse(cevap, out sayi);

        if (sonuc)
        {
            enBuyuk = Math.Max(enBuyuk, sayi);
        }
    }

    return enBuyuk;
}

int buyuk = EnBuyugu();
Console.WriteLine("En Büyük Sayı: " + buyuk);