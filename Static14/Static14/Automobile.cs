using System;
using System.Collections.Generic;
using System.Text;
/*
7.  Напишите небольшую программу с объявлением класса, имеющего одну переменную-член  и одну статическую переменную-член. Пусть конструктор инициализирует переменную-член и инкрементирует статическую переменную член, а деструктор – декрементирует ее.
8.	Напишите драйвер к п.7, в котором создается три объекта и на экран выводятся значения обычной и статической переменных членов класса. Уничтожьте эти объекты и проследите как будет меняться значение статической переменной члена.
9.	Сделайте статическую переменную п.7-8 приватной. Напишите и используйте статическую функцию-член для доступа к приватной статической переменной члену?
10.	Напишите указатель на функцию-член для доступа к приватной статической переменной п.9 и используйте его для вывода значения на экран.
11.	Добавьте еще две переменные- члена в класс. Включите функции доступа, принимающие значения этих переменных, обеспечив при этом всем функциям- членам одинаковый тип возврата и сигнатуры. Используйте указатель на функцию-член для доступа к этим функциям.
*/
namespace Static14
{
    class Automobile
    {
        private static int NumberOfWheels = 4;
        public string model { get { return model; } set { model = value; } }
        public int number { get { return number; } set { number = value; } }
        public Automobile(string model,int number)
        {
            this.model = model;
            this.number = number;
            NumberOfWheels++;
        }
        public static int NumberOFWheels
        {
            get { return NumberOfWheels; }
            set { NumberOfWheels = value; }
        }

        
        public static int SizeOfGasTank
        {
            get
            {
                return 15;
            }
        }
        
        public static void Drive() { }
        ~Automobile()
        {
            NumberOfWheels--;
        }
    }
}
