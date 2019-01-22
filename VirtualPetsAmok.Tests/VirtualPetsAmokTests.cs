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
    }
}
