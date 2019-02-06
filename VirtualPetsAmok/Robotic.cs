using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public class Robotic : VirtualPet
    {
        public int OilLevel { get; private set; }
        public int BatteryLevel { get; private set; }
        public int Temperature { get; private set; }

        public Robotic()
        {
            Random rnd = new Random();
            Type = "Robotic";
            OilLevel = rnd.Next(20, 50);
            BatteryLevel = rnd.Next(20, 50);
            Temperature = rnd.Next(20, 50);
        }

        public void OilChange()
        {
            OilLevel = 100;
        }

        public void ChargeBattery()
        {
            BatteryLevel = 100;
        }

        public void CoolDown()
        {
            Temperature = 0;
        }

        public override void ShowStatus()
        {
        }

        public override void Decay()
        {
            Random random = new Random();

            OilLevel -= random.Next(10, 20);
            BatteryLevel -= random.Next(10, 20);
            Temperature += random.Next(10, 20);
        }
    }
}
