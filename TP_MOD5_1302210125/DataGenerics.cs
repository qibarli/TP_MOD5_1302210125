using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MOD5_1302210125
{
    internal class DataGenerics<T>
    {
        private T data;

        public DataGenerics(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine("Data Yang Tersimpan: " + this.data);
        }
    }
}
