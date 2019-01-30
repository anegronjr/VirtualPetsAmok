using System;
using System.Collections.Generic;

namespace VirtualPetsAmok
{
    class Program
        {
            //Creates first instance of Shelter Class.
            public static PetShelter shelter = new PetShelter();
            //public static VirtualPet pet;
            static Menu menu = new Menu();
            

            static void Main(string[] args)
            {
               
                shelter.GameStart(shelter);
                menu.MainMenu(shelter);
            }
        }
}
