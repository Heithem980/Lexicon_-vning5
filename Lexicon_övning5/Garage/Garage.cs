using Lexicon_övning5.Interface;
using System.Collections;

namespace Lexicon_övning5.Garage
{
    internal class Garage<T> : IEnumerable<T> where T : IVehicle
    {


        private T[] vehicles;
        private int capacity;
        private int count;


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


            throw new NotImplementedException();
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
