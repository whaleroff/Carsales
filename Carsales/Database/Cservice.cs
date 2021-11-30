using Carsales.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsales.Database
{
    class Cservice : Organization 
    {
        public Guid Id { get; set; }
        public string _mail { get; set; }
        public Cservice()
        {
            _name = "Fitservice";
            _address = "Неизвестно";
            _city = "Город";
            _obl = "Область";
            _phone = "(999) - 000 - 00 - 00";
            _times = new(0, 0, 0);
            _timeo = new(0, 0, 0);
            _reg = 777;
            _mail = "cobaka@mail.ru";
        }

        public override void addToFavorite(string user)
        {
            throw new NotImplementedException();
        }

        public override void Form()
        {
            Console.WriteLine("Укажите номер или почту для обратной связи/n");
            string _conect = Console.ReadLine();
            Console.WriteLine("Спасибо, с вами свяжутся");
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Так же можно отправить письмо на эл.почту {_mail}");
        }
    }
}
