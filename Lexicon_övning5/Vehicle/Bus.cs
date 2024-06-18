namespace Lexicon_övning5.Vehicle
{
    internal class Bus : Vehicle
    {
        private int _numberOfSeats;

        public Bus(string registrationNumber, string color, int numberOfWheels, int weightKG, int maxSpeed, int numberOfSeats)
                    : base(registrationNumber, color, numberOfWheels, weightKG, maxSpeed)
        {
            _numberOfSeats = numberOfSeats;
        }


        public override string ToString()
        {
            return $"Reg: {RegistrationNumber}, Color: {Color}, Wheels: {NumberOfWheels}, Weight: {WeightKG}kg, MaxSpeed: {MaxSpeed}km/h, NumberOfSeats: {_numberOfSeats}";
        }
    }
}
