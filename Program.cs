using System;

namespace DisplayRoutes3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BusRoute[] allroutes = BusRouteRepository.InitializeRoutes(); //"inicializa o bd"

            Console.Write("Para onde deseja ir?");
            string location = Console.ReadLine().ToUpper().TrimStart();
            Console.WriteLine("Destino selecionado:" + location);

            Console.WriteLine("------------------------");

            //LAMBDA
            //Func<int, int> quadrado = x => x * x;
            //Console.WriteLine(quadrado(3));
                      

            Console.WriteLine("-------------------------");
            BusRoute route = FindBusTo(allroutes, location);    

            if(route != null)
            {
                Console.WriteLine($"Pega o numero: {route}");
            } else
            {
                Console.WriteLine($"Não tem onibus para: {location}");
            }

            //UTILIZANDO LAMBDA (usado para criar uma função anonima)/ mini método embutido dentro de um 
            //método para executar uma ação simples
            //route => route.Origin
        }

        public static BusRoute FindBusTo(BusRoute[] routes, string location)
        {
            //LAMBDA
            return Array.Find(routes, 
                route => route.Origin == location || route.Destination == location);
            //foreach (BusRoute route in routes)
            //{
            //    if(route.Origin == location || route.Destination == location)
            //    {
            //        return route;
            //    }
            //}
            //return null;


        }
    }
}
