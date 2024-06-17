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




        bool IHandler.AddVehicle(IVehicle vehicle)
        {


            return garage.AddVehicle(vehicle);
        }


        /*
        bool IHandler.RemoveVehicle(string registrationNumber)
        {
            throw new NotImplementedException();
        }

        IVehicle IHandler.FindVehicle(string registrationNumber)
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
