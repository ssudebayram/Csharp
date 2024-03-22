int sayiAdedi;
int toplam = 0;

Console.WriteLine("kaç sayı gireceksiniz");
sayiAdedi = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < sayiAdedi; i++)
{
    Console.WriteLine("sayı giriniz");
    int sayi = Convert.ToInt32(Console.ReadLine());

    toplam += sayi;
}
Console.WriteLine("girilen sayıların toplamı " + toplam );