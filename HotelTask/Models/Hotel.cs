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
        public void MakeReservation(int? roomId)
        {
            if (roomId != null)
            {
                foreach (var item in Rooms)
                {
                    if (item.Id == roomId)
                    {
                        if (item.IsAviable == true)
                        {
                            item.IsAviable = false;
                        }
                        else
                        {
                            throw new NotAvailableException("Available deyil!");
                        }
                    }
                }
             
            }
            else
            {
                throw new NullReferenceException();
            }
        }
    }
}
