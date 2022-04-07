using System;
using Utilities.Exceptions;

namespace Models
{
    public class Hotel
    {
        public string Name { get; set; }
        Room[] _rooms = new Room[0];
        public Room[] Rooms { get => _rooms; }
        public void AddRoom(Room room)
        {
            Array.Resize(ref _rooms, _rooms.Length + 1);
            _rooms[_rooms.Length - 1] = room;
        }
        public bool MakeReservation(int? roomId)
        {
            try
            {
                throw new NotAvailableException {Message = "Null problem" };
            }
            catch(NotAvailableException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
