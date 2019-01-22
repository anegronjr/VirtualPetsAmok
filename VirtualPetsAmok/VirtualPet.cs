using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public class VirtualPet
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Hunger { get; set; }
        public int Fatigue { get; set; }
        public int Thirst { get; set; }
        public int Boredom { get; set; }
        public int Potty { get; set; }

       public VirtualPet() 
       {
            Random rnd = new Random();

            Hunger = rnd.Next(20, 50);
            Fatigue = rnd.Next(20, 50);
            Thirst = rnd.Next(20, 50);
            Boredom = rnd.Next(20, 50);
            Potty = rnd.Next(20, 50);
       }
    }
}
