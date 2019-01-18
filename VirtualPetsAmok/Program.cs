using System;

namespace VirtualPetsAmok
{
    class Program
    {
        static void Main(string[] args)
        {
            Game();  
        }

        static void Game()
        {
            VirtualPet pet = new VirtualPet();

            Console.WriteLine("Name your pet: ");
            pet.Name = Console.ReadLine();
            Console.WriteLine("What species is your pet: ");
            pet.Species = Console.ReadLine();
        }
    }
}
