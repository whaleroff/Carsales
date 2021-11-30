using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsales.Database
{
    class User
    {
        public Guid Id { get; set; }
        // добавить во все сущности гуиды что бы были идетификаторы+
        //заполнить тестовыми данными TestStore+
        //Сделать 5 интерфейсов Create Read Update Delete Get, в них впилить одноименные названия, у Get - GetAll и GetOne по гуиду
        //реализовать все интерфейсы во всех классах Database кроме TestStore 
        //Почитать про паттерн фабрика, абстрактная фабрика, фабричный метод
        //Прочитать про Generic
        //Сделать Generic статический метод в классе TestStore который будет возвращать коллекцию того типа который ты прокидваешь и реализовать 
        //методы из интерфейсов с помощью этих коллекци, т.е. мы запрашиваем статический метод у TestStore который возвраащет нам коллекцию того 
        //типа который мы запросили и дальше из это коллекции мы делаем Read, Create,Update etc в каждом классе сущности

    }
}
