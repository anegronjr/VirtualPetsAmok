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
        static Animations animation = new Animations();



        public PetShelter()
        {
            firstPet = new Organic();
            Pets = new List<VirtualPet>();
            Pets.Add(firstPet);
            CurrentPet = 0;
            pet = Pets[CurrentPet];
        }

        public void Add(VirtualPet pet)
        {
            Pets.Add(pet);
        }

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
            Console.WriteLine("Pet Type: " + pet.Type);
            Console.WriteLine("Pet Species: " + pet.Species);
            Console.WriteLine();
            Console.WriteLine("Press ENTER to return to the Main Menu.");
            Console.ReadKey();
        }

        public void CreatePet()
        {
            Console.Clear();
            Console.WriteLine("What kind of pet would you like to make?");
            Console.WriteLine("1. Organic Pet");
            Console.WriteLine("2. Robotic Pet");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CreateOrganicPet();
                    break;
                case "2":
                    CreateRoboticPet();
                    break;
                default:
                    Console.WriteLine("Please enter a valid choice. Press ENTER to try again");
                    Console.ReadKey();
                    CreatePet();
                    break;
            }
        }

        public void CreateOrganicPet()
        {
            Organic newPet = new Organic();

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

        public void CreateRoboticPet()
        {
            Robotic newPet = new Robotic();

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

        public void GameStart(PetShelter shelter)
        {

            pet = shelter.Pets[shelter.CurrentPet];

            Console.WriteLine("Thanks for playing Virtual Pets Amok!");
            Console.WriteLine("We'll start by creating your first pet.");
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadKey();
            Console.Clear();
            animation.loadingScreen();
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
                } while (run);

                Console.Clear();
                Console.WriteLine("Congratulations! Your new pet " + pet.Species + ", " + pet.Name + ", is ready to go!");
                Console.WriteLine("Press ENTER to go to the main menu.");
                Console.ReadKey();


        }


        
    }
}
