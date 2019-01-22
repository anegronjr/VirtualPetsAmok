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

            Assert.Equal(42, myPet.Fatigue);
        }

        [Fact]
        public void Pet_Has_Thirst()
        {
            var myPet = new VirtualPet();

            myPet.Thirst = 42;

            Assert.Equal(42, myPet.Thirst);
        }

        [Fact]
        public void Pet_Has_Boredom()
        {
            var myPet = new VirtualPet();

            myPet.Boredom = 42;

            Assert.Equal(42, myPet.Boredom);
        }

        [Fact]
        public void Pet_Has_Potty()
        {
            var myPet = new VirtualPet();

            myPet.Potty = 42;

            Assert.Equal(42, myPet.Potty);
        }
    }
}
