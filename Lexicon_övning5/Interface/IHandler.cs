namespace Lexicon_övning5.Interface
{
    internal interface IHandler
    {
        bool AddVehicle(IVehicle vehicle);



        bool RemoveVehicle(string registrationNumber);
        IVehicle FindVehicle(string registrationNumber);
        IEnumerable<IVehicle> ListVehicles();



        //void CreateGarage();
    }
}
