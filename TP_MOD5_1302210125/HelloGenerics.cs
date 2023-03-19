using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MOD5_130221205
{
    internal class HelloGenerics
    {
        public void SapaUSer <T> (T nama)
        {
            Console.WriteLine("Hallo User, " + nama);
        }
    }
}
