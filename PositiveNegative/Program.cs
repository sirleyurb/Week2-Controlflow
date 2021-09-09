using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada numberit -10 kuni 10
            //programm konrollib seda numbrit
            //kui number on positiivne, konsool kuvab "positive"
            //kui number on negatiivne, konsool kuvab "negative"
            //kui number on 0, siis konsool kuvab "null"

            Console.WriteLine("Sisesta number -10 kuni 10");
            int UserNumber = Convert.ToInt32(Console.ReadLine());

            if(UserNumber > 0)
            {
                Console.WriteLine("positive");
            }
            else if(UserNumber < 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("null");
            }
        }
    }
}
