using System;

namespace Zombie_vs_Dinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            //En slump generator för alla värden som behövs
            Random Generator = new Random();
            
            //Info om Zombiesar
            Zombie zombie = new Zombie();
            zombie.Intelligens = Generator.Next(1, 5);
            zombie.Resistance = Generator.Next(5, 10);
            zombie.Strength = Generator.Next(1, 10);

            //Info om Dinosaurier
            Dinosaurs dinosaur = new Dinosaurs();
            dinosaur.Intelligens = Generator.Next(5, 10);
            dinosaur.Resistance = Generator.Next(1, 5);
            dinosaur.Strength = Generator.Next(1, 10);

            Console.WriteLine("How many dinosaurs do you want in tour team?");
            Console.Write("Amount: "); int dinosauramount = Console.ReadLine();


        }
    }
}
