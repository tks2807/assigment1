using System;
using System.Collections.Generic;
namespace assgmnt1
{
    public class Food
    {
        public Food()
        {

        }
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public double Kcal { get; set; } // callories

        public delegate List<Food> GetDelegateAll();
    }
}
