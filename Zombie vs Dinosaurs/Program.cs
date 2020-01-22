using System;
using System.Linq;

namespace Zombie_vs_Dinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            //En slump generator för alla värden som behövs
            Random Generator = new Random();

            //Info om Zombiesar
            Zombie Zombie = new Zombie();
            Zombie.Intelligens = Generator.Next(1, 5);
            Zombie.Resistance = Generator.Next(5, 10);
            Zombie.Strength = Generator.Next(1, 10);

            //Info om Dinosaurier
            Dinosaur Dinosaur = new Dinosaur();
            Dinosaur.Intelligens = Generator.Next(5, 10);
            Dinosaur.Resistance = Generator.Next(1, 5);
            Dinosaur.Strength = Generator.Next(1, 10);

            Console.WriteLine("How many dinosaurs do you want in your game? (Max: 10)");

            int ZombieAmount = 0;

            int DinosaurAmount = 0;

            while (DinosaurAmount <= 0)
            {
                Console.Write("Amount: "); string PlayerDinosaurAmount = Console.ReadLine();

                if (string.IsNullOrEmpty(PlayerDinosaurAmount))
                {
                    Console.WriteLine("Please, give an amount");

                    DinosaurAmount = 0;
                }
                else if (PlayerDinosaurAmount.All(char.IsLetter))
                {
                    Console.WriteLine("Please, only give a number");
                    DinosaurAmount = 0;
                }
                else if (PlayerDinosaurAmount.All(char.IsDigit))
                {
                    DinosaurAmount = Int32.Parse(PlayerDinosaurAmount);

                    if(DinosaurAmount > 10)
                    {
                        Console.WriteLine("To many Dinosaurs, please give a lower number");

                        DinosaurAmount = 0;

                    }
                    else
                    {
                        Console.WriteLine(DinosaurAmount + " Dinosaur was called to your game");
                    }
                }
            }

            Console.WriteLine("and how many Zomboes do you want in your game? (Max: 10)");

            while (ZombieAmount <= 0)
            {
                Console.Write("Amount: "); string PlayerZombieAmount = Console.ReadLine();

                if (string.IsNullOrEmpty(PlayerZombieAmount))
                {
                    Console.WriteLine("Please, give an amount");
                    ZombieAmount = 0;
                }
                else if (PlayerZombieAmount.All(char.IsLetter))
                {
                    Console.WriteLine("Please, only give a number");
                    ZombieAmount = 0;
                }
                else if (PlayerZombieAmount.All(char.IsDigit))
                {
                    ZombieAmount = Int32.Parse(PlayerZombieAmount);

                    if (ZombieAmount > 10)
                    {
                        Console.WriteLine("To many Dinosaurs, please give a lower number");

                        ZombieAmount = 0;
                    }
                    else
                    {
                        Console.WriteLine(ZombieAmount + " Zombies was called to your game");
                    }
                }
            }

            for (int i = 0; i < ZombieAmount; i++)
            {

            }



            Console.ReadLine();
        }
    }
}
