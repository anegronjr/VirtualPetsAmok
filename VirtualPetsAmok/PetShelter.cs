using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public class PetShelter
    {
        public List<VirtualPet> Pets { get; set; }
        public int CurrentPet { get; set; }
        public static Menu menu = new Menu();
        public VirtualPet firstPet;
        public VirtualPet pet;



        public PetShelter()
        {
            firstPet = new VirtualPet();
            Pets = new List<VirtualPet>();
            Pets.Add(firstPet);
            CurrentPet = 0;
            pet = Pets[CurrentPet];
        }

        public void Add(VirtualPet pet)
        {
            Pets.Add(pet);
        }

        //Method that displays information for all pets.
        public void AllPets()
        {
            Console.Clear();
            int position = 0;
            foreach (VirtualPet pet in Pets)
            {
                Console.WriteLine((position += 1) + ". Name: " + pet.Name + "     Species: " + pet.Species);
            }
            Console.WriteLine("Press any key to go to Main Menu.");
            Console.ReadKey();
            //MainMenu();
        }

        //Method that allows user to switch current pet.
        public void SwitchCurrentPet()
        {
            Console.Clear();
            Console.WriteLine("Which pet would you like to look after?");
            Console.WriteLine();

            int position = 0;
            foreach (VirtualPet line in Pets)
            {
                Console.WriteLine((position += 1) + ". Name: " + line.Name + "     Species: " + line.Species);
            }

            CurrentPet = Int32.Parse(Console.ReadLine());
            CurrentPet--;

            pet = Pets[CurrentPet];

            Console.Clear();
            Console.WriteLine("Your current pet is now " + pet.Name + "!");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadKey();
        }

        public void PetInfo()
        {
            Console.Clear();
            pet.DrawPicture();
            Console.WriteLine("Pet Name: " + pet.Name);
            Console.WriteLine("Pet Species: " + pet.Species);
            Console.WriteLine();
            Console.WriteLine("Press ENTER to return to the Main Menu.");
            Console.ReadKey();
        }
        
        //Method that creates new pets.
        public void CreatePet()
        {
            //int numPets = Pets.Count;
            VirtualPet newPet = new VirtualPet();

            Console.Clear();
            Console.WriteLine("Please name your new pet: ");
            newPet.Name = Console.ReadLine();
            Console.Clear();
            bool runNew = true;
            do
            {
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

            Pets.Add(newPet);

            Console.Clear();
            Console.WriteLine("Congratulations! Your new pet " + newPet.Species + ", " + newPet.Name + ", is ready to go!");
            Console.WriteLine("Press ENTER to go to the main menu.");
            Console.ReadKey();
        }

        public void PetStatus()
        {
            Console.Clear();
            pet.DrawPicture();
            Console.WriteLine("Boredom: " + pet.Boredom);
            Console.WriteLine("Hunger: " + pet.Hunger);
            Console.WriteLine("Fatigue: " + pet.Fatigue);
            Console.WriteLine("Potty: " + pet.Potty);
            Console.WriteLine("Thirst: " + pet.Thirst);
            Console.WriteLine();
            Console.WriteLine("Press ENTER to return to the Main Menu.");
            Console.ReadKey();
        }

        public void GameStart(PetShelter shelter)
        {

            pet = shelter.Pets[shelter.CurrentPet];

            Console.WriteLine("Thanks for playing Virtual Pets Amok!");
            Console.WriteLine("We'll start by creating your first pet.");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadKey();
            Console.Clear();
            //shelter.CurrentPet = 0;

            //menu.MainMenu(shelter);

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
                } while (run);

                Console.Clear();
                Console.WriteLine("Congratulations! Your new pet " + pet.Species + ", " + pet.Name + ", is ready to go!");
                Console.WriteLine("Press ENTER to go to the main menu.");
                Console.ReadKey();
        }
    }
}
