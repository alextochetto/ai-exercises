using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace GreedyAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Vertice portoUniao = new Vertice() { Rotulo = "Porto União", Distancia = 203 };
            Vertice pauloFrontin = new Vertice() { Rotulo = "Paulo Frontin", Distancia = 172 };
            Vertice canoinhas = new Vertice() { Rotulo = "Canoinhas", Distancia = 141 };
            Vertice irati = new Vertice() { Rotulo = "Irati", Distancia = 139 };
            Vertice palmeira = new Vertice() { Rotulo = "Palmeira", Distancia = 59 };
            Vertice campoLargo = new Vertice() { Rotulo = "Campo Largo", Distancia = 27 };
            Vertice curitiba = new Vertice() { Rotulo = "Curitiba", Distancia = 0 };
            Vertice balsaNova = new Vertice() { Rotulo = "Balsa Nova", Distancia = 41 };
            Vertice araucaria = new Vertice() { Rotulo = "Araucária", Distancia = 23 };
            Vertice saoJose = new Vertice() { Rotulo = "São José dos Pinhais", Distancia = 13 };
            Vertice contenda = new Vertice() { Rotulo = "Contenda", Distancia = 39 };
            Vertice mafra = new Vertice() { Rotulo = "Mafra", Distancia = 94 };
            Vertice tijucas = new Vertice() { Rotulo = "Tijucas do Sul", Distancia = 56 };
            Vertice lapa = new Vertice() { Rotulo = "Lapa", Distancia = 74 };
            Vertice saoMateus = new Vertice() { Rotulo = "São Mateus do Sul", Distancia = 123 };
            Vertice tresBarras = new Vertice() { Rotulo = "Três Barras", Distancia = 131 };

            portoUniao.Adjacentes.Add(new Adjacente { Vertice = pauloFrontin, Custo = 46 });
            portoUniao.Adjacentes.Add(new Adjacente { Vertice = canoinhas, Custo = 78 });
            portoUniao.Adjacentes.Add(new Adjacente { Vertice = saoMateus, Custo = 87 });

            pauloFrontin.Adjacentes.Add(new Adjacente { Vertice = portoUniao, Custo = 46 });
            pauloFrontin.Adjacentes.Add(new Adjacente { Vertice = irati, Custo = 75 });

            canoinhas.Adjacentes.Add(new Adjacente { Vertice = portoUniao, Custo = 78 });
            canoinhas.Adjacentes.Add(new Adjacente { Vertice = tresBarras, Custo = 12 });
            canoinhas.Adjacentes.Add(new Adjacente { Vertice = mafra, Custo = 66 });

            irati.Adjacentes.Add(new Adjacente { Vertice = pauloFrontin, Custo = 75 });
            irati.Adjacentes.Add(new Adjacente { Vertice = palmeira, Custo = 75 });
            irati.Adjacentes.Add(new Adjacente { Vertice = saoMateus, Custo = 57 });

            palmeira.Adjacentes.Add(new Adjacente { Vertice = irati, Custo = 75 });
            palmeira.Adjacentes.Add(new Adjacente { Vertice = saoMateus, Custo = 77 });
            palmeira.Adjacentes.Add(new Adjacente { Vertice = campoLargo, Custo = 55 });

            campoLargo.Adjacentes.Add(new Adjacente { Vertice = palmeira, Custo = 55 });
            campoLargo.Adjacentes.Add(new Adjacente { Vertice = balsaNova, Custo = 22 });
            campoLargo.Adjacentes.Add(new Adjacente { Vertice = curitiba, Custo = 29 });

            curitiba.Adjacentes.Add(new Adjacente { Vertice = campoLargo, Custo = 29 });
            curitiba.Adjacentes.Add(new Adjacente { Vertice = balsaNova, Custo = 51 });
            curitiba.Adjacentes.Add(new Adjacente { Vertice = araucaria, Custo = 37 });
            curitiba.Adjacentes.Add(new Adjacente { Vertice = saoJose, Custo = 15 });

            balsaNova.Adjacentes.Add(new Adjacente { Vertice = curitiba, Custo = 51 });
            balsaNova.Adjacentes.Add(new Adjacente { Vertice = campoLargo, Custo = 22 });
            balsaNova.Adjacentes.Add(new Adjacente { Vertice = contenda, Custo = 19 });

            araucaria.Adjacentes.Add(new Adjacente { Vertice = curitiba, Custo = 37 });
            araucaria.Adjacentes.Add(new Adjacente { Vertice = contenda, Custo = 18 });

            saoJose.Adjacentes.Add(new Adjacente { Vertice = curitiba, Custo = 15 });
            saoJose.Adjacentes.Add(new Adjacente { Vertice = tijucas, Custo = 49 });

            contenda.Adjacentes.Add(new Adjacente { Vertice = balsaNova, Custo = 19 });
            contenda.Adjacentes.Add(new Adjacente { Vertice = araucaria, Custo = 18 });
            contenda.Adjacentes.Add(new Adjacente { Vertice = lapa, Custo = 26 });

            mafra.Adjacentes.Add(new Adjacente { Vertice = tijucas, Custo = 99 });
            mafra.Adjacentes.Add(new Adjacente { Vertice = lapa, Custo = 57 });
            mafra.Adjacentes.Add(new Adjacente { Vertice = canoinhas, Custo = 66 });

            tijucas.Adjacentes.Add(new Adjacente { Vertice = mafra, Custo = 99 });
            tijucas.Adjacentes.Add(new Adjacente { Vertice = saoJose, Custo = 49 });

            lapa.Adjacentes.Add(new Adjacente { Vertice = contenda, Custo = 26 });
            lapa.Adjacentes.Add(new Adjacente { Vertice = saoMateus, Custo = 60 });
            lapa.Adjacentes.Add(new Adjacente { Vertice = mafra, Custo = 57 });

            saoMateus.Adjacentes.Add(new Adjacente { Vertice = palmeira, Custo = 77 });
            saoMateus.Adjacentes.Add(new Adjacente { Vertice = irati, Custo = 57 });
            saoMateus.Adjacentes.Add(new Adjacente { Vertice = lapa, Custo = 60 });
            saoMateus.Adjacentes.Add(new Adjacente { Vertice = tresBarras, Custo = 43 });
            saoMateus.Adjacentes.Add(new Adjacente { Vertice = portoUniao, Custo = 87 });

            tresBarras.Adjacentes.Add(new Adjacente { Vertice = saoMateus, Custo = 43 });
            tresBarras.Adjacentes.Add(new Adjacente { Vertice = canoinhas, Custo = 12 });

            // Vetor Ordenado
            Vetor vetor = new Vetor(5);
            vetor.Inserir(palmeira);
            vetor.Inserir(lapa);
            vetor.Inserir(campoLargo);
            vetor.Inserir(curitiba);
            vetor.Inserir(contenda);
            vetor.Imprimir();

            //Busca Gulosa
            Greedy greedy = new Greedy();
            greedy.Objetivo = curitiba;
            greedy.Buscar(portoUniao);
        }
    }

    class Vertice
    {
        public string Rotulo { get; set; }
        public int Distancia { get; set; }
        public bool Visitado { get; set; }
        public List<Adjacente> Adjacentes { get; set; }
        public Vertice()
        {
            this.Adjacentes = new List<Adjacente>();
        }
    }

    class Adjacente
    {
        public Vertice Vertice { get; set; }
        public int Custo { get; set; }
    }

    class Vetor
    {
        public int Capacidade { get; set; } = 1;
        public int UltimaPosicao { get; set; } = -1;
        public Vertice[] Vertices { get; set; }
        public Vetor(int capacidade)
        {
            this.Vertices = new Vertice[capacidade];
        }

        public void Inserir(Vertice vertice)
        {
            this.Capacidade++;
            if (this.UltimaPosicao == this.Capacidade - 1)
            {
                Console.WriteLine("Capacidade máxima atingida");
                Console.ReadLine();
                return;
            }
            int posicao = 0;
            for (int i = 0; i <= this.UltimaPosicao; i++)
            {
                posicao = i;
                if (this.Vertices[i].Distancia > vertice.Distancia)
                {
                    break;
                }
                if (i == this.UltimaPosicao)
                {
                    posicao = i + 1;
                }
            }
            int x = this.UltimaPosicao;
            while (x >= posicao)
            {
                this.Vertices[x + 1] = this.Vertices[x];
                x -= 1;
            }
            this.Vertices[posicao] = vertice;
            this.UltimaPosicao++;
        }

        public void Imprimir()
        {
            if (this.UltimaPosicao == -1)
            {
                Console.WriteLine("O vetor está vazio");
            }
            else
            {
                for (int i = 0; i <= this.UltimaPosicao; i++)
                {
                    Console.WriteLine($"{i} - {this.Vertices[i].Rotulo} - {this.Vertices[i].Distancia}");
                }
            }
        }
    }

    class Greedy
    {
        public Vertice Objetivo { get; set; }
        public bool Encontrado { get; set; }

        public void Buscar(Vertice atual)
        {
            Console.WriteLine("----------");
            Console.WriteLine($"Atual: {atual.Rotulo}");
            atual.Visitado = true;
            if (atual == this.Objetivo)
            {
                this.Encontrado = true;
            }
            else
            {
                Vetor vetor = new Vetor(atual.Adjacentes.Count);
                foreach (Adjacente adjacente in atual.Adjacentes)
                {
                    if (!adjacente.Vertice.Visitado)
                    {
                        adjacente.Vertice.Visitado = true;
                        vetor.Inserir(adjacente.Vertice);
                    }
                }
                vetor.Imprimir();
                if (vetor.Vertices[0] != null)
                {
                    Buscar(vetor.Vertices[0]);
                }
            }
        }
    }
}
