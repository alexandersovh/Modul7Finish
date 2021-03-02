using System;
using System.Collections.Generic;
using System.Text;

namespace Modul7Finish
{
    abstract class Delivery
    {
        public string address = "улица Пушкинаб, дом Калатушкина";
        public abstract void Deliverytoo();
        public virtual void InQueriAddress()
        {
            string address = Console.ReadLine();
            this.address = address;
        }

    }
    class HomeDelivery : Delivery
    {
        /// <summary>
        /// конструкторы
        /// </summary>
        public HomeDelivery()
        {
            InQueriAddress();
            Deliverytoo();
        }
        /// <summary>
        /// методы
        /// </summary>
        public override void InQueriAddress()
        {
            Console.WriteLine("укажите свой домашний адркс");
            //User.Adress();
            //string address = Console.ReadLine();
            //this.address = address;
        }

        public override void Deliverytoo()
        {
            Console.WriteLine("доствавка домой на адрес {0}", address);
        }
    }
    class PickpointDelivery : Delivery
    {
        public override void Deliverytoo()
        {
            Console.WriteLine("доствавка в пункт выдочи на адрес{0}");
        }
    }
    class ShopDelivery : Delivery
    {
        public override void Deliverytoo()
        {
            Console.WriteLine("доствавка в магазин на адрес{0}", address);
        }
    }

}
