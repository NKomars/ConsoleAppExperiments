using System;

namespace ConsoleAppExperiments
{
    class Program
    {
        static void Main(string[] args)
        {
            Human person = new Human("Ņiķita", "Komars", 20, "Brown");            
            person.Introduce();
           
            person.AddNumbers(6, 85);

        }
    }

   
}
