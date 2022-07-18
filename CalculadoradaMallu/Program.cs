using System;

namespace CalculadoradaMallu
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int numero1, numero2, resultado;
            string operacao;
           

            Console.WriteLine("Ola Mallu vamos calcular algo???");
            Console.WriteLine("S para continuar ou N para parar");
            string escolher =Console.ReadLine();



           while (escolher == "S")
            {



                Console.WriteLine("Quaaaallll primeiro valor??");
                numero1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual seria o segundo valor???");
                numero2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual operação??");
                operacao = Console.ReadLine();

                switch (operacao)
                {


                    case "+":
                        resultado = numero1 + numero2;
                        Console.WriteLine("Essa foi a operação: " + numero1 + " " + operacao + " " + numero2 + "= " + resultado);
                        Console.WriteLine("S para continuar ou N para parar");
                        escolher = Console.ReadLine();
                        break;


                    case "-":
                        resultado = numero1 - numero2;
                        Console.WriteLine("Essa foi a operação: " + numero1 + " " + operacao + " " + numero2 + "= " + resultado);
                        Console.WriteLine("S para continuar ou N para parar");
                        escolher = Console.ReadLine();
                        break;

                    case "*":
                        resultado = numero1 * numero2;
                        Console.WriteLine("Essa foi a operação: " + numero1 + " " + operacao + " " + numero2 + "= " + resultado);
                        Console.WriteLine("S para continuar ou N para parar");
                        escolher = Console.ReadLine();
                        break;

                    case "/":
                        resultado = numero1 / numero2;
                        Console.WriteLine("Essa foi a operação: " + numero1 + " " + operacao + " " + numero2 + "= " + resultado);
                        Console.WriteLine("S para continuar ou N para parar");
                        escolher = Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Errrrroooouuuuuuu, tenta fazer novamente Mallu");
                        Console.WriteLine("S para continuar ou N para parar");
                        escolher = Console.ReadLine();
                        break;
               
                

                }

                


            }

        } 
    }
}
