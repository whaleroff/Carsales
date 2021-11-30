using Carsales.Inter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsales.Database
{
    class TestStore : IGet
    {

        List<Car> cars = new List<Car>
        {
            new Car
            {
                _name = "Ваз 2109",
                _price = 50000.0,
                _mileage = 967854.0,
                _year = 2001,
                _comment = "дно переварено",
            },
            new Car
            {
                _name = "Toyota Camry",
                _price = 760000.0,
                _mileage = 200000.0,
                _year = 2012,
                _comment = "в хорошем состоянии",
            },
            new Car
            {
                _name = "ГАЗ 69",
                _price = 69000.0,
                _mileage = 453000.0,
                _year = 1987,
                _comment = "ездил дедушка, хранил в гараже",
            },
            new Car
            {
                _name = "Nissan Skyline",
                _price = 420000.0,
                _mileage = 360500.0,
                _year = 1998,
                _comment = "не распил",
            },
            new Car
            {
                _name = "Mitsubishi Lancer",
                _price = 93000.0,
                _mileage = 1083.7,
                _year = 1995,
                _comment = "редкий экземпляр",
            },
            new Car
            {
                _name = "ВАЗ 2114",
                _price = 140000.0,
                _mileage = 90000.0,
                _year = 2007,
                _comment = "чисто пацанская тачка",
            },
        };    
        
        List<Police> police = new List<Police>
        {
            new Police
            {
                _name = "Управление Министерства внутренних дел России по Калужской области",
                _address = "ул. Суворова д.139",
                _city = "Калуга",
                _obl = "Калужская",
                _phone = "8 (4842) 56-20-11",
                _times = new(9, 00, 00),
                _timeo = new(18, 15, 00),
                _reg = 40,
                _otdel = 0,
            },
            new Police
            {
                _name = "ОМВД России по г.Обнинску",
                _address = "ул. Ленина, 89",
                _city = "Обнинск",
                _obl = "Калужская",
                _phone = "8(48439) 4-98-02",
                _times = new(00, 00, 00),
                _timeo = new(24, 00, 00),
                _reg = 40,
                _otdel = 249020,
            },
            new Police
            {
                _name = "МОМВД России \"Юхновский\"",
                _address = "ул. Десантная, 4",
                _city = "Юхнов",
                _obl = "Калужская",
                _phone = "8(48436) 2-57-02",
                _times = new(00, 00, 00),
                _timeo = new(24, 00, 00),
                _reg = 40,
                _otdel = 249910,
            },
            new Police
            {
                _name = "МРЭО ГИБДД УМВД России по Калужской области",
                _address = "Грабцевское ш., 112А",
                _city = "Калуга",
                _obl = "Калужская",
                _phone = "+7 (4842) 50-14-09",
                _times = new(8, 30, 00),
                _timeo = new(18, 00, 00),
                _reg = 40,
                _otdel = 248009,
            },
            new Police
            {
                _name = "ОеМВД России по Тарусскому району",
                _address = "ул. Октябрьская, 8",
                _city = "Таруса",
                _obl = "Калужская",
                _phone = "8(48435) 2-50-53",
                _times = new(00, 00, 00),
                _timeo = new(24, 00, 00),
                _reg = 40,
                _otdel = 249100,
            },
        };
        List<Cservice> cservices = new List<Cservice>()
        {
            new Cservice
            {
                _name = "Мост",
                _address = "ул. Параллельная, 14",
                _city = "Калуга",
                _obl = "Калужская",
                _phone = "+7 (906) 641-00-05",
                _times = new(9, 00, 00),
                _timeo = new(18, 00, 00),
                _reg = 40,
                _mail = "-",
            },
            new Cservice
            {
                _name = "FIT SERVICE",
                _address = "ул. Болотникова, 23А",
                _city = "Калуга",
                _obl = "Калужская",
                _phone = "+7 (4842) 59-61-53",
                _times = new(9, 00, 00),
                _timeo = new(21, 00, 00),
                _reg = 40,
                _mail = "kaluga.fitauto.ru",
            },
            new Cservice
            {
                _name = "Колесо TyrePlus",
                _address = "ул. Труда, 29",
                _city = "Калуга",
                _obl = "Калужская",
                _phone = "(999) - 000 - 00 - 00",
                _times = new(9, 00, 00),
                _timeo = new(21, 00, 00),
                _reg = 40,
                _mail = "kolesokaluga.ru",
            },
            new Cservice
            {
                _name = "Олимп",
                _address = "ул. Железняки, 37",
                _city = "Калуга",
                _obl = "Калужская",
                _phone = "+7 (958) 625-66-66",
                _times = new(00, 00, 00),
                _timeo = new(24, 00, 00),
                _reg = 40,
                _mail = "-",
            },
            new Cservice
            {
                _name = "Автолюкс",
                _address = "Газовая ул., 8, деревня Железняки",
                _city = "Калуга",
                _obl = "Калужская",
                _phone = "+7 (4842) 20-72-70",
                _times = new(9, 00, 00),
                _timeo = new(21, 00, 00),
                _reg = 40,
                _mail = "www.avtolux-kaluga.ru",
            },
        };
        List<Cparts> cparts = new List<Cparts>()
        {
            new Cparts
            {
                _name = "Exist",
                _address = "ул. Генерала Попова, 2",
                _city = "Калуга",
                _obl = "Калужская",
                _phone = "+7 (953) 335-41-19",
                _times = new(9, 00, 00),
                _timeo = new(20, 00, 00),
                _reg = 40,
                _rate = 4.2,
            },
            new Cparts
            {
                _name = "Автосказка",
                _address = "ул. Максима Горького, 5",
                _city = "Калуга",
                _obl = "Калужская",
                _phone = "+7 (4842) 54-67-54",
                _times = new(9, 00, 00),
                _timeo = new(19, 00, 00),
                _reg = 40,
                _rate = 4.3,
            },
            new Cparts
            {
                _name = "Авт03",
                _address = "ул. Максима Горького, 1А",
                _city = "Калуга",
                _obl = "Калужская",
                _phone = "+7 (4842) 73-78-94",
                _times = new(00, 00, 00),
                _timeo = new(24, 00, 00),
                _reg = 40,
                _rate = 4.2,
            },
            new Cparts
            {
                _name = "АвтоЛидер40",
                _address = "ул. Рылеева, 58/14",
                _city = "Калуга",
                _obl = "Калужская",
                _phone = "+7 (962) 193-35-09",
                _times = new(10, 00, 00),
                _timeo = new(19, 00, 00),
                _reg = 40,
                _rate = 4.4,
            },
            new Cparts
            {
                _name = "40Авто",
                _address = "Московская ул., 191",
                _city = "Калуга",
                _obl = "Калужская",
                _phone = "+7 (4842) 58-97-65",
                _times = new(9, 00, 00),
                _timeo = new(19, 00, 00),
                _reg = 40,
                _rate = 4.7,
            },
        };
        List<Cinsurance> cinsurances = new List<Cinsurance>()
        {
            new Cinsurance
            {
                _name = "ОСАГО без очереди",
                _address = "ул. Дарвина, 7",
                _city = "Калуга",
                _obl = "Калужская",
                _phone = "+7 (920) 871-71-71",
                _times = new(00, 00, 00),
                _timeo = new(24, 00, 00),
                _reg = 40,
                _open = true,
            },
            new Cinsurance
            {
                _name = "Страхование от А ДО Я",
                _address = "ул. Баумана, 3",
                _city = "Калуга",
                _obl = "Калужская",
                _phone = "+7 (910) 519-03-64",
                _times = new(00, 00, 00),
                _timeo = new(24, 00, 00),
                _reg = 40,
                _open = true,
            },
            new Cinsurance
            {
                _name = "АльфаСтрахование",
                _address = "ул. Циолковского, 34",
                _city = "Калуга",
                _obl = "Калужская",
                _phone = "+7 (4842) 21-02-07",
                _times = new(9, 00, 00),
                _timeo = new(18, 00, 00),
                _reg = 40,
                _open = true,
            },
            new Cinsurance
            {
                _name = "Страховой Дом ВСК",
                _address = "ул. Максима Горького, 88",
                _city = "Калуга",
                _obl = "Калужская",
                _phone = "8 (800) 775-15-75",
                _times = new(9, 00, 00),
                _timeo = new(18, 00, 00),
                _reg = 40,
                _open = true,
            },
            new Cinsurance
            {
                _name = "Росгосстрах",
                _address = "ул. Воронина, 28",
                _city = "Калуга",
                _obl = "Калужская",
                _phone = "8 (800) 200-09-00",
                _times = new(9, 00, 00),
                _timeo = new(18, 00, 00),
                _reg = 40,
                _open = true,
            },
        };

        private IGet _getImplementation;

        // public T Get<T>(Guid id) where T: class
        // {
        //     switch(typeof(T))
        //     {
        //         case (typeof(Сar)):
        //             {
        //                 foreach (Car car in cars)
        //                 {
        //                     if (id == car.Id)
        //                     {
        //                         Console.WriteLine($"{car._name}\n Цена: {car._price}\n Год выпуска: {car._year}\n Пробег: {car._mileage}\n Комментарий: {car._comment}\n");
        //                         return car as T;
        //                     };
        //                 };
        //             };
        //
        //         default:
        //                 return default(T);


        public T Get<T>(Guid id) where T : class
        {
            return _getImplementation.Get<T>(id);
        }

        public List<T> Get<T>(Func<bool> filter)
        {
            return _getImplementation.Get<T>(filter);
        }
    }
            //if (typeof(T) == typeof(Car))
            //{
            //    foreach (Car car in cars)
            //    {
            //        if (id == car.Id)
            //        {
            //            Console.WriteLine($"{car._name}\n Цена: {car._price}\n Год выпуска: {car._year}\n Пробег: {car._mileage}\n Комментарий: {car._comment}\n");
            //            return car as T;
            //        }
            //    }
            //};
            //if (typeof(T) == typeof(Cinsurance))
            //{
            //    foreach (Cinsurance cinsurance in cinsurances)
            //    {
            //        if (id == cinsurance.Id)
            //        {
            //            Console.WriteLine("не забудь написать");
            //            return cinsurance as T;
            //        }
            //    }
            //};

            //return default (T);
        }

        // public List<T> Get<T>(Func<bool> filter)
        // {
        //     throw new NotImplementedException();
        // }
    

