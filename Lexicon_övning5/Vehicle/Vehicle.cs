using Lexicon_övning5.Interface;

namespace Lexicon_övning5.Vehicle
{
    public abstract class Vehicle : IVehicle
    {
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        public int NumberOfWheels { get; set; }

        public int WeightKG { get; set; }

        public int MaxSpeed { get; set; }



        public Vehicle(string registrationNumber, string color, int numberOfWheels, int weightKG, int maxSpeed)
        {
            RegistrationNumber = registrationNumber;
            Color = color;
            NumberOfWheels = numberOfWheels;
            this.WeightKG = weightKG;
            this.MaxSpeed = maxSpeed;
        }


        public override string ToString()
        {
            return $"Reg: {RegistrationNumber}, Color: {Color}, Wheels: {NumberOfWheels}, Weight: {WeightKG}kg, MaxSpeed: {MaxSpeed}km/h";
        }

    }
}
