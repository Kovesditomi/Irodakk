namespace Irodakk
{
    internal class Program
    {
        static int ot(List<Iroda> c)
        {
            var otos = 0;
            for (int i = 0; i < c.Count; i++)
            {

                for (int j = 0; j < c[i].Letszamadatok.Count; j++)
                {
                    if (c[i].Letszamadatok[j] > 5)
                    {
                        otos++;
                    }

                }

            }
            return otos;
        }

        static Iroda? kilenc(List<Iroda> b)
        {
            var kil = b.FirstOrDefault(x => x.Letszamadatok.Contains(9));
            return kil;
        }

        static int Legtobb(List<Iroda> a)
        {
            var leg = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                leg.Add(a[i].Letszamadatok.Sum());

            }
            return leg.IndexOf(leg.Max()) + 1;
        }

        static void Main(string[] args)
        {
            List<Iroda> iroda = new List<Iroda>();
            using (var sr = new StreamReader(@"..\..\..\src\irodahaz.txt"))
            {
                while (!sr.EndOfStream)
                {
                    iroda.Add(new Iroda(sr.ReadLine()));
                }
            }

            string tabla = "Kód\t\t         Kezdet\t" +
               "\t   1.   2.   3.   4.   5.   6.   7.   8.   9.  10.  11.  12\n";
            for (int i = 0; i < iroda.Count; i++)
            {
                tabla += $"{i + 1}. {iroda[i]}\n";
            }

            Console.WriteLine(tabla);

            Console.WriteLine("8.feladat");
            Console.WriteLine($"{Legtobb(iroda)}.emelet");


            Console.WriteLine("9.feladat");
            if (kilenc(iroda) is null)
            {
                Console.WriteLine("Nincs ilyen Iroda");

            }
            else
            {
                Console.WriteLine($"{kilenc(iroda).Kod}, {kilenc(iroda).Letszamadatok.IndexOf(9) + 1}.");


            }
            Console.WriteLine("10.feladat");
            Console.WriteLine($"{ot(iroda)} db");
        }

    }
}