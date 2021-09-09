using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm kontrollib kasutaja vanust
            //programm teatab kasutajat, kas ta on piisavalt vana,
            //et juhiluba saada (tingimiseks 18 aastat vana)

            Console.WriteLine("Mis aastal sa sündinud oled?");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            int Age = 2021 - YearOfBirth;

            if(Age >= 18)
            {
                Console.WriteLine("Oled piiavalt vana, et juhilube saada.");
            }
            else
            {
                Console.WriteLine("Oled liiga noor.");  
            }
           
 
        }
    }
}
