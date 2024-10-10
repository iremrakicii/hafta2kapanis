class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen true veya false değerini giriniz:");
        bool userInput = bool.Parse(Console.ReadLine());

        string result = GetMessage(userInput);
        Console.WriteLine("Sonuç: " + result);
    }

    static string GetMessage(bool value)
    {
        if (value)
        {
            return "Kullanıcı true değerini girdi.";
        }
        else
        {
            return "Kullanıcı false değerini girdi.";
        }
    }
}
