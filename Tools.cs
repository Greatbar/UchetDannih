using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UchetDannih
{
    class Tools
    {
        public void CountAveragePower()
        {

            double avr1 = 0;
            double i = 0;
            foreach (Car item in Car.Objects)
            {
                avr1 += item.power;
                i++;
            }
            Console.WriteLine("Средняя мощность двигателя по всем автомобилям: ");
            Console.WriteLine("{0:0.##}",avr1 / i);
        }
        public Staff[] AutoFillStaff(string[] Names, int[] ID, int[] Salary, int countstaff)
        {
            Random rand = new Random();
            string[] NamesFill = Names.OrderBy(x =>rand.Next()).ToArray();
            int[] IDFill = ID.OrderBy(x => rand.Next()).ToArray(); ;
            int[] SalaryFill = Salary.OrderBy(x => rand.Next()).ToArray();

            Staff[] team = new Staff[countstaff];

            for (int i = 0; i < countstaff; i++)
            {
                team[i] = new Staff(NamesFill[i], IDFill[i], SalaryFill[i]);
             
            }
            for (int i = 0; i < countstaff; i++)
            {
                int j = i + 1;
                Console.WriteLine("Сотрудник № {0}", j);
                Console.WriteLine($"Имя Сотрудника: {team[i].firstname}  Номер сотрудника: {team[i].id} Зарплата: {team[i].salary}");
            }
            return team;
            
        }
        public void CountAverageSalary(Staff[] salary, int countstaff)
        {
            double avr2 = 0;
            int j = 0;
            for (int i = 0; i < countstaff; i++)
            {
                avr2 += salary[i].salary;
                j++;
            }
            Console.WriteLine("Средняя зарплата по всем сотрудникам: ");
            Console.WriteLine(avr2 / j);
        }
    }
}
