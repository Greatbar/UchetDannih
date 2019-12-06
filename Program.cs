using System;

namespace UchetDannih
{
    
        class Program
        {
        static void Main(string[] args)
            {   
            Car Audi = new Car("Audi", 220, 320);
            Car BMW = new Car("BMW", 230, 380);
            Car Ferrari = new Car("Ferrari", 280, 465);

            Audi.GetInfo();
            BMW.GetInfo();
            Ferrari.GetInfo();
            Console.WriteLine('\n');

            Carshowroom Rolf = new Carshowroom("Rolf", "15.06.2011", 15321000);
            Carshowroom Orlan = new Carshowroom("Orlan", "12.02.2014", 10923156);
            Carshowroom TeslaClub = new Carshowroom("Teslaclub", "22.05.2016", 18953156);

            Rolf.GetInfo();
            Orlan.GetInfo();
            TeslaClub.GetInfo();
            Console.WriteLine('\n');

            string[] Names = new string[] { "Иван", "Андрей", "Никита", "Владимир", "Дмитрий", "Всеволод" };
            int[] ID = new int[] { 1528, 1242, 5124, 6412, 6537, 1523 };
            int[] Salary = new int[] { 15000, 25000, 150000, 50000, 80000, 100000 };

            Staff[] team;
            Tools tools = new Tools();
            tools.CountAveragePower();

            int countstaff;
            Console.WriteLine("Выведите количество персонала");
            countstaff = int.Parse(Console.ReadLine());

            team = tools.AutoFillStaff(Names, ID, Salary, countstaff);
            
            Console.WriteLine('\n');
            tools.CountAverageSalary(team, countstaff);
            Console.ReadKey();
            }
        }
}
