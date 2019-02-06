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
                    shelter.pet.PetInteractions();
                    break;
                case "2":
                    shelter.PetInfo();
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
    }
}
