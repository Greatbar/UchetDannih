using System;
using System.Collections.Generic;
using System.Text;

namespace UchetDannih
{
    class Car
    {
        public int power;
        public int speed;
        public string name_car;
        public static List<Car> Objects = new List<Car>();
        public Car (string name_car, int speed, int power)
        { 
            this.name_car = name_car;
            this.speed = speed;
            this.power = power;
            Objects.Add(this);
        }
        public void GetInfo()
        {
            Console.WriteLine($"Модель: {name_car}  Скорость: {speed} Мощность: {power}");
        }
    }
}
