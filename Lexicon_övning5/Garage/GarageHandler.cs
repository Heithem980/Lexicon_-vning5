using Lexicon_övning5.Interface;

namespace Lexicon_övning5.Garage
{
    internal class GarageHandler : IHandler
    {


        private Garage<IVehicle> garage;




        public GarageHandler(int capacity)
        {
            garage = new Garage<IVehicle>(capacity);
        }




        public bool AddVehicle(IVehicle vehicle)
        {


            return garage.AddVehicle(vehicle);
        }

        public IVehicle FindVehicle(string registrationNumber)
        {

            return garage.FindVehicle(registrationNumber);
            //throw new NotImplementedException();
        }



        public bool RemoveVehicle(string registrationNumber)
        {
            return garage.RemoveVehicle(registrationNumber);
        }

        public IEnumerable<IVehicle> ListVehicles()
        {
            return garage.ToArray();
        }

        public IEnumerable<IVehicle> SearchVehicles(string registrationNumber, string color, int numberOfWheels, int weightKG, int maxSpeed)
        {
            return garage.Where(vehicle =>
                (string.IsNullOrEmpty(registrationNumber) || vehicle.RegistrationNumber.Equals(registrationNumber, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(color) || vehicle.Color.Equals(color, StringComparison.OrdinalIgnoreCase)) &&
                (numberOfWheels == 0 || vehicle.NumberOfWheels == numberOfWheels) &&
                (weightKG == 0 || vehicle.WeightKG == weightKG) &&
                (maxSpeed == 0 || vehicle.MaxSpeed == maxSpeed)
            );
        }

        public bool GetGarageCapacity()
        {

            return garage.GetCapacity() >= 5;
        }
    }
}
