using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Locadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantPassag;
            DateTime datainicio;
            DateTime datafim;

            Console.WriteLine("Qual tipo de carro?");
            Console.WriteLine(" ");
            Console.WriteLine("Compacto");
            Console.WriteLine("Esportivo");
            Console.WriteLine("SUV");
            Console.WriteLine(" ");

            string tipoCarro = Console.ReadLine();

            Console.WriteLine(" ");
            Console.WriteLine("Quantos passageiros?");
            Console.WriteLine(" ");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");
            Console.WriteLine("7");
            Console.WriteLine(" ");

            quantPassag = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Qual data (dd/mm/aaaa) de início da locação do carro?");
            Console.WriteLine(" ");
            datainicio = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Qual data (dd/mm/aaaa) de entrega do carro?");
            Console.WriteLine(" ");
            datafim = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(" ");
            
            int start = datainicio.Year * 10000 + datainicio.Month * 100
               + datainicio.Day + datainicio.Hour + datainicio.Minute + datainicio.Second;

            int end = datafim.Year * 10000 + datafim.Month * 100
               + datafim.Day + datafim.Hour + datafim.Minute + datafim.Second;

            int QuantDias = end - start;
            
            if (tipoCarro.ToLower() == "compacto" && quantPassag >= 1 && quantPassag <= 4)
            {
                double valor = QuantDias * 200;
                Console.WriteLine(" ");
                Console.WriteLine("Compacto : Loja SouthCar" + " Valor : " + valor + " reais ");
                Console.ReadLine();
            }
                
            else if (tipoCarro.ToLower() == "esportivo" && quantPassag >= 1 && quantPassag <= 2)
            {
                double valor = QuantDias * 530;
                Console.WriteLine(" ");
                Console.WriteLine("Esportivo : Loja WestCar" + " Valor : " + valor + " reais ");
                Console.ReadLine();
            }
            
            else if (tipoCarro.ToLower() == "suv" && quantPassag >= 1 && quantPassag <= 7)
            {
                double valor = QuantDias * 630;
                Console.WriteLine(" ");
                Console.WriteLine("SUV : Loja NorthCar" + " Valor : " + valor + " reais ");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Não foram encontrados carros disponíveis nas condições informadas.");
            }
        }
    }
}

