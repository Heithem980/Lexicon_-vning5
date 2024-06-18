namespace Lexicon_övning5.Vehicle
{
    internal class Airplane : Vehicle
    {

        private int _numberOfEngines;

        public Airplane(string registrationNumber, string color, int numberOfWheels, int weightKG, int maxSpeed, int numberOfEngines)
                        : base(registrationNumber, color, numberOfWheels, weightKG, maxSpeed)
        {
            _numberOfEngines = numberOfEngines;
        }


        public override string ToString()
        {
            return $"Reg: {RegistrationNumber}, Color: {Color}, Wheels: {NumberOfWheels}, Weight: {WeightKG}kg, " +
                $"MaxSpeed: {MaxSpeed}km/h, NumberOfEngines: {_numberOfEngines}";
        }
    }
}
