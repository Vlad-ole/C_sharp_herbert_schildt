using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_6
{

    // Добавить метод в класс Building.

    class Building
    {
        public int Floors; // количество этажей
        public int Area; // общая площадь здания
        public int Occupants; // количество жильцов
        // Вывести площадь на одного человека,
        public void AreaPerPerson()
        {
            Console.WriteLine(" " + Area / Occupants +
            " приходится на одного человека");
        }
    }

    class Program_3
    {
        static void Main(string[] args)
        {

            Building house = new Building();
            Building office = new Building();
            // Присвоить значения полям в объекте house.
            house.Occupants = 4;
            house.Area = 2500;
            house.Floors = 2;
            // Присвоить значения полям в объекте office.
            office.Occupants = 25;

            office.Area = 4200;
            office.Floors = 3;
            Console.WriteLine("Дом имеет:\n " +
            house.Floors + " этажа\n " +
            house.Occupants + " жильца\n " +
            house.Area +
            "кв. футов общей площади, из них");
            house.AreaPerPerson();
            Console.WriteLine();
            Console.WriteLine("Учреждение имеет:\n " +
            office.Floors + " этажа\n " +
            office.Occupants + " работников\n " +
            office.Area +
            " кв. футов общей площади, из них");
            office.AreaPerPerson();

            Console.ReadKey();
        }
    }
}
