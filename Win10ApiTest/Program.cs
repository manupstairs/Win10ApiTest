using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Metadata;

namespace Win10ApiTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TestWin10Api();
            Console.ReadLine();
        }

        private static void TestWin10Api()
        {
            if (ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 8))
            {
                Console.WriteLine("Windows.Foundation.UniversalApiContract 8.0 exists.");
            }
            else
            {
                Console.WriteLine("Windows.Foundation.UniversalApiContract doen't exist.");
            }
        }
    }
}
