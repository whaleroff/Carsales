using System;
using System.Collections.Generic;
using System.Data.Entity;
using Cars.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cars.Controllers
{
    
    public class PoliceController : Controller
    {
        private readonly DataBaseContext db;
        
        public IEnumerable<Police> GetPolices()
        {
            return db.Polices;
        }

        public Police GetPolice(Guid id)
        {
            Police police = db.Polices.Find(id);
            return police;
        }

        [HttpPost]
        public void CreatePolice([FromBody] Police police)
        {
            db.Polices.Add(police);
            db.SaveChanges();
        }
        
        [HttpPut]
        public void EditPolice(Guid id, [FromBody] Police police)
        {
            if (id == police.Id)
            {
                db.Entry(police).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeletePolice(Guid id)
        {
            Police police = db.Polices.Find(id);
            if (police != null)
            {
                db.Polices.Remove(police);
                db.SaveChanges();
            }
        }
    }
}