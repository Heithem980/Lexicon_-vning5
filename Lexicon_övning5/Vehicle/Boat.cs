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



    }
}
