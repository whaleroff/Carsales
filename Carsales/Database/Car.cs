using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsales.Database
{
    public class Car 
    {

        public Guid Id { get; set; }
        public string _name { get; set; }       //название машины
        public double _price { get; set; }     //ценник
        public int _year { get; set; }          //год выпуска
        public double _mileage { get; set; }    //пробег
        public string _comment { get; set; }    //комментарий владельца/завода 
        public Car()
        {
            _name = "Отсутствует";
            _price = 0.0;
            _year = 0;
            _mileage = 0.0;
            _comment = " ";
        }



        void Show()
        {
            Console.WriteLine($"Название авто: {_name}/n" +
                $"Цена: {_price}/n" +
                $"Год выпуска: {_year}/n" +
                $"Пробег: {_mileage}/n" +
                $"Комментарий собственника: {_comment}");
        }
    }
    
}
