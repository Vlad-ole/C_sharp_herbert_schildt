using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace chapter_6
{

    /*
    Добавить параметризированный метод, вычисляющий
    максимальное количество человек, которые могут
    занимать здание, исходя из заданной минимальной
    площади на одного человека.
    */


    class Building
    {
        public int Floors; // количество этажей
        public int Area; // общая площадь здания
        public int Occupants; // количество жильцов
        // Возвратить площадь на одного человека.
        public int AreaPerPerson()
        {
            return Area / Occupants;
        }
        // Возвратить максимальное количество человек, занимающих здание,
        // исходя из заданной минимальной площади на одного человека.
        public int MaxOccupant(int minArea)
        {
            return Area / minArea;
        }
    }

    // Использовать метод MaxOccupant().
    class Program_7
    {
        static void Main()
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
            Console.WriteLine("Максимальное количество человек в доме, \n" +
            "если на каждого должно приходиться " +
            300 + " кв. футов: " +
            house.MaxOccupant(300));

            Console.WriteLine("Максимальное количество человек " +

                            "в учреждении, \n" +
            "если на каждого должно приходиться " +
            300 + " кв. футов: " +
            office.MaxOccupant(300));


            Console.ReadKey();
        }
    }

}
