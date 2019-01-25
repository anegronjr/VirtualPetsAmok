using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public class VirtualPet
    {
        //Declaring variables.
        public string Name { get; set; }
        public string Species { get; set; }
        public int Hunger { get; set; }
        public int Fatigue { get; set; }
        public int Thirst { get; set; }
        public int Boredom { get; set; }
        public int Potty { get; set; }

       public VirtualPet() //Constructor method. Assigns random default values to class variables.
        {
            Random rnd = new Random();

            Hunger = rnd.Next(20, 50);
            Fatigue = rnd.Next(20, 50);
            Thirst = rnd.Next(20, 50);
            Boredom = rnd.Next(20, 50);
            Potty = rnd.Next(20, 50); 
       }
        public void Feed()
        {
            Random rnd = new Random();

            Hunger -= rnd.Next(5,10);
        }
        public void Rest()
        {
            Fatigue = 0;
        }

        public void Drink()
        {
            Random rnd = new Random();

            Thirst -= rnd.Next(5, 10);
        }

        public void Play()
        {
            Random rnd = new Random();

            Boredom -= rnd.Next(5, 10);
        }

        public void Poop()
        {
            Potty = 0;
        }

        public void Decay()
        {
            Random random = new Random();

            Hunger += random.Next(1, 5);
            Thirst += random.Next(1, 5);
            Boredom += random.Next(1, 5);
            Potty += random.Next(1, 5);
            Fatigue += random.Next(1, 5);
        }
    }
}
