using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFutebol_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time1 = new Time("Palmeiras");
            Time time2 = new Time("Santos");

            Time time3 = new Time("Atletico");
            Time time4 = new Time("Cruzeiro");

            Partida p1 = new Partida(DateTime.Now, time1, time2);
            p1.jogar();
            Console.WriteLine(p1.getPalacar());

            Partida p2 = new Partida(DateTime.Now, time3, time4);
            p2.jogar();
            Console.WriteLine(p2.getPalacar());

            Partida p3 = new Partida(DateTime.Now, time1, time3);
            p3.jogar();
            Console.WriteLine(p3.getPalacar());

            Partida p4 = new Partida(DateTime.Now, time2, time4);
            p4.jogar();
            Console.WriteLine(p4.getPalacar());

       
            Console.WriteLine(time1.getStatus());
            Console.WriteLine(time2.getStatus());
            Console.WriteLine(time3.getStatus());
            Console.WriteLine(time4.getStatus());




            Console.ReadKey();
        }
    }
}
