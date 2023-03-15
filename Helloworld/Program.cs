using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExibirMsg();
            GerarPreco(-20);
            GerarPreco(-90);
            GerarPreco(-120);


            Console.ReadLine();
        }

        static void ExibirMsg()
        {
            Console.WriteLine("Esse sistema é top!");
            Console.WriteLine("Bem-vindo!");
            Console.WriteLine("Volte sempre!");
        }

        static void GerarPreco(int preco)
        {
            int precoAbs = Math.Abs(preco);
            int valorFinal = precoAbs + (2 * precoAbs);
            Console.WriteLine("Valor final: " + valorFinal);
        }
    }
}
