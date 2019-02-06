using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public class Menu
    {        
        public void MainMenu(PetShelter shelter)
        {
            Console.WriteLine("Current Pet:  " + shelter.pet.Name);
            Console.WriteLine();
            shelter.pet.Decay();
            Console.Clear();
            Console.WriteLine("========= MAIN MENU =========");
            Console.WriteLine("1. Interact with " + shelter.pet.Name);
            Console.WriteLine("2. Display " + shelter.pet.Name + "'s Information");
            Console.WriteLine("3. Display " + shelter.pet.Name + "'s Status");
            Console.WriteLine("4. Display All Pet Information");
            Console.WriteLine("5. Switch Current Pet");
            Console.WriteLine("6. Create New Pet");
            Console.WriteLine("0. Quit Game");
            string menuSelection = Console.ReadLine();

            switch (menuSelection)
            {
                case "1":
                    PetInteractions(shelter);
                    break;
                case "2":
                    shelter.PetInfo();
                    MainMenu(shelter);
                    break;
                case "3":
                    shelter.PetStatus();
                    MainMenu(shelter);
                    break;
                case "4":
                    shelter.AllPets();
                    MainMenu(shelter);
                    break;
                case "5":
                    shelter.SwitchCurrentPet();
                    MainMenu(shelter);
                    break;
                case "6":
                    shelter.CreatePet();
                    MainMenu(shelter);
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Write("Please enter a valid selection. Press ENTER to try again.");
                    Console.ReadKey();
                    MainMenu(shelter);
                    break;
            }
        }

        public void PetInteractions(PetShelter shelter)
        {
            shelter.pet.Decay();
            Console.Clear();
            Console.WriteLine("What would you like to do with " + shelter.pet.Name + "?");
            Console.WriteLine("1. Play");
            Console.WriteLine("2. Feed");
            Console.WriteLine("3. Sleep");
            Console.WriteLine("4. Take to Bathroom");
            Console.WriteLine("5. Give Water");
            Console.WriteLine("0. Go Back to Main Menu");

            string interactionSelection = Console.ReadLine();

            switch (interactionSelection)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("You took " + shelter.pet.Name + " out to the park!");
                    Console.WriteLine(shelter.pet.Name + " had a great time!");
                    shelter.pet.Play();
                    Console.WriteLine();
                    Console.WriteLine(shelter.pet.Name + "'s Boredom is now: " + shelter.pet.Boredom);
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadKey();
                    PetInteractions(shelter);
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine(shelter.pet.Name + " devoured its food!");
                    shelter.pet.Feed();
                    Console.WriteLine();
                    Console.WriteLine(shelter.pet.Name + "'s Hunger is now: " + shelter.pet.Hunger);
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadKey();
                    PetInteractions(shelter);
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Zzzzzzzzzzzzzzzzzzz. " + shelter.pet.Name + " is taking a nap...");
                    shelter.pet.Rest();
                    Console.WriteLine();
                    Console.WriteLine(shelter.pet.Name + " is now fully rested!");
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadKey();
                    PetInteractions(shelter);
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine(shelter.pet.Name + " sniffs around...");
                    Console.WriteLine(shelter.pet.Name + " left a mess!");
                    shelter.pet.Poop();
                    Console.WriteLine();
                    Console.WriteLine(shelter.pet.Name + " successfully relieved itself!");
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadKey();
                    PetInteractions(shelter);
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine(shelter.pet.Name + " drinks some water!");
                    shelter.pet.Drink();
                    Console.WriteLine(shelter.pet.Name + " looks pleased!");
                    Console.WriteLine();
                    Console.WriteLine(shelter.pet.Name + "'s thirst is now: " + shelter.pet.Thirst);
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadKey();
                    PetInteractions(shelter);
                    break;
                case "0":
                    MainMenu(shelter);
                    break;
                default:
                    Console.WriteLine("Please enter a valid selection. Press ENTER to try again.");
                    Console.ReadKey();
                    PetInteractions(shelter);
                    break;

            }

        }


    }
}
