using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Service;

namespace HelloWorldConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //can use any Dependency Injection method to
            //instantiate a configured class like ConoleWriter
            //and insert into the constructor of the service
            IHelloWorld service = new HelloWorldService();
            Console.WriteLine(service.GetHelloWorld());

            //future enhancement supported by service object
            ConsoleWriter writer = new ConsoleWriter();
            var futureservice = new HelloWorldService(writer);
            Console.WriteLine("Saving:" + futureservice.Save());
            Console.ReadLine();
        }
    }
}
