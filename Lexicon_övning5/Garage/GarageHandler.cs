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

        public bool GetGarageCapacity()
        {

            return garage.GetCapacity() >= 5;
        }
    }
}
