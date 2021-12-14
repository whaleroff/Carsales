using System;

namespace Cars.Models
{
    public class Car
    {
        public Guid Id { get; set; }
        public string _name { get; set; }       //название машины
        public double _price { get; set; }     //ценник
        public int _year { get; set; }          //год выпуска
        public double _mileage { get; set; }    //пробег
        public string _comment { get; set; }    //комментарий владельца/завода 
    }
}