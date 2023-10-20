using System;

namespace uppgift_4_5
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal");
            string heltal = Console.ReadLine();
            string tal = "";
            for (int i = 0; i < heltal.Length; i++)
            {
                string tecken = heltal[i].ToString();
                int siffra = int.Parse(tecken);
                siffra++;

                if (siffra == 9+1)
                {
                    siffra = 0;
                }

                tal += siffra;

            }
            Console.WriteLine(tal);
            Console.ReadKey();
        }
    }
}
