namespace Lexicon_övning5.Vehicle
{
    internal class Motorcycle : Vehicle
    {
        private int _cylinderVolume;

        public Motorcycle(string registrationNumber, string color, int numberOfWheels, int weightKG, int maxSpeed, int cylinderVolume)
                        : base(registrationNumber, color, numberOfWheels, weightKG, maxSpeed)
        {
            _cylinderVolume = cylinderVolume;
        }

        public override string ToString()
        {
            return $"Reg: {RegistrationNumber}, Color: {Color}, Wheels: {NumberOfWheels}, Weight: {WeightKG}kg, MaxSpeed: {MaxSpeed}km/h, CylinderVolume: {_cylinderVolume}";
        }
    }
}
