namespace KursProv
{
    public class Hund : Djur
    {
        public Hund(int å, string n, string a) : base(å, n, a) //Konstruktor
        {
            this.Ålder = å;
            this.Namn = n;
            this.Art = a;
        }
        public override void Djurläte() //Polymorfism
        {
            Console.WriteLine("Woff");
        }

        public override void Äter() //Polymorfism
        {
            Console.WriteLine("*Hunden äter*");
        }
    }
}