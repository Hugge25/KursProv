
using System.ComponentModel;
using KursProv;

class Program
{
    private static void Main(string[] args)
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
}