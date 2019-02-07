using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public static class Menu
    {        
        public static void MainMenu(PetShelter shelter)
        {
            shelter.pet.Decay();

            Console.WriteLine("Current Pet:  " + shelter.pet.Name);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("========= MAIN MENU =========");
            Console.WriteLine("1. Interact with " + shelter.pet.Name);
            Console.WriteLine("2. Display " + shelter.pet.Name + "'s Information");
            Console.WriteLine("3. Display " + shelter.pet.Name + "'s Status");
            Console.WriteLine("4. Display Information for All Pets");
            Console.WriteLine("5. Interact with All Pets");
            Console.WriteLine("6. Display Status of All Pets");
            Console.WriteLine("7. Switch Current Pet");
            Console.WriteLine("8. Create New Pet");
            Console.WriteLine("9. Remove a Pet from the Shelter.");
            Console.WriteLine("0. Quit Game");

            string menuSelection = Console.ReadLine();

            switch (menuSelection)
            {
                case "1":
                    shelter.pet.PetInteractions(shelter);
                    break;
                case "2":
                    shelter.pet.ShowInfo();
                    MainMenu(shelter);
                    break;
                case "3":
                    shelter.pet.ShowStatus();
                    MainMenu(shelter);
                    break;
                case "4":
                    shelter.AllPets();
                    MainMenu(shelter);
                    break;
                case "5":
                    shelter.AllInteract();
                    MainMenu(shelter);
                    break;
                case "6":
                    Console.Clear();
                    shelter.AllStatus();
                    MainMenu(shelter);
                    break;
                case "7":
                    shelter.SwitchCurrentPet();
                    MainMenu(shelter);
                    break;
                case "8":
                    shelter.CreatePet();
                    MainMenu(shelter);
                    break;
                case "9":
                    shelter.RemovePet();
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
    }
}
