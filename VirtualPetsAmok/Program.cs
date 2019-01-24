﻿using System;

namespace VirtualPetsAmok
{
    class Program
    {
        //Creates first instance of Pet Class
        static VirtualPet pet = new VirtualPet();

        static void Main(string[] args)
        {
            //Game start
            Console.WriteLine("Thanks for playing Virtual Pets Amok!");
            Console.WriteLine("We'll start by creating your first pet.");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Please name your new pet.");
            pet.Name = Console.ReadLine();
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
                    pet.Species = "Dog";
                    break;
                case "2":
                    pet.Species = "Cat";
                    break;
                default:
                    Console.WriteLine("Please choose either a dog or cat. Press ENTER to try again.");
                    Console.ReadKey();
                    Console.Clear();
                    goto SpeciesSelection; //Goes to line 21.

            }

            Console.Clear();
            Console.WriteLine("Congratulations! Your new pet " + pet.Species + ", " + pet.Name + ", is ready to go!");
            Console.WriteLine("Press ENTER to go to the main menu.");
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
            Console.Clear();
            Console.WriteLine("What would you like to do with " + pet.Name + "?");
            Console.WriteLine("1. Play");
            Console.WriteLine("2. Feed");
            Console.WriteLine("3. Sleep");
            Console.WriteLine("4. Bathroom");
            Console.WriteLine("5. Give water");
            Console.WriteLine("6. Go Back to Main Menu");

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
                    Console.WriteLine();
                    Console.WriteLine(pet.Name + " looks pleased!");
                    Console.WriteLine(pet.Name + "'s thirst is now: " + pet.Thirst);
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadKey();
                    PetInteractions();
                    break;
                case "6":
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Please enter a valid selection.");
                    Console.ReadKey();
                    PetInteractions();
                    break;

            }

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
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Press ENTER to return to the Main Menu.");
            Console.ReadKey();
            MainMenu();
        }

        //Method that displays Main Menu.
        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("========= MAIN MENU =========");
            Console.WriteLine("1. Display Pet Info");
            Console.WriteLine("2. Pet Interactions");
            Console.WriteLine("3. Pet Status");
            Console.WriteLine("0. Quit Game");
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
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Write("Please enter a valid choice. Press ENTER to try again.");
                    Console.ReadKey();
                    MainMenu();
                    break;
            }
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
