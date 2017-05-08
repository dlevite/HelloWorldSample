using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Service;
namespace HelloWorldConsole
{
    public class ConsoleWriter : IHelloWorldWritter
    {
        public bool WriteLine(string msg)
        {
            try
            {
                Console.WriteLine(msg);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
            return true;
        }
    }
}
