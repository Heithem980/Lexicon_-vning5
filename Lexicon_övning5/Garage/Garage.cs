using Lexicon_övning5.Interface;
using System.Collections;

namespace Lexicon_övning5.Garage
{
    internal class Garage<T> : IEnumerable<T> where T : IVehicle
    {


        private T[] vehicles; // Array för att lagra fordon
        private int capacity;   // Max kapacitet för garaget

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
            if (count < capacity)
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

        public bool RemoveVehicle(string registrationNumber)
        {
            for (int i = 0; i < count; i++)
            {
                if (vehicles[i].RegistrationNumber.Equals(registrationNumber, StringComparison.OrdinalIgnoreCase))
                {
                    vehicles[i] = vehicles[--count];
                    vehicles[count] = default(T);
                    Console.WriteLine("Vehicle removed successfully.");
                    return true;
                }
            }
            Console.WriteLine("Vehicle not found.");
            return false;
        }


        public T FindVehicle(string registrationNumber)
        {
            for (int i = 0; i < count; i++)
            {
                if (vehicles[i].RegistrationNumber.Equals(registrationNumber, StringComparison.OrdinalIgnoreCase))
                {
                    return vehicles[i];
                }
            }
            return default(T);
        }

        public T[] ToArray()
        {
            T[] array = new T[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = vehicles[i];
            }
            return array;
        }

        public int GetCapacity()
        {
            return capacity;
        }

    }
}
