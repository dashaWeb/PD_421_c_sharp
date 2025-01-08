using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Interface
{
    class StreamerDuck:Duck, IFly
    {
        /*new public void Fly ()
        {
            Console.WriteLine("Streamer duck can not fly");
        }*/
        public override void Fly()
        {
            Console.WriteLine("Streamer duck can not fly");
        }
    }
}
