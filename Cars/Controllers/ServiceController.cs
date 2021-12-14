using System;
using System.Collections.Generic;
using System.Data.Entity;
using Cars.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cars.Controllers
{
   
    public class ServiceController : Controller
    {
        private readonly DataBaseContext db;
        
        public IEnumerable<Service> GetService()
        {
            return db.Services;
        }

        public Service GetService(Guid id)
        {
            Service service = db.Services.Find(id);
            return service;
        }

        [HttpPost]
        public void CreateService([FromBody] Service service)
        {
            db.Services.Add(service);
            db.SaveChanges();
        }
        
        [HttpPut]
        public void EditService(Guid id, [FromBody] Service service)
        {
            if (id == service.Id)
            {
                db.Entry(service).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteService(Guid id)
        {
            Service service = db.Services.Find(id);
            if (service != null)
            {
                db.Services.Remove(service);
                db.SaveChanges();
            }
        }
    }
}