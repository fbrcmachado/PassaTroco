using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troco
{
    class Program
    {
        static void Main(string[] args)
        {
            //var valorDaCompra = 100;//99.50;
            //var valorEntregue = 200;//101;
            //var cliente = new Cliente();
            ////cliente.Pagar(valorDaCompra, valorEntregue);
            //cliente.Pagar(50,200);
            //cliente.Pagar(10, 200);
            //cliente.Pagar(5, 200);
            //cliente.Pagar(1, 200);

            var caixa = new Caixa();
            caixa.ValorDaCompra = 387;
            caixa.Valorrecebido = 500;
            Pagar(caixa);
            //caixa.Pagar(200,190);
        }


        public static void Pagar(Caixa caixa)
        {
            var troco = DeterminaTroco(caixa);

            if (troco > 0)
            {

                var resultado = new Caixa();
                var listTroco = resultado.PassarTroco(caixa, troco);
                Console.WriteLine("Pagamento realizado e troco pago com sucesso!");
                foreach (var resposta in listTroco)
                {
                    Console.WriteLine(resposta);
                }
                Console.ReadKey();

            }
            else
            {
                if (troco == 0)
                {
                    Console.WriteLine("pagamento realizado com sucesso");
                    Console.WriteLine("não possue troco");
                }
                else
                    Console.WriteLine("valor insuficiente para realizar o pagamento");
            }
            Console.ReadKey();
        }

        public static double DeterminaTroco(Caixa caixa)
        {
            return (caixa.Valorrecebido - caixa.ValorDaCompra);
        }
    }
}


