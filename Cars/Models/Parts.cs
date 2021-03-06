using System;
using System.Drawing;

namespace Cars.Models
{
    public class Parts
    {
        public string _name { get; set; }     //название
        public string _address;    //адрес
        public TimeSpan _times;        public TimeSpan _timeo; //время работы
        public Point _point;       //координаты
        public string _phone;      //контактный телефон
        public string _city;       //Город (с номером региона)
        public int _reg;
        public string _obl;        //область
        public Guid Id { get; set; }
        public double _rate { get; set; }
    }
}