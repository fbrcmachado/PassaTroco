using System;
using System.Collections.Generic;

namespace Troco
{
    public class Caixa
    {
        public Caixa()
        {
            NotasDisponiveis = new List<int>();
            PreencherCaixa();
        }

        public List<int> NotasDisponiveis { get; set; }
        public double Valorrecebido { get; set; }
        public double ValorDaCompra { get; set; }

        public List<string> PassarTroco(Caixa caixa, double troco)
        {

            var quantidadeNotasTroco = new List<string>();
            int qtdNotas;
            double valorDevolvido;

            foreach (var valorNota in caixa.NotasDisponiveis)
            {
                if (troco >= valorNota)
                {
                    qtdNotas = (int)(troco / valorNota);
                    quantidadeNotasTroco.Add(qtdNotas + " de " + valorNota + " reais;");
                    troco = troco - (qtdNotas * valorNota);
                }
            }

            return quantidadeNotasTroco;
        }

        public void PreencherCaixa()
        {
            NotasDisponiveis.Add(100);
            NotasDisponiveis.Add(50);
            NotasDisponiveis.Add(20);
            NotasDisponiveis.Add(10);
            NotasDisponiveis.Add(5);
            NotasDisponiveis.Add(1);
        }



    }
}

