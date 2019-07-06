using System;

namespace Exemplo {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("entre com seu nome: ");
            string a = Console.ReadLine();
            Console.WriteLine("entre com sua idade");
            int b = int.Parse(Console.ReadLine());

            if ( b >= 18){
                Console.WriteLine("é maior de idade ");
            }
            else {
                Console.WriteLine("menor de idade ");
            }
                                   

        }
    }
}
