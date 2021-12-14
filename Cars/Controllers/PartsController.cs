using System;
using System.Collections.Generic;
using System.Data.Entity;
using Cars.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cars.Controllers
{
    
    public class PartsController : Controller
    {
        private readonly DataBaseContext db;
        
        public IEnumerable<Parts> GetParts()
        {
            return db.PartsEnumerable;
        }

        public Parts GetParts(Guid id)
        {
            Parts parts = db.PartsEnumerable.Find(id);
            return parts;
        }

        [HttpPost]
        public void CreateParts([FromBody] Parts parts)
        {
            db.PartsEnumerable.Add(parts);
            db.SaveChanges();
        }
        
        [HttpPut]
        public void EditParts(Guid id, [FromBody] Parts parts)
        {
            if (id == parts.Id)
            {
                db.Entry(parts).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteParts(Guid id)
        {
            Parts parts = db.PartsEnumerable.Find(id);
            if (parts != null)
            {
                db.PartsEnumerable.Remove(parts);
                db.SaveChanges();
            }
        }
    }
}