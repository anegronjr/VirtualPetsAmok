using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public class PetShelter
    {
        public List<VirtualPet> Pets { get; set; }
        public int CurrentPet { get; set; }


        public PetShelter()
        {
            Pets = new List<VirtualPet>();
            CurrentPet = 0;
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
            foreach (VirtualPet line in Pets)
            {
                Console.WriteLine((position += 1) + ". Name: " + line.Name + "     Species: " + line.Species);
            }
            Console.WriteLine("Press any key to go to Main Menu.");
            Console.ReadKey();
            //MainMenu();
        }
    }
}
