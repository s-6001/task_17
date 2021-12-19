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
            Bill<int> bill1 = new Bill<int>(1,1,"1");
            Console.WriteLine("Введите номер счета");
            
        }
    }

    class Bill<T>
    {
        public T BillNumber { get; set; }
        public double Balance { get; set; }
        public string Name { get; set; }
        public Bill(T bn, double bal, string n)
        {
            BillNumber = bn;
            Balance = bal;
            Name = n;
        }
    }
}
