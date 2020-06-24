using System;

namespace ConsoleAppExperiments
{
    class Program
    {
        static void Main(string[] args)
        {
            Human person = new Human();
            person.Name = "Ņiķita";
            person.Surname = "Komars";
            person.Age = 20;
            person.EyeColor = "Brown";
            person.Introduce();

            person.Name = "Jānis";
            person.Surname = "Roks";
            person.Introduce();

        }
    }

   
}
