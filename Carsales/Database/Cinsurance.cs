﻿using Carsales.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsales.Database
{
    class Cinsurance : Organization
    {
        public Guid Id { get; set; }
        public bool _open { get; set; }
        public Cinsurance()
        {
            _name = "Fitservice";
            _address = "Неизвестно";
            _city = "Город";
            _obl = "Область";
            _phone = "(999) - 000 - 00 - 00";
            _times = new(0, 0, 0);
            _timeo = new(0, 0, 0);
            _reg = 777;
            _open = true;
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
