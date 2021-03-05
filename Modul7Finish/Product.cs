using System;
using System.Collections.Generic;
using System.Text;

namespace Modul7Finish
{
    abstract class Product
    {
        protected int Id { get; set; }
        protected string Name { get; set; }
        protected double Prise { get; set; }
        protected string Monufacturer { get; set; }
        public virtual double Discount()
        {
            return Prise;
        }
    }
    static class DataProduct
    {

    }
    static class DataProductSet
    {
        //public 
    }
    class Game : Product
    {
        public int AgeRating { get; set; }
        public override double Discount()
        {
            return Prise * 0.2;
        }
    }
    class Hardware : Product
    {
        public override double Discount()
        {
            return Prise * 0.5;
        }
    }
    class Matherbord : Hardware { }
    class Procesor : Hardware { }
    class GraphicsСard : Hardware
    {
        public override double Discount()
        {
            return Prise * 1000;
        }
    }

    class PowerSupply : Hardware
    {

    }
    class Laptops : Product
    {
        public int Weight { get; set; }
        public int VolumeBattery { get; set; }
    }
}
