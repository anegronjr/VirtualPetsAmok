using System;
using System.Collections.Generic;

namespace VirtualPetsAmok
{
    class Program
    {
        //Creates first instance of Pet Class.
        static PetShelter Shelter = new PetShelter();
        public static int currentPet = Shelter.CurrentPet;
        static VirtualPet pet;

        //Main program method.
        static void Main(string[] args)
        {
            //Game Start
            VirtualPet FirstPet = new VirtualPet();
            Shelter.Add(FirstPet);

            pet = Shelter.Pets[currentPet];

            Console.WriteLine("Thanks for playing Virtual Pets Amok!");
            Console.WriteLine("We'll start by creating your first pet.");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadKey();
            Console.Clear();

            bool run = true;
            do
            {
                Console.WriteLine("Please name your new pet.");
                pet.Name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("What species is your new pet?");
                Console.WriteLine("1. Dog");
                Console.WriteLine("2. Cat");
                Console.WriteLine();
                string speciesChoice = Console.ReadLine();

                switch (speciesChoice)
                {
                    case "1":
                        pet.Species = "Dog";
                        run = false;
                        break;
                    case "2":
                        pet.Species = "Cat";
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Please choose either a dog or cat. Press ENTER to try again.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while(run);

            Console.Clear();
            Console.WriteLine("Congratulations! Your new pet " + pet.Species + ", " + pet.Name + ", is ready to go!");
            Console.WriteLine("Press ENTER to go to the main menu.");
            Console.ReadKey();
            MainMenu();
        }

        //Method that displays Main Menu.
        static void MainMenu()
        {
            Console.WriteLine("Current Pet:  " + pet.Name);
            Console.WriteLine();
            pet.Decay();
            Console.Clear();
            Console.WriteLine("========= MAIN MENU =========");
            Console.WriteLine("1. Interact with " + pet.Name);
            Console.WriteLine("2. Display " + pet.Name + "'s Information");
            Console.WriteLine("3. Display " + pet.Name + "'s Status");
            Console.WriteLine("4. Display All Pet Information");
            Console.WriteLine("5. Switch Current Pet");
            Console.WriteLine("6. Create New Pet");
            Console.WriteLine("0. Quit Game");
            string menuSelection = Console.ReadLine();

            switch (menuSelection)
            {
                case "1":
                    PetInteractions();
                    break;
                case "2":
                    PetInfo();
                    break;
                case "3":
                    PetStatus();
                    break;
                case "4":
                    Shelter.AllPets();
                    break;
                case "5":
                    SwitchCurrentPet();
                    break;
                case "6":
                    CreatePet();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Write("Please enter a valid selection. Press ENTER to try again.");
                    Console.ReadKey();
                    MainMenu();
                    break;
            }
        }

        //Method that allows user to switch current pet.
        public static void SwitchCurrentPet()
        {
            Console.Clear();
            Console.WriteLine("Which pet would you like to look after?");
            Console.WriteLine();

            int position = 0;
            foreach (VirtualPet line in Shelter.Pets)
            {
                Console.WriteLine((position += 1) + ". Name: " + line.Name + "     Species: " + line.Species);
            }

            currentPet = Int32.Parse(Console.ReadLine());
            currentPet--;

            Console.Clear();
            Console.WriteLine("Your current pet is now " + pet.Name + "!");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadKey();
            MainMenu();
        }

        //Method that displays Pet Info.
        static void PetInfo()
        {
            Console.Clear();
            DrawPicture();
            Console.WriteLine("Pet Name: " + pet.Name);
            Console.WriteLine("Pet Species: " + pet.Species);
            Console.WriteLine();
            Console.WriteLine("Press ENTER to return to the Main Menu.");
            Console.ReadKey();
            MainMenu();
        }

        //Method that displays Pet Interaction menu.
        static void PetInteractions()
        {
            pet.Decay();
            Console.Clear();
            Console.WriteLine("What would you like to do with " + pet.Name + "?");
            Console.WriteLine("1. Play");
            Console.WriteLine("2. Feed");
            Console.WriteLine("3. Sleep");
            Console.WriteLine("4. Take to Bathroom");
            Console.WriteLine("5. Give Water");
            Console.WriteLine("0. Go Back to Main Menu");

            string interactionSelection = Console.ReadLine();
            
            switch(interactionSelection) 
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("You took " + pet.Name + " out to the park!");
                    Console.WriteLine(pet.Name + " had a great time!");
                    pet.Play();
                    Console.WriteLine();
                    Console.WriteLine(pet.Name + "'s Boredom is now: " + pet.Boredom);
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadKey();
                    PetInteractions();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine(pet.Name + " devoured its food!");
                    pet.Feed();
                    Console.WriteLine();
                    Console.WriteLine(pet.Name + "'s Hunger is now: " + pet.Hunger);
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadKey();
                    PetInteractions();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Zzzzzzzzzzzzzzzzzzz. " + pet.Name + " is taking a nap...");
                    pet.Rest();
                    Console.WriteLine();
                    Console.WriteLine(pet.Name + " is now fully rested!");
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadKey();
                    PetInteractions();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine(pet.Name + " sniffs around...");
                    Console.WriteLine(pet.Name + " left a mess!");
                    pet.Poop();
                    Console.WriteLine();
                    Console.WriteLine(pet.Name + " successfully relieved itself!");
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadKey();
                    PetInteractions();
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine(pet.Name + " drinks some water!");
                    pet.Drink();
                    Console.WriteLine(pet.Name + " looks pleased!");
                    Console.WriteLine();
                    Console.WriteLine(pet.Name + "'s thirst is now: " + pet.Thirst);
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadKey();
                    PetInteractions();
                    break;
                case "0":
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Please enter a valid selection. Press ENTER to try again.");
                    Console.ReadKey();
                    PetInteractions();
                    break;

            }

        }



        //Method that creates new pets.
        static void CreatePet()
        {
            int numPets = Shelter.Pets.Count;
            VirtualPet newPet = new VirtualPet();

            Console.Clear();
            Console.WriteLine("Please name your new pet: ");
            newPet.Name = Console.ReadLine();
            Console.Clear();
            bool runNew = true;
            do
            {
                Console.WriteLine("Please name your new pet.");
                newPet.Name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("What species is your new pet?");
                Console.WriteLine("1. Dog");
                Console.WriteLine("2. Cat");
                Console.WriteLine();
                string speciesChoice = Console.ReadLine();

                switch (speciesChoice)
                {
                    case "1":
                        newPet.Species = "Dog";
                        runNew = false;
                        break;
                    case "2":
                        newPet.Species = "Cat";
                        runNew = false;
                        break;
                    default:
                        Console.WriteLine("Please choose either a dog or cat. Press ENTER to try again.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (runNew);

            Shelter.Pets.Add(newPet);

            Console.Clear();
            Console.WriteLine("Congratulations! Your new pet " + newPet.Species + ", " + newPet.Name + ", is ready to go!");
            Console.WriteLine("Press ENTER to go to the main menu.");
            Console.ReadKey();
            MainMenu();

        }

        //Method that displays Pet Status.
        static void PetStatus()
        {
            Console.Clear();
            DrawPicture();
            Console.WriteLine("Boredom: " + pet.Boredom);
            Console.WriteLine("Hunger: " + pet.Hunger);
            Console.WriteLine("Fatigue: " + pet.Fatigue);
            Console.WriteLine("Potty: " + pet.Potty);
            Console.WriteLine("Thirst: " + pet.Thirst);
            Console.WriteLine();
            Console.WriteLine("Press ENTER to return to the Main Menu.");
            Console.ReadKey();
            MainMenu();
        }

        //Method that draws pet's ASCII art.
        static void DrawPicture()
        {
            if (pet.Species == "Dog")
            {
                //Print dog
                Console.WriteLine(@"    ___");
                Console.WriteLine(@" __/_  `.  .-''' -.");
                Console.WriteLine(@" \_,` | \-'  /   )`-')");
                Console.WriteLine(@"  '') `'`    \  ((`'`");
                Console.WriteLine(@" ___Y  ,    .'7 /|");
                Console.WriteLine(@"(_,___/...-` (_/_/");
                Console.WriteLine();
                Console.WriteLine();

            } else if (pet.Species == "Cat")
            {
                //Print cat
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
