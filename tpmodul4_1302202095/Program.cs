using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod4_1302202095
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataGeneric<String> data = new DataGeneric<string>("1302202095");
            data.PrintData();
        }
    }

    public class DataGeneric<T>
    {
        private T data;
        public DataGeneric(T data)
        {
            this.data = data;
        }
        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + this.data);
        }
    }
}