int a = 0, b = 0;
Console.Write("1. sayıyı giriniz:");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("2. sayıyı giriniz:");
b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    int c = a;
    a = b;
    b = c;
}

int ciftToplam = 0, tekToplam = 0;
for (int i = a; i <= b; i++)
{
    if (i % 2 == 0)
        ciftToplam += i;
    else
        tekToplam += i;
}
Console.WriteLine("Çift Sayıların Toplamı={0}\nTek Sayıların Toplamı={1}", ciftToplam, tekToplam);
Console.ReadKey();
