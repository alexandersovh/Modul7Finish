using System;
using System.Collections.Generic;
using System.Text;

namespace Modul7Finish
{
    class Order<Tdelivery, Tstruct> where Tdelivery : Delivery
    {
        public Tdelivery delivery;
        public int number;
        public string description;

        public void displayaddress()
        {

        }
        public void Del(string a)
        {
            if (a == "home")
            {
                Informer.FimalReport();

            }
            else if (a == "poin")
            {
                Informer.FimalReport();
            }
            else if (a == "shop")
            {
                Informer.FimalReport();
            }
        }
    }

}
