using Lexicon_övning5.Interface;
using System.Collections;

namespace Lexicon_övning5.Garage
{
    internal class Garage<T> : IEnumerable<T> where T : IVehicle
    {


        private T[] vehicles; // Array för att lagra fordon
        private int capacity; // Max kapacitet för garaget
        private int count; // Nuvarande antal fordon i garaget


        public Garage(int capacity)
        {
            this.capacity = capacity;
            vehicles = new T[capacity];
            count = 0;
        }



        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }



        public bool AddVehicle(T vehicle)
        {
            if (vehicles.Length < capacity)
            {
                vehicles[count] = vehicle; // Lägg till fordonet i arrayen
                count++;

                Console.WriteLine($"Vehicle succesfully added to garage in place {count}. Max capacity: {capacity}");
                return true;
            }
            else
            {

                Console.WriteLine($"Could not add vehicle. Garage full!");
                return false;
            }


            //throw new NotImplementedException();
        }


        public T FindVehicle(string registrationNumber)
        {
            for (int i = 0; i < count; i++)
            {
                if (vehicles[i].RegistrationNumber == registrationNumber)
                {
                    return vehicles[i];
                }
            }
            return default(T);
        }
    }
}
