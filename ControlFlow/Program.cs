using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust
            //kui kasuaja on anem, kui 18, siis konsoolis kuvatakse "oled piisavalt vana"
            //kui kasutaja on noorem, kui 18, siis konsoolis kuvatakse "oled liiga noor"
            //kui kasutaja on 18, siis konsoolis kuvatakse "oledki 18"

            Console.WriteLine("Kui vana sa oled?");
            int Age = Convert.ToInt32(Console.ReadLine());

            if (Age > 18)
            {
                Console.WriteLine("Oled pisavalt vana.");
            }
            else if (Age < 18)
            {
                Console.WriteLine("Oled liiga noor.");
            }
            else
            {
                Console.WriteLine("Oledki 18.");            
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
