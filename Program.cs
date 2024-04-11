
using System.ComponentModel;
using System.Net.WebSockets;
using System;
using KursProv;

class Program
{
    private static void Main(string[] args)
    {   
        //Bongård();

        int[] intArray = {1, 2, 3};
        double[] doubleArray = {1.0, 2.0, 3.0};
        String[] stringArray = {"1", "2", "3"};

        displayElements(intArray);
        displayElements(doubleArray);
        displayElements(stringArray);

        Console.ReadKey();
    }   

    public static void displayElements<T>(T[] array) //Generics
    {
        foreach(T item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }


    public static void Bongård()
    {
        Djur minaDjur1 = new Katt(12, "Bettan", "Bonnekatt");
        Djur minaDjur2 = new Hund(5, "Doge", "Shiba Inu");
        

        List<Djur> djurs = new List<Djur>();

        djurs.Add(minaDjur1);
        djurs.Add(minaDjur2);


        foreach (Djur djur in djurs)
        {
            if (djur is Katt){
                Console.WriteLine($"{djur.Ålder}, {djur.Namn}, {djur.Art}");
                djur.Djurläte();
                Console.WriteLine();
            }

            if (djur is Hund)
            {
                Console.WriteLine($"{djur.Ålder}, {djur.Namn}, {djur.Art}");
                djur.Äter();
                Console.WriteLine();
            }
        }
        
        int mat = 0;

        TG("Gissa hur mycket mat djuren äter totalt(kg) på en vecka");

        while(true)
        {
            try{
                mat = int.Parse(Console.ReadLine());

                if(mat == 2)
                {
                    TG("Du gissade rätt!");
                    break;
                }
                else
                {
                    TGS("Fel!!!");
                    TG("Försök igen:");
                }
            }
            catch{
                TG("Skriv in ett heltal...");
            }
        }
    }

    static void TG(string text)
    {
        foreach(char c in text)
        {
            Console.Write(c);
            Thread.Sleep(50);
        }
        Console.WriteLine();
        Thread.Sleep(1000);
    }

    static void TGS(string text)
    {
        foreach(char c in text)
        {
            Console.Write(c);
            Thread.Sleep(500);
        }
        Console.WriteLine();
        Thread.Sleep(2000);
    }
}