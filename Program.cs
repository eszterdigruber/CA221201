namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Szamrendszer1();
        }

        private static void Szamrendszer1()
        {
            Console.Write("Kérem adjon meg egy számsort: ");
            string BekertTMB = Console.ReadLine();
            Console.Write("Kérem adja meg a számrendszer alapját: ");
            int Alap = int.Parse(Console.ReadLine());
            int Hossz = BekertTMB.Length;
            //Hibakezelés a felhasználó részéről
            int[] LehetsegesKaraktereTMB = new int[Alap];
            for (int i = 0; i < Alap; i++)
            {
                LehetsegesKaraktereTMB[i] = Alap - i - 1;
                Console.WriteLine($"{LehetsegesKaraktereTMB[i]}");
            }
            int db = 0;
            for (int i = 0; i < LehetsegesKaraktereTMB.Length; i++)
            {
                for (int j = 0; j < Hossz; j++)
                {
                    if (LehetsegesKaraktereTMB[i] == int.Parse(BekertTMB[j].ToString()))
                    {
                        db++;
                    }
                }
            }
            if (db == Hossz)
            {
                //Átírási része a programnak
                double Ertek = 0;
                for (int i = 0; i < Hossz; i++)
                {
                    Ertek += int.Parse(BekertTMB[i].ToString()) * Math.Pow(Alap, Hossz - 1 - i);
                }
                Console.WriteLine($"A szám tizes számrendszerben: {Ertek}");
            }
            else
            {
                Console.WriteLine("Hibás karakterlánc");
            }
        }
    }
}