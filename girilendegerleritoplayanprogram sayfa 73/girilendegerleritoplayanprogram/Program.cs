int sayi1 = 0;
int sayi2 = 0;
int sayi3 = 0;
int bitir = 0;
int toplam = 0;

{
    Console.Write("1.sayıyı giriniz :");

    sayi1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("2.sayıyı giriniz :");

    sayi2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("3.sayıyı giriniz :");

    sayi3 = Convert.ToInt32(Console.ReadLine());

    toplam = (sayi1 + sayi2 + sayi3);

    Console.WriteLine("Sayıların toplamı :" + toplam);

    Console.Write("Toplama işlemini bitirmek için 83 yazın");

    bitir = Convert.ToInt32(Console.ReadLine());
}

Console.ReadLine();