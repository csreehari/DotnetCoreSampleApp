using System;
namespace OdeToFood.Models
{
    public class Restaurant
    {
        public Restaurant()
        {
            
        }
        public Restaurant(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public CuisineType Cuisine
        {
            get;
            set;
        }
    }
}
