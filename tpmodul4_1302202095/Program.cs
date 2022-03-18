using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302202095
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric<string> haloo = new HaloGeneric<string>();
            String x = "Angel";
            haloo.SapaUser(x);

        }
    }
    public class HaloGeneric<T>
    {
        public void SapaUser(T x)
        {
            Console.WriteLine("Halo " + x);
        }
    }
}