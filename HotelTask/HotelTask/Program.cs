using System;
using Models;
using Utilities.Exceptions;
namespace HotelTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();

            Room room1 = new Room("Otaq1", 100, 4);
            Room room2 = new Room("Otaq2", 200, 8);

            hotel.AddRoom(room1);
            hotel.AddRoom(room2);

            hotel.MakeReservation(1);
            foreach (var item in hotel.Rooms)
            {
                Console.WriteLine(item.IsAviable);
            }
        }
    }
}
