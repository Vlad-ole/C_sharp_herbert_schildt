﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_12
{

    // Структуры удобны для группирования небольших объемов данных.

    // Определить структуру пакета.
    struct PacketHeader
    {
        public uint PackNum; // номер пакета
        public ushort PackLen; // длина пакета
    }

    // Использовать структуру PacketHeader для создания записи транзакции
    // в сфере электронной коммерции.

    class Transaction
    {
        static uint transacNum = 0;
        PacketHeader ph; // ввести структуру PacketHeader в класс Transaction
        string accountNum;
        double amount;
        public Transaction(string acc, double val)
        {
            // создать заголовок пакета
            ph.PackNum = transacNum++;
            ph.PackLen = 512; // произвольная длина
            accountNum = acc;
            amount = val;
        }

        // Сымитировать транзакцию.
        public void sendTransaction()
        {
            Console.WriteLine("Пакет #: " + ph.PackNum +
            ", Длина: " + ph.PackLen +
            ",\n Счет #: " + accountNum +
            ", Сумма: {0:C}\n", amount);
        }
    }

    // Продемонстрировать применение структуры в виде пакета транзакции.
    class Program_12
    {
        static void Main(string[] args)
        {
            Transaction t = new Transaction("31243", -100.12);
            Transaction t2 = new Transaction("AB4655", 345.25);
            Transaction t3 = new Transaction("8475-09", 9800.00);
            
            t.sendTransaction();
            t2.sendTransaction();
            t3.sendTransaction();

            Console.ReadKey();

        }
    }
}
