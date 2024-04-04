namespace KursProv
{
    public abstract class Djur : IÄter
    {
        private int ålder;
        private string namn;
        private string art;

        public int Ålder
        {
            get{return ålder;}
            set{ålder = value;}
        }

        public string Namn
        {
            get{return namn;}
            set{namn = value;}
        }

        public string Art
        {
            get{return art;}
            set{art = value;}
        }

        public Djur(int å, string n, string a) //Konstruktor
        {
            this.Ålder = å;
            this.Namn = n;
            this.Art = a;
        }

        public abstract void Djurläte();

        public abstract void Äter();
    }
}