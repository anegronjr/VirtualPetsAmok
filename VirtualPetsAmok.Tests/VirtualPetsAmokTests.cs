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

            Assert.Equal(pet.Name, pet.Name);
            Assert.Equal(pet.Species, pet.Species);
        }
    }
}
