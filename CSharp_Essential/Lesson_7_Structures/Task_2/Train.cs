using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Task_2
{
    internal struct Train : IComparable<Train>
    {
       
        public string Destination { get; private set;  }
        public int TrainNumber { get; private set; }    
        public TimeOnly DepartureTime { get; private set; }
        public Train(string destination, int trainNumber, TimeOnly departureTime)
        {
            this.Destination = destination;
            this.TrainNumber = trainNumber;
            this.DepartureTime = departureTime;
        }
        public int CompareTo(Train other) 
        {
            return this.TrainNumber.CompareTo(other.TrainNumber);
        }
    }
}
