using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер счета");

        }
    }

    class Bill<T>
    {
        public T BillNumber { get; set; }
        public double Balance { get; set; }
        public string Name { get; set; }
        Bill(T bn, double bal, string n)
        {
            BillNumber = bn;
            Balance = bal;
            Name = n;
        }
    }
}
