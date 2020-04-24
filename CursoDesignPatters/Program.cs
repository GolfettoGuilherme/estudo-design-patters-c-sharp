using System;

namespace CursoDesignPatters
{
    class Program
    {
        static void Main(string[] args)
        {
            var iss = new ISS();
            var icsm = new ICMS();
            var iccc = new ICCC();

            Orcamento orcamento = new Orcamento(2000.0);

            Console.WriteLine(iss.Calcula(orcamento));
            Console.WriteLine(icsm.Calcula(orcamento));
            Console.WriteLine(iccc.Calcula(orcamento));
        }
    }
}
