using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypeAnonymousTypeDemo
{
    internal class Program
    {
        delegate int Calculate(int first, int second);

        
        static void Main(string[] args)
        {
            //value type can be assigned as null 
            //reference type can not be null

            int? i = null;
            bool? flag = null;

            if (flag.HasValue)
            {
                bool test = flag.Value;
            }
        

            //Anonymous Types

            var anonymousTypeVariable = new{ CompanyName = "ABC Corp", Year = 1998 };
            
            Console.WriteLine(i);
            Console.WriteLine(anonymousTypeVariable.CompanyName);
            Console.WriteLine(anonymousTypeVariable.Year);

            var iSample = 10;
            var strSample = "John";

            



            //  DelegatesMulticastDelegates
            DelegatesMulticastDelegates delegatesMulticastDelegates = new DelegatesMulticastDelegates();
            int i1 = 20, i2 = 30;
            Calculate calculate = new Calculate(delegatesMulticastDelegates.Add);
            // above or this are same Calculate calculate = Add;

            Calculate calculateSub = new Calculate(delegatesMulticastDelegates.Subtract);
            // above or this are same Calculate calculateSub = Subtract;

            int result = calculate(i1, i2);
            // int result = calculate.invoke(i1, i2);

            Console.WriteLine(result);





            

        }
    }
}
