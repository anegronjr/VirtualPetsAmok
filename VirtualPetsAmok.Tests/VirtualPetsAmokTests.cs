using System;
using Xunit;

namespace VirtualPetsAmok.Tests
{
    public class VirtualPetsAmokTests
    {
        [Fact]
        public void Creates_First_Pet()
        {
            VirtualPet pet = new VirtualPet();
        }
        [Fact]
        public void Pets_In_List()
        {


        }

        [Fact]
        public void Pet_Has_Name()
        {
            // ARRANGE
            var myPet = new VirtualPet();

            // ACT
            myPet.Name = "Byte";

            // ASSERT
            Assert.Equal("Byte", myPet.Name);
        }

        [Fact]
        public void Pet_Has_Species()
        {
            var myPet = new VirtualPet();

            myPet.Species = "Dog";

            Assert.Equal("Dog", myPet.Species);
        }

        [Fact]
        public void Pet_Has_Hunger()
        {
            var myPet = new VirtualPet();

            myPet.Hunger = 42;

            Assert.Equal(42, myPet.Hunger);
        }

        [Fact]
        public void Pet_Has_Fatigue()
        {
            var myPet = new VirtualPet();

            myPet.Fatigue = 42;

            Assert.InRange(myPet.Fatigue, 20, 50);
        }

        [Fact]
        public void Pet_Has_Thirst()
        {
            var myPet = new VirtualPet();

            myPet.Thirst = 42;

            Assert.InRange(myPet.Thirst, 20, 50);
        }

        [Fact]
        public void Pet_Has_Boredom()
        {
            var myPet = new VirtualPet();

            myPet.Boredom = 42;

            Assert.InRange(myPet.Boredom, 20, 50);
        }

        [Fact]
        public void Pet_Has_Potty()
        {
            var myPet = new VirtualPet();

            myPet.Potty = 42;

            Assert.InRange(myPet.Potty, 20, 50);
        }

        [Fact]
        public void Feed_Decrease_Hunger()
        {
            var myPet = new VirtualPet();

            myPet.Hunger = 42;

            myPet.Feed();

            Assert.InRange(myPet.Hunger, 32, 37);
        }

        [Fact]
        public void Rest_Decrease_Fatigue()
        {
            var myPet = new VirtualPet();

            myPet.Rest();

            Assert.Equal(0, myPet.Fatigue);
        }

        [Fact]
        public void Drink_Decrease_Thirst()
        {
            var myPet = new VirtualPet();

            myPet.Thirst = 42;

            myPet.Drink();

            Assert.InRange(myPet.Thirst, 32, 37);
        }

        [Fact]
        public void Play_Decrease_Boredom()
        {
            var myPet = new VirtualPet();

            myPet.Boredom = 42;

            myPet.Play();

            Assert.InRange(myPet.Boredom, 32, 37);
        }

        [Fact]
        public void Poop_Decrease_Potty()
        {
            var myPet = new VirtualPet();

            myPet.Poop();

            Assert.Equal(0, myPet.Potty);
        }
        
        [Fact]
        public void Decay_Affects_Status()
        {
            var myPet = new VirtualPet();
            myPet.Hunger = 42;

            myPet.Decay();

            Assert.InRange(myPet.Hunger, 37, 41);
        }
    }

}
