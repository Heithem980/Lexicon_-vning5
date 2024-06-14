namespace Lexicon_övning5.Vehicle
{
    internal class Car : Vehicle
    {
        private string _fuelType;

        public Car(string registrationNumber, string color, int numberOfWheels, int weightKG, int maxSpeed, string fuelType)
                    : base(registrationNumber, color, numberOfWheels, weightKG, maxSpeed)
        {
            _fuelType = fuelType;
        }
    }
}
