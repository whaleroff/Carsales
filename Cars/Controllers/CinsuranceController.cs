using System;
using System.Collections.Generic;
using System.Data.Entity;
using Cars.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cars.Controllers
{
    
    public class CinsuranceController : Controller
    {
        private readonly DataBaseContext db;
        
        public IEnumerable<Cinsurance> GetCinsurances()
        {
            return db.Cinsurances;
        }

        public Cinsurance GetCinsurances(Guid id)
        {
            Cinsurance cinsurance = db.Cinsurances.Find(id);
            return cinsurance;
        }

        [HttpPost]
        public void CreateCinsurances([FromBody] Cinsurance cinsurance)
        {
            db.Cinsurances.Add(cinsurance);
            db.SaveChanges();
        }
        
        [HttpPut]
        public void EditCinsurances(Guid id, [FromBody] Cinsurance cinsurance)
        {
            if (id == cinsurance.Id)
            {
                db.Entry(cinsurance).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteCinsurance(Guid id)
        {
            Cinsurance cinsurance = db.Cinsurances.Find(id);
            if (cinsurance != null)
            {
                db.Cinsurances.Remove(cinsurance);
                db.SaveChanges();
            }
        }
    }
}