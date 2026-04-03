using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    public class CarsCollection
    {
        private List<Car> cars;
        
        public int Count => cars.Count;
        public CarsCollection()
        {
            cars = new List<Car>();
        }
        public void AddCar(Car car)
        {
            cars.Add(car);
        }
        public void RemoveCollection()
        {
            Console.WriteLine("Триває видалення...");
            cars.Clear();
        }
        public Car this[int index]
        {
            get
            {
                if (index < 0 || index >= cars.Count)
                    throw new IndexOutOfRangeException("За цим індексом не закріплена жодна машина");
                return cars[index];
            }
        }
    }
}
