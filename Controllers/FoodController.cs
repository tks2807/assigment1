using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace assgmnt1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        public List<Food> list;
        public List<Food> list2;
        
        public FoodController()
        {
            list = new List<Food>();
            list2 = new List<Food>();

            Food f1 = new Food()
            {
                Id = 1,
                Kcal = 120.5,
                Name = "Rice",
                Type = "Second Course"
            };
            list.Add(f1);
          

            Food f2 = new Food()
            {
                Id = 2,
                Kcal = 220.5,
                Name = "Borsch",
                Type = "First Course"
            };
            list.Add(f2);

            Food f3 = new Food()
            {
                Id = 3,
                Kcal = 150.5,
                Name = "Pasta",
                Type = "Second Course"
            };
            list.Add(f3);

            Food f4 = new Food()
            {
                Id = 4,
                Kcal = 190.5,
                Name = "Cheesecake",
                Type = "Dessert"
            };
            list.Add(f4);

            Food f5 = new Food()
            {
                Id = 5,
                Kcal = 520.5,
                Name = "Ribeye",
                Type = "Second Course"
            };
            list.Add(f5);

            Food f6 = new Food()
            {
                Id = 6,
                Kcal = 220.5,
                Name = "Caesar",
                Type = "Salad"
            };
            list.Add(f6);

            Food f7 = new Food()
            {
                Id = 7,
                Kcal = 320.5,
                Name = "Pizza",
                Type = "Second Course"
            };
            list.Add(f7);

            Food f8 = new Food()
            {
                Id = 8,
                Kcal = 20.5,
                Name = "Juice",
                Type = "Drink"
            };
            list.Add(f8);

            Food f9 = new Food()
            {
                Id = 9,
                Kcal = 0.0,
                Name = "Water",
                Type = "Drink"
            };
            list.Add(f9);

            Food f10 = new Food()
            {
                Id = 10,
                Kcal = 60.5,
                Name = "Greek Salad",
                Type = "Salad"
            };
            list.Add(f10);

            Food.GetDelegateAll dlgt = new Food.GetDelegateAll(GetAll);
            list2 = dlgt();
        }


        [HttpGet("/id/{Id}")]
        public List<Food> GetFoodById(int id)
        {
            var food = list.Where(food => food.Id == id);
            return food.ToList();
        }

        [HttpGet("/kcal/{Kcal}")]
        public List<Food> GetFoodByKcal(double kcal)
        {
            var food = list.Where(food => food.Kcal == kcal);
            return food.ToList();
        }

        [HttpGet("/name/{Name}")]
        public List<Food> GetFoodByName(string name)
        {
            var food = list.Where(food => food.Name == name);
            return food.ToList();
        }

        [HttpGet("/type/{Type}")]
        public List<Food> GetFoodByType(string type)
        {
            var food = list.Where(food => food.Type == type);
            return food.ToList();
        }

        [HttpGet]
        public List<Food> GetAll()
        {
            return list;
        }

        [HttpGet ("/getalldelegate")] 
        public List<Food> GetListDelegate() //get all using delegate sorted by name
        {
            return list2.OrderBy(list => list.Name).ToList();
        }
    } 
}
