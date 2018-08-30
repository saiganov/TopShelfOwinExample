using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace TopshelfOwin
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebApp.Start<Startup>("http://localhost:8085"))
            {
                Console.WriteLine("The application is started.");
                Console.WriteLine("Press 'enter' to quit.");
                Console.ReadLine();
            }
        }
    }
}
