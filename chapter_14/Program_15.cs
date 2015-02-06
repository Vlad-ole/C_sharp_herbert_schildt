using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace chapter_14
{

    /* Использовать классы BinaryReader и BinaryWriter для
реализации простой программы учета товарных запасов. */

    class Program_15
    {
        static void Main(string[] args)
        {
            BinaryWriter dataOut;
            BinaryReader dataIn;
            
            string item; // наименование предмета
            int onhand; // имеющееся в наличии количество
            double cost; // цена
            
            try
            {
                dataOut = new
                BinaryWriter(new FileStream("inventory.dat", FileMode.Create));
            }
            
            catch (IOException exc)
            {
                Console.WriteLine("He удается открыть файл " + "товарных запасов для вывода");
                Console.WriteLine("Причина: " + exc.Message);
                return;
            }
            
            // Записать данные о товарных запасах в файл.
            try
            {
                dataOut.Write("Молотки");
                dataOut.Write(10);
                dataOut.Write(3.95);

                dataOut.Write("Отвертки");
                dataOut.Write(18);
                dataOut.Write(1.50);

                dataOut.Write("Плоскогубцы");
                dataOut.Write(5);
                dataOut.Write(4.95);

                dataOut.Write("Пилы");
                dataOut.Write(8);
                dataOut.Write(8.95);
            }

            catch (IOException exc)
            {
                Console.WriteLine("Ошибка записи в файл товарных запасов");
                Console.WriteLine("Причина: " + exc.Message);
            }

            finally
            {
                dataOut.Close();
            }

            Console.WriteLine();

            // А теперь открыть файл товарных запасов для чтения.
            try
            {
                dataIn = new BinaryReader(new FileStream("inventory.dat", FileMode.Open));
            }

            catch (IOException exc)
            {
                Console.WriteLine("He удается открыть файл " + "товарных запасов для ввода");
                Console.WriteLine("Причина: " + exc.Message);
                return;
            }

            // Найти предмет, введенный пользователем.
            Console.Write("Введите наименование для поиска: ");
            string what = Console.ReadLine();
            Console.WriteLine();

            try
            {
                for (; ; )
                {
                    // Читать данные о предмете хранения.
                    item = dataIn.ReadString();
                    onhand = dataIn.ReadInt32();
                    cost = dataIn.ReadDouble();
                    
                    // Проверить, совпадает ли он с запрашиваемым предметом.
                    // Если совпадает, то отобразить сведения о нем.
                    if (item.Equals(what, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(item + ": " + onhand + " штук в наличии. " + "Цена: {0:С} за штуку", cost);
                        Console.WriteLine("Общая стоимость по наименованию <{0}>: {1:С}.", item, cost * onhand);
                        break;
                    }
                }
            }

            catch (EndOfStreamException)
            {
                Console.WriteLine("Предмет не найден.");
            }

            catch (IOException exc)
            {
                Console.WriteLine("Ошибка чтения из файла товарных запасов");
                Console.WriteLine("Причина: " + exc.Message);
            }

            finally
            {
                dataIn.Close();
            }


            Console.ReadKey();
        }
    }
}
