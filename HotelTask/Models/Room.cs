using System;
namespace Models
{
    public class Room
    {

        public Room(string name, double price, int personCapacity)
        {
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
            _id++;
            Id = _id;
        }

        private static int _id;

        public int Id { get;}
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAviable = true;

        public string ShowInfo()
        {
            return $"Name: {Name}, Price: {Price}, Person Capacity: {PersonCapacity}, {IsAviable}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
