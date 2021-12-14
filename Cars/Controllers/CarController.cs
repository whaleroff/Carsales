using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using Cars.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cars.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : Controller
    {
        private readonly DataBaseContext db;
        
        public IEnumerable<Car> GetCar()
        {
            return db.Cars;
        }

        public Car GetCar(Guid id)
        {
            Car car = db.Cars.Find(id);
            return car;
        }

        [HttpPost]
        public void CreateCar([FromBody] Car car)
        {
            db.Cars.Add(car);
            db.SaveChanges();
        }
        
        [HttpPut]
        public void EditCar(Guid id, [FromBody] Car car)
        {
            if (id == car.Id)
            {
                db.Entry(car).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteCar(Guid id)
        {
            Car car = db.Cars.Find(id);
            if (car != null)
            {
                db.Cars.Remove(car);
                db.SaveChanges();
            }
        }
    }
}