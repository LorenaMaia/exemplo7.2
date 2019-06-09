using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            String resposta;
   
       
            Console.WriteLine(" O céu é azul?");
            resposta = Console.ReadLine();

            while (resposta != "sim") {
                Console.WriteLine(" O céu é azul?");
                resposta = Console.ReadLine();
            }
            Console.WriteLine(" Você acertou! ");
            Environment.Exit(0);
            
            }
            


        }
    }

