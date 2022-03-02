using StateTest.Classes;
using System;

namespace StateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Orcamento reforma = new Orcamento(500);
                Console.WriteLine(reforma.Valor);

                reforma.AplicaDescontoExtra();
                Console.WriteLine(reforma.Valor);

                reforma.AplicaDescontoExtra();
                Console.WriteLine(reforma.Valor);

                reforma.Aprova();

                reforma.AplicaDescontoExtra();
                Console.WriteLine(reforma.Valor);

                reforma.Finaliza();
                reforma.AplicaDescontoExtra();

                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
