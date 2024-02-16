using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypeAnonymousTypeDemo
{
    internal class DelegatesMulticastDelegates
    {
        public int Add(int a, int b)
        {
            Console.WriteLine("Executing Add Method");
            return a + b;
        }

        public int Subtract(int a, int b) {  return a - b; }
    }
}
