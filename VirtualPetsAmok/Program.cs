using System;

namespace VirtualPetsAmok
{
    class Program
    {
        static void Main(string[] args)
        {
            Game();
            MainMenu();
        }

        static void Game()
        {
            VirtualPet pet = new VirtualPet();

            Console.WriteLine("Name your pet: ");
            pet.Name = Console.ReadLine();
            Console.WriteLine("You have named your pet " + pet.Name + ". What species is your pet: ");
            pet.Species = Console.ReadLine();
            Console.WriteLine("Your pet " + pet.Species + ", " + pet.Name + ", has been created. Press any key to continue.");
            Console.ReadKey();
            
        }

        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("====== Main Menu =====");
            Console.WriteLine("1. Display Pet Info.");


        }
    }
}
