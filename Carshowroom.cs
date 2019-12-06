using System;
using System.Collections.Generic;
using System.Text;

namespace UchetDannih
{
    class Carshowroom
    {
        public double profit;
        public string open;
        public string name_showroom;
        public Carshowroom(string name_showroom, string open, double profit)
        { 
            this.name_showroom = name_showroom;
            this.open = open;
            this.profit = profit; 
        }
        public void GetInfo()
        {
            Console.WriteLine($"Название: {name_showroom}  Дата открытия: {open} Прибыль: {profit}");
        }
    }
}
