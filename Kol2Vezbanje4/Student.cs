namespace Kol2Vezbanje4
{
    public class Student
    {
        private string ime;
        private string prezime;
        private int poeni;

        public string Ime
        {
            get => ime;
            set => ime = value;
        }

        public string Prezime
        {
            get => prezime;
            set => prezime = value;
        }

        public int Poeni
        {
            get => poeni;
            set => poeni = value;
        }

        public Student(string i, string p, int po)
        {
            ime = i;
            prezime = p;
            poeni = po;
        }

        public override string ToString()
        {
            return "Stident " + ime + prezime + " osvojio je: " + poeni + " poena.";
        }
    }
}