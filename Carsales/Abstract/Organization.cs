using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsales.Abstract
{
    abstract class Organization : IFavorite
    {
        // ЭТО ПОЛЯ
        public string _name { get; set; }     //название
        public string _address;    //адрес
        public TimeSpan _times;        public TimeSpan _timeo; //время работы
        public Point _point;       //координаты
        public string _phone;      //контактный телефон
        public string _city;       //Город (с номером региона)
        public int _reg;
        public string _obl;        //область
        //ЭТО МЕТОДЫ
        public virtual void Show()
        {
            Console.WriteLine($"{_name}/n" +
                $"По адресу: {_address}/n" +
                $"На карте: {_point}/n" +
                $"Время работы: {_times} - {_timeo}/n" +
                $"Контактный номер телефона: {_phone}/n" +
                $"В городе: {_city}({_reg})/n" +
                $"Область: {_obl}/n");
        }//show виртуальный (для гаи свой вывод инфы будет, для автосервиса свой т.к. там разный набор инфы, по дефолту просто в консоль поля организаии

        public abstract void Form();//оставить заявку абстрактный

        public abstract void addToFavorite(string user);


        //добавить в избранное


        //Как доделаешь этот класс унаследовать от организации гам и автосервисы


    }
    interface IFavorite
    {
        void addToFavorite(String user);
    }
}
