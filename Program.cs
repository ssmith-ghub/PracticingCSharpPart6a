using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string usersName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            int usersAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you have have any pets?");  //I want to learn how to add a bool here that handles a "yes" if true and a "no" if false response
            string userPets = Console.ReadLine();

            Console.WriteLine("How many pets do you have?");
            int numberOfPets = Convert.ToInt32(Console.ReadLine());

            char exclaimSymbol = '!';


            Console.WriteLine("Hello " + usersName + exclaimSymbol);
            Console.WriteLine("You are " + usersAge + " years old.");
            Console.WriteLine("You do have pets" + exclaimSymbol);  // this would be better with some sort of "yes" or "no" bool type response
            Console.WriteLine("You have " + numberOfPets + " animals at home" + exclaimSymbol);
            Console.ReadKey();
            Console.Beep();
        }
    }
}