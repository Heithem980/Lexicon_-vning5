namespace Lexicon_övning5.Vehicle
{
    internal class Boat : Vehicle
    {

        private double _length;

        public Boat(string registrationNumber, string color, int numberOfWheels, int weightKG, int maxSpeed, double length)
                    : base(registrationNumber, color, numberOfWheels, weightKG, maxSpeed)
        {
            _length = length;
        }

        public override string ToString()
        {
            return $"Reg: {RegistrationNumber}, Color: {Color}, Wheels: {NumberOfWheels}, Weight: {WeightKG}kg, MaxSpeed: {MaxSpeed}km/h, Length: {_length}";
        }

    }
}
