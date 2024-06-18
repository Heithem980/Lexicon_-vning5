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
            throw new NotImplementedException();
        }


        /*
        bool IHandler.RemoveVehicle(string registrationNumber)
        {
            throw new NotImplementedException();
        }

        

        IEnumerable<IVehicle> IHandler.ListVehicles()
        {
            throw new NotImplementedException();
        }
        */
    }
}
