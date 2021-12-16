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


        }
    }

    class Bill<T>
    {
        public T BillNumber { get; set; }
        public double Balance { get; set; }
        public string Name { get; set; }
    }
}
