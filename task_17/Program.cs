using System;

namespace task_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Bill<string> bill1 = new Bill<string>("0", 0, "0"); //с номером счета string
            Console.WriteLine("Введите номер счета string");
            bill1.BillNumber = Console.ReadLine();  //считываем номер счета string
            Console.WriteLine("Введите баланс");
            try
            {
                bill1.Balance = Convert.ToInt32(Console.ReadLine());    //считываем баланс
            }
            catch
            {
                Console.WriteLine("Ошибка ввода");
            }
            Console.WriteLine("Введите ФИО");
            bill1.Name = Console.ReadLine();    //считываем ФИО
            Console.WriteLine();
            Bill<int> bill2 = new Bill<int>(0, 0, "0"); //с номером счета int
            Console.WriteLine("Введите номер счета int");
            try
            {
                bill2.BillNumber = Convert.ToInt32(Console.ReadLine()); //считываем номер счета int
            }
            catch
            {
                Console.WriteLine("Ошибка ввода");
            }
            Console.WriteLine("Введите баланс");
            try
            {
                bill2.Balance = Convert.ToInt32(Console.ReadLine());    //считываем баланс
            }
            catch
            {
                Console.WriteLine("Ошибка ввода");
            }
            Console.WriteLine("Введите ФИО");
            bill2.Name = Console.ReadLine();    //считываем ФИО
            Console.ReadKey();
        }
    }
    class Bill<T>
    {
        public T BillNumber { get; set; }
        public double Balance { get; set; }
        public string Name { get; set; }
        public Bill(T bn, double bal, string n)
        {
            BillNumber = bn;    //номер счета
            Balance = bal;  //баланс
            Name = n;   //ФИО
        }
    }
}
