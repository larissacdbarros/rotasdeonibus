using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayRoutes3

{
    public class BusRoute
    {

        public int Number { get; }
        public string Origin { get; }

        public string Destination { get; }

        public BusRoute(int number, string origin, string detination)
        {
            //pseudo-variavel (this.xxx): permite manipular os dados recebidos 
            //manipula o que estamos recebendo de maneira segura
            this.Number = number;
            this.Origin = origin;   
            this.Destination = detination;  
        }

        //=> expressao lambda
        public override string ToString() => $"{Number}: {Origin} -> {Destination}";


    }
}
