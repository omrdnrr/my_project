{
    Console.WriteLine("Kilonuzu giriniz");
    int kilo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Boyunuzu giriniz");
    double boy = Convert.ToDouble(Console.ReadLine());

    double beden_kitle_endeksi = kilo / (boy * boy); 

    if (beden_kitle_endeksi < 18)
    {
        Console.WriteLine("Beden kitle endeksiniz düşük zayıfsınız...");
        Console.ReadLine();
    }

    else if (beden_kitle_endeksi > 18 && beden_kitle_endeksi < 25)
    {
        Console.WriteLine("Beden kitle endeksiniz normal...");
        Console.ReadLine();
    }

    else if (beden_kitle_endeksi > 25)
    {
        Console.WriteLine("Beden kitle endeksiniz yüksek obezsiniz...");
        Console.ReadLine();
    }
}