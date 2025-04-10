using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que figura quiere operar");
            Console.WriteLine("1- Triangulo");
            Console.WriteLine("2- Rectangulo");
            Console.WriteLine("3- Circulo");

            int select = int.Parse(Console.ReadLine());


            switch (select)
            {
                case (1):
                    Console.WriteLine("Que ancho le quiere dar");
                    int b = int.Parse(Console.ReadLine());

                    Console.WriteLine("Que alto le quiere dar");
                    int h = int.Parse(Console.ReadLine());

                    triangulo r = new triangulo(b, h);

                    Console.WriteLine(r.Area());

                    break; 
                case (2):
                    Console.WriteLine("Que ancho le quiere dar");
                    int l1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Que alto le quiere dar");
                    int l2 = int.Parse(Console.ReadLine());

                    Cuadrado res = new Cuadrado(l1, l2);

                    Console.WriteLine(res.Area());

                    break;
                case (3):
                    break;
                default:
                    break;
            }






            /*
                  bool repeat = true;

              *while (repeat)
              {
                  Console.Clear();

                      Console.WriteLine("ingresa un numero");
                      int n1 = int.Parse(Console.ReadLine());

                      Console.WriteLine("ingresa una operacion (+ , * , / , -)");
                      string p = Console.ReadLine();

                      Console.WriteLine("ingresa un numero");
                      int n2 = int.Parse(Console.ReadLine());


                      if ( p == "+" )
                          Console.WriteLine(n1 + n2);
                      else if (p == "-")
                          Console.WriteLine(n1 - n2);
                      else if (p == "*")
                          Console.WriteLine(n1 * n2);
                      else if (p == "/")
                          Console.WriteLine(n1 / n2);
                      else
                          Console.WriteLine("error de operacion");

                  Console.WriteLine("otra operacion?");

                  if (Console.ReadLine() == "no") repeat = false;
              }
              */



        }
    }
}
