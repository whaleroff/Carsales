using Carsales.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsales.Database
{
    class Cparts : Organization
    {
        public Guid Id { get; set; }
        public double _rate { get; set; }
        public Cparts()
        {
            _name = "Fitservice";
            _address = "Неизвестно";
            _city = "Город";
            _obl = "Область";
            _phone = "(999) - 000 - 00 - 00";
            _times = new(0, 0, 0);
            _timeo = new(0, 0, 0);
            _reg = 777;
            _rate = 5.0;
        }

        public override void Form()
        {
            throw new NotImplementedException();
        }

        public override void addToFavorite(string user)
        {
            throw new NotImplementedException();
        }
    }
}
