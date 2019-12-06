using System;
using System.Collections.Generic;
using System.Text;

namespace UchetDannih
{
    partial class  Staff
    {
        public double salary;
        public string firstname;
        public int id;
        public static List<Staff> Objects = new List<Staff>();
        public Staff(string firstname, int id, double salary)
        { 
            this.firstname = firstname;
            this.id = id;
            this.salary = salary;
            Objects.Add(this);
        }
        public void GetInfo()
        {
            Console.WriteLine($"Имя Сотрудника: {firstname}  Номер сотрудника: {id} Зарплата: {salary}");
        }
        
    }
}
