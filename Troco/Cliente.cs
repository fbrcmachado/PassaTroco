//using System;

//namespace Troco
//{
//    public class Cliente
//    {
//        int[] notasDisponiveis = { 100, 50, 10, 5, 1 };
//        double[] moedasDisponiveis = { 0.50, 0.10, 0.05, 0.01 };

//        void exibirResultado(double _valorCompra, double _valorPago, string _retorno)
//        {
//            Console.WriteLine("Valor da Compra: " + _valorCompra);
//            Console.WriteLine("Valor Pago: " + _valorPago);
//            Console.WriteLine(_retorno);
//            Console.WriteLine();
//            Console.ReadKey();
//        }
        
//        public void Pagar(double valorCompra, double valorPago)
//        {
//            string retorno = "Troco: 0.00";
//            //string valorNotas =;
//            string valorMoedas;
//            if (valorPago > valorCompra && valorPago != valorCompra)
//            {
//                //var centavos = (valorPago % valorCompra) * 100;
//                var trocoRealCentavos = (valorPago - valorCompra);
//                int trocoReal = (int)trocoRealCentavos;//(valorPago - valorCompra);
//                var trocoCentavos = trocoRealCentavos - trocoReal;

//                foreach (var notas in notasDisponiveis)
//                {
//                    string sufixoNotas = "";
//                    var qtdNotas = trocoReal / notas;

//                    if (notas != 1)
//                        sufixoNotas = " Reais";
//                    else
//                        sufixoNotas = " Real";
                    
//                    if ((qtdNotas * notas) == trocoReal)
//                        break;


//                    void getValorNotas()
//                    {
//                        //valorNotas = qtdNotas + " nota(s) de " + notas + sufixoNotas;
//                    }



//                    //foreach (var moedas in moedasDisponiveis)
//                    //{
//                    //    if (moedas >= trocoCentavos)
//                    //    {
//                    //        if (moedas == trocoCentavos)
//                    //        {
//                    //            valorMoedas = moedas + " centavo(s) de" + trocoCentavos;
//                    //        }

//                    //    }
//                    //}

//                    if (trocoCentavos != 0.99 || trocoCentavos == 0.00)
//                    {
//                        //retorno = "O troco com o número menor de cédulas é: " + valorNotas;
//                        //retorno = "O troco com o número menor de cédulas é: " + result + " nota(s) de " + notas + sufixo;
//                    }
//                }
//            }
//            if (valorPago < valorCompra)
//            {
//                var valorPendente = valorCompra - valorPago;
//                Console.WriteLine("O valor entregue é insuficiente para o total da compra!");
//                retorno = "Valor Pendente: " + (valorPendente);
//            }

//            exibirResultado(valorCompra, valorPago, retorno);
//        }
//    }
//}