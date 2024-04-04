namespace KursProv
{
    public class Katt : Djur
    {
        public Katt(int å, string n, string a) : base(å, n, a)
        {
            this.Ålder = å;
            this.Namn = n;
            this.Art = a;
        }
        public override void Djurläte() //Polymorfism
        {
            Console.WriteLine("Mjau");
        }

        public override void Äter() //Polymorfism
        {
            Console.WriteLine("*Katten äter*");
        }
    
    }
}