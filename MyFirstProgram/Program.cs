using System;
using System.Security.Cryptography.X509Certificates;

namespace MyFirstProgram
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello Mr. \"Oluwapelumi Amos\"");
            //Console.Write("Hey Watsup\n");
            //Console.WriteLine("My name is \t AmosTech");
            //Console.WriteLine("I like pizza and its really good for my health.");

            //int age = 21;
            //double height = 300.05;
            //bool alive = true;
            //string username = "@oluwapelumi";

            //Console.WriteLine("Your Age is {0}years old. \nAlso your height is {1}cm. " +
            //    "\nAlive Status? {2}\nYour username is {3}", age, height, alive, username);

            //double a = 2.5;

            //int b = Convert.ToInt32(a);

            //Console.WriteLine(b.GetType());

            //string ques = "true";
            //bool quest = Convert.ToBoolean(ques);
            //Console.WriteLine(quest);
            //Console.WriteLine(quest.GetType());

            ////int c = Console.();


            //Console.Write("Hello What your Name? ");
            //string askName = Console.ReadLine();

            //Console.Write("How old are you? ");
            //int agess = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Hello {0} \nYou are {1}years old", askName, agess);

            //double agess = Convert.ToDouble(agess)

            Console.WriteLine("Hello, Please kindly tell us your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello {name}, Kindly please type in your age.");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Hello {name}, we learnt you are {age}years old.");


            Console.ReadKey();
            

        }
    }
}