using System;
using System.Collections.Generic;
using System.IO;

namespace OptimizingAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private List<Voo> CarregarVoos()
        {
            List<Voo> voos = new List<Voo>();
            string[] linhas = File.ReadAllLines("flights.txt");
            foreach (string linha in linhas)
            {
                string[] opcoes = linha.Split(',');
                string origem = opcoes[0];
                string destino = opcoes[1];
                string partida = opcoes[2];
                string chegada = opcoes[3];
                string preco = opcoes[4];
            }
        }
    }

    class Voo
    {
        public string Origem { get; set; }
        public string Destino { get; set; }
        public List<VooOpcao> VooOpcoes { get; set; }
    }
    class VooOpcao
    {
        public TimeOnly Partida { get; set; }
        public TimeOnly Chegada { get; set; }
        public decimal Preco { get; set; }
    }
}