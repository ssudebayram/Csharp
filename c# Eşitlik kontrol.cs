using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen üç tane sayı girin:");

        Console.Write("1. Sayıyı girin: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("2. Sayıyı girin: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("3. Sayıyı girin: ");
        int sayi3 = Convert.ToInt32(Console.ReadLine());


        if (sayi1 == sayi2)
        {
            Console.WriteLine(+sayi1 + " ile " + sayi2 + " eşittir ");
        }
        else if (sayi1 == sayi3)
        {
            Console.WriteLine(+sayi3 + " ile " + sayi1 + " eşittir ");
        }
        else if (sayi2 == sayi3)
        {
            Console.WriteLine(+sayi2 + " ile " + sayi3 + " eşittir ");

        }
        else
        {

            Console.WriteLine("sayılar eşit değildir");
        }
    }
}




           



 












