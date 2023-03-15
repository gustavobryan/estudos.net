using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int idade = int.Parse(Console.ReadLine());

            if (idade >= 0 && idade <= 11) {
                Console.WriteLine("criança");
            } else if (idade >= 11 && idade <= 18) {
                Console.WriteLine("adolescente");
            } else if (idade >= 18 && idade <= 60) {
                Console.WriteLine("adulto");
            } if (idade >= 60) {
                Console.WriteLine("idoso");
            }
            

            
            Console.ReadLine();
        }
    }
}
