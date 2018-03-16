using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Initiator _initiator = new Initiator();
            //string data = _initiator.FetchData();
            //Console.WriteLine(data);

            Bootstrapper.Init(); //this will create a new class of business which can be used in other part of the programms.
            Initiator _initiator = DependencyInjector.Retrieve<Initiator>();
            string data = _initiator.FetchData();
            Console.WriteLine(data);
            Console.ReadLine();
        }
    }
}
