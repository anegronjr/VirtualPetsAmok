using System;
using System.Collections.Generic;

namespace VirtualPetsAmok
{
    class Program
    {
        //Creates first instance of Pet Class.
        static List<VirtualPet> petList = new List<VirtualPet>();
        static VirtualPet pet = new VirtualPet();
        static int currentPet = 0;

        //Main program method.
        static void Main(string[] args)
        {
            //Game start
            petList.Add(pet);

            Console.WriteLine("Thanks for playing Virtual Pets Amok!");
            Console.WriteLine("We'll start by creating your first pet.");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Please name your new pet.");
            petList[currentPet].Name = Console.ReadLine();
            Console.Clear();
        SpeciesSelection:
            Console.WriteLine("What species is your new pet?");
            Console.WriteLine("1. Dog");
            Console.WriteLine("2. Cat");
            Console.WriteLine();
            string speciesChoice = Console.ReadLine();

            switch (speciesChoice)
            {
                case "1":
                    petList[currentPet].Species = "Dog";
                    break;
                case "2":
                    petList[currentPet].Species = "Cat";
                    break;
                default:
                    Console.WriteLine("Please choose either a dog or cat. Press ENTER to try again.");
                    Console.ReadKey();
                    Console.Clear();
                    goto SpeciesSelection;

            }

            Console.Clear();
            Console.WriteLine("Congratulations! Your new pet " + petList[currentPet].Species + ", " + petList[currentPet].Name + ", is ready to go!");
            Console.WriteLine("Press ENTER to go to the main menu.");
            Console.ReadKey();
            MainMenu();
        }

        //Method that displays Main Menu.
        static void MainMenu()
        {
            Console.WriteLine("Current Pet:  " + petList[currentPet].Name);
            Console.WriteLine();
            petList[currentPet].Decay();
            Console.Clear();
            Console.WriteLine("========= MAIN MENU =========");
            Console.WriteLine("1. Interact with " + petList[currentPet].Name);
            Console.WriteLine("2. Display " + petList[currentPet].Name + "'s Information");
            Console.WriteLine("3. Display " + petList[currentPet].Name + "'s Status");
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
                    AllPets();
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
            foreach (VirtualPet line in petList)
            {
                Console.WriteLine((position += 1) + ". Name: " + line.Name + "     Species: " + line.Species);
            }

            currentPet = Int32.Parse(Console.ReadLine());
            currentPet--;

            Console.Clear();
            Console.WriteLine("Your current pet is now " + petList[currentPet].Name + "!");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadKey();
            MainMenu();
        }

        //Method that displays Pet Info.
        static void PetInfo()
        {
            Console.Clear();
            DrawPicture();
            Console.WriteLine("Pet Name: " + petList[currentPet].Name);
            Console.WriteLine("Pet Species: " + petList[currentPet].Species);
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
            Console.WriteLine("What would you like to do with " + petList[currentPet].Name + "?");
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
                    Console.WriteLine("You took " + petList[currentPet].Name + " out to the park!");
                    Console.WriteLine(petList[currentPet].Name + " had a great time!");
                    petList[currentPet].Play();
                    Console.WriteLine();
                    Console.WriteLine(petList[currentPet].Name + "'s Boredom is now: " + petList[currentPet].Boredom);
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadKey();
                    PetInteractions();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine(petList[currentPet].Name + " devoured its food!");
                    petList[currentPet].Feed();
                    Console.WriteLine();
                    Console.WriteLine(petList[currentPet].Name + "'s Hunger is now: " + petList[currentPet].Hunger);
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadKey();
                    PetInteractions();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Zzzzzzzzzzzzzzzzzzz. " + petList[currentPet].Name + " is taking a nap...");
                    petList[currentPet].Rest();
                    Console.WriteLine();
                    Console.WriteLine(petList[currentPet].Name + " is now fully rested!");
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadKey();
                    PetInteractions();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine(petList[currentPet].Name + " sniffs around...");
                    Console.WriteLine(petList[currentPet].Name + " left a mess!");
                    petList[currentPet].Poop();
                    Console.WriteLine();
                    Console.WriteLine(petList[currentPet].Name + " successfully relieved itself!");
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadKey();
                    PetInteractions();
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine(petList[currentPet].Name + " drinks some water!");
                    petList[currentPet].Drink();
                    Console.WriteLine(petList[currentPet].Name + " looks pleased!");
                    Console.WriteLine();
                    Console.WriteLine(petList[currentPet].Name + "'s thirst is now: " + petList[currentPet].Thirst);
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

        //Method that displays information for all pets.
        static void AllPets()
        {
            Console.Clear();
            int position = 0;
            foreach (VirtualPet line in petList)
            {
                Console.WriteLine((position += 1) + ". Name: " + line.Name + "     Species: " + line.Species);
            }
            Console.WriteLine("Press any key to go to Main Menu.");
            Console.ReadKey();
            MainMenu();
        }

        //Method that creates new pets.
        static void CreatePet()
        {
            int numPets = petList.Count;
            VirtualPet newPet = new VirtualPet();

            Console.Clear();
            Console.WriteLine("Please name your new pet: ");
            newPet.Name = Console.ReadLine();
            Console.Clear();
        NewPetSpecies:
            Console.WriteLine("What species is your new pet?");
            Console.WriteLine("1. Dog");
            Console.WriteLine("2. Cat");
            Console.WriteLine();
            string speciesChoice = Console.ReadLine();

            switch (speciesChoice)
            {
                case "1":
                    newPet.Species = "Dog";
                    break;
                case "2":
                    newPet.Species = "Cat";
                    break;
                default:
                    Console.WriteLine("Please choose either a dog or cat. Press ENTER to try again.");
                    Console.ReadKey();
                    Console.Clear();
                    goto NewPetSpecies;

            }

            petList.Add(newPet);

            Console.Clear();
            Console.WriteLine("Congratulations! Your new pet " + petList[numPets].Species + ", " + petList[numPets].Name + ", is ready to go!");
            Console.WriteLine("Press ENTER to go to the main menu.");
            Console.ReadKey();
            MainMenu();

        }

        //Method that displays Pet Status.
        static void PetStatus()
        {
            Console.Clear();
            DrawPicture();
            Console.WriteLine("Boredom: " + petList[currentPet].Boredom);
            Console.WriteLine("Hunger: " + petList[currentPet].Hunger);
            Console.WriteLine("Fatigue: " + petList[currentPet].Fatigue);
            Console.WriteLine("Potty: " + petList[currentPet].Potty);
            Console.WriteLine("Thirst: " + petList[currentPet].Thirst);
            Console.WriteLine();
            Console.WriteLine("Press ENTER to return to the Main Menu.");
            Console.ReadKey();
            MainMenu();
        }

        //Method that draws pet's ASCII art.
        static void DrawPicture()
        {
            if (petList[currentPet].Species == "Dog")
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

            } else if (petList[currentPet].Species == "Cat")
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
