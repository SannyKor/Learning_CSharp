using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Task_3_Clone_
{
    public class House
    {
        string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        List<Room> rooms;
        public House(string address, List<Room> rooms)
        {
            this.address = address;
            this.rooms = rooms;
        }
        public Room this[int index]
        {
            get { return rooms[index]; }
            set { rooms[index] = value; }
        }
        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }
        public House Clone()
        {
            return (House)this.MemberwiseClone();
        }
        public House DeepClone()
        {
            List<Room> clonedRooms = new List<Room>();
            foreach (var room in rooms)
            {
                clonedRooms.Add(new Room(room.Name));
            }
            return new House(address, clonedRooms);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Адреса: {address}");
            sb.AppendLine("Кімнати:");
            foreach (var room in rooms)
            {
                sb.AppendLine($"- {room.Name}");
            }
            return sb.ToString();
        }
    }
}
