using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayRoutes3
{
    public class BusRouteRepository
        //aqui a ideia é emular um banco de dados
    {

        public static BusRoute[] InitializeRoutes() //Initialize é o metodo que inicializa as rotas
        {
            return new BusRoute[]
            {
                new BusRoute(385, "ANCHIETA", "PRAÇA DAS BANDEIRAS"),
                new BusRoute(503, "NILOPOLIS", "CENTRAL"),
                new BusRoute(128, " CENTRAL", "COPACABANA"),
                new BusRoute(956, "CENTRAL", "IPANEMA")

            };
        }
    }
}
