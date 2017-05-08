using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Service
{
    [ServiceContract]
    public interface IHelloWorld
    {
        string GetHelloWorld();
    }
    public interface IHelloWorldWritter
    {
        bool WriteLine(string msg);
    }
    public class HelloWorldService : IHelloWorld
    {
        private IHelloWorldWritter _writer = null;
        #region ctors

        public HelloWorldService(IHelloWorldWritter writer = null)
        {
            _writer = writer;
        }
        #endregion

        #region support future enhancements
        public bool Save()
        {
            if (_writer != null)
                return _writer.WriteLine(GetHelloWorld());
            return false;
        }

        #endregion


        #region IHelloWorld interface
        public string GetHelloWorld()
        {
            return "Hello World";
        }
        #endregion
    }

}
