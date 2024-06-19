namespace Lexicon_övning5.Vehicle
{
    public class Car : Vehicle
    {
        private string _fuelType;

        public Car(string registrationNumber, string color, int numberOfWheels, int weightKG, int maxSpeed, string fuelType)
                    : base(registrationNumber, color, numberOfWheels, weightKG, maxSpeed)
        {
            _fuelType = fuelType;
        }

        public override string ToString()
        {
            return $"Reg: {RegistrationNumber}, Color: {Color}, Wheels: {NumberOfWheels}, Weight: {WeightKG}kg, MaxSpeed: {MaxSpeed}km/h, FuelType: {_fuelType}";
        }
    }
}
