using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiskefangst_MOCK;

namespace Console_Fisk_MOCK
{
    class Program
    {
        static void Main(string[] args)
        {
            var catching = new Fiskefangst_MOCK.FiskeService();

            //viser den statiske list i fiske service i Fiskefangst_MOCK
            Console.WriteLine($"catch er: " + catching.GetCatches());

            Console.ReadLine();
        }
    }
}
