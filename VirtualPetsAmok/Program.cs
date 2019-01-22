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
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("What species is your new pet?");
            Console.WriteLine("1. Dog");
            Console.WriteLine("2. Cat");
            string speciesChoice = Console.ReadLine();

            switch (speciesChoice)
            {
                case "1":
                    pet.Species = "Dog";
                    break;
                case "2":
                    pet.Species = "Cat";
                    break;
            }

            Console.Clear();
            Console.WriteLine("Congratulations! Your new pet " + pet.Species + ", " + pet.Name + ", is ready to go!");
            Console.WriteLine("Press ENTER to go to the main menu.");
            Console.ReadKey();
            MainMenu();
        }

        static void PetInfo() 
        {
            Console.Clear();
            DrawPicture();
            Console.WriteLine("Pet Name: " + pet.Name);
            Console.WriteLine("Pet Species: " + pet.Species);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Press ENTER to return to the Main Menu.");
            Console.ReadKey();
            MainMenu();
        }

        static void PetInteractions()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do with " + pet.Name + "?");
            Console.WriteLine("1. Play");
            Console.WriteLine("2. Feed");
            Console.WriteLine("3. Sleep");
            Console.WriteLine("4. Bathroom");
            Console.WriteLine("5. Give water");
            Console.WriteLine("6. Go Back to Main Menu");
        }

        static void PetStatus()
        {
            Console.Clear();
            DrawPicture();
            Console.WriteLine("Fatigue: " + pet.Fatigue);
            Console.WriteLine("Hunger: " + pet.Hunger);
            Console.WriteLine("Thirst: " + pet.Thirst);
            Console.WriteLine("Boredom: " + pet.Boredom);
            Console.WriteLine("Potty: " + pet.Potty);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Press ENTER to return to the Main Menu.");
            Console.ReadKey();
            MainMenu();
        }

        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("========= MAIN MENU =========");
            Console.WriteLine("1. Display Pet Info");
            Console.WriteLine("2. Pet Interactions");
            Console.WriteLine("3. Pet Status");
            Console.WriteLine("5. Quit Game");

            string menuSelection = Console.ReadLine();

            switch (menuSelection)
            {
                case "1":
                    PetInfo();
                    break;
                case "2":
                    PetInteractions();
                    break;
                case "3":
                    PetStatus();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
            }
        }

        static void DrawPicture()
        {
            if (pet.Species == "Dog")
            {
                // Print Dog
                Console.WriteLine("    ___");
                Console.WriteLine(" __/_  `.  .-''' -.");
                Console.WriteLine(@" \_,` | \-'  /   )`-')");
                Console.WriteLine(@"  '') `'`    \  ((`'`");
                Console.WriteLine(" ___Y  ,    .'7 /|");
                Console.WriteLine("(_,___/...-` (_/_/");
                Console.WriteLine();
                Console.WriteLine();

            } else if (pet.Species == "Cat")
            {
                // Print cat
                Console.WriteLine(@"   |\---/|");
                Console.WriteLine(@"   | ,_, |");
                Console.WriteLine(@"    \_`_/-..----.");
                Console.WriteLine(@" ___/ `   ' ,''+ \ ");
                Console.WriteLine(@"(__...'   __\    |`.___.';");
                Console.WriteLine(@"  (_,...'(_,.`__)/'.....+");
                Console.WriteLine();
                Console.WriteLine();
            }
        }

    }
}
