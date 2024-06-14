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
    }
}
