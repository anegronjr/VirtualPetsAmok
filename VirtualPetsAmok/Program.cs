using System;

namespace VirtualPetsAmok
{
    class Program
    {
        static VirtualPet pet = new VirtualPet();

        static void Main(string[] args)
        {
            Console.WriteLine("Thanks for playing Virtual Pets Amok!");
            Console.WriteLine("We'll start by creating your first pet.");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Please name your new pet?");
            pet.Name = Console.ReadLine();
            Console.WriteLine("What species is your new pet?");
            pet.Species = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Congratulations! Your new pet " + pet.Species + ", " + pet.Name + ", is ready to go!");
            Console.WriteLine("Press ENTER to go to the main menu.");
            Console.ReadKey();
            MainMenu();
        }

        static void PetInfo() 
        {
            Console.Clear();
            Console.WriteLine("Pet Name: " + pet.Name);
            Console.WriteLine("Pet Species: " + pet.Species);
            Console.WriteLine("Press ENTER to return to the Main Menu.");
            Console.ReadKey();
            MainMenu();
        }

        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("========= MAIN MENU =========");
            Console.WriteLine("1. Display Pet Info");
            Console.WriteLine("2. Quit Game");

            string menuSelection = Console.ReadLine();

            switch (menuSelection)
            {
                case "1":
                    PetInfo();
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
            }
        }

    }
}
