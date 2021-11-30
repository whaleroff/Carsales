using Carsales.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsales.Database
{
    class Police : Organization
    {
        public Guid Id { get; set; }
        public int _otdel { get; set; }
        public Police()
        {
            _name = "ГАИ";
            _address = "Неизвестно";
            _city = "Город";
            _obl = "Область";
            _phone = "(999) - 000 - 00 - 00";
            _times = new(0, 0, 0);
            _timeo = new(0, 0, 0);
            _reg = 777;
            _otdel = 140894;
        }
        public override void addToFavorite(string user)
        {
            throw new NotImplementedException();
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Номер отделения: {_otdel}");
        }
        override public void Form()
        {
            Console.WriteLine($"Обратитесь по номеру {_phone}/n" +
                $"Или пройдите в ближайшее отделение/n" +
                $"Например: {_name}, по адресу {_address} в городе {_city}({_reg}) по {_obl} области/n" +
                $"Время работы c {_times} до {_timeo}");
        }


    }
}
