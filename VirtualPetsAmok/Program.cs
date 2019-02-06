using System;
using System.Collections.Generic;

namespace VirtualPetsAmok
{
    class Program
        {
            public static PetShelter shelter = new PetShelter();
            static Menu menu = new Menu();
            
            static void Main(string[] args)
            {
                shelter.GameStart(shelter);
                menu.MainMenu(shelter);
            }
        }
}
