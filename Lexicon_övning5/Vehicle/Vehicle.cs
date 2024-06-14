using Lexicon_övning5.Interface;

namespace Lexicon_övning5.Vehicle
{
    internal abstract class Vehicle : IVehicle
    {
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        public int NumberOfWheels { get; set; }

        public int weightKG { get; set; }

        public int maxSpeed { get; set; }



        public Vehicle(string registrationNumber, string color, int numberOfWheels, int weightKG, int maxSpeed)
        {
            RegistrationNumber = registrationNumber;
            Color = color;
            NumberOfWheels = numberOfWheels;
            this.weightKG = weightKG;
            this.maxSpeed = maxSpeed;
        }
    }
}
