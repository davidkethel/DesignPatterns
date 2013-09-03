using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    static class AdapterExample
    {

        public static void Run()
        {
            var target = new Adapter();
            var client = new Client(target);
            client.MakeRequest();
        }

    }
}
