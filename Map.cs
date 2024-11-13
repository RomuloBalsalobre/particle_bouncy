using System;
using System.Collections.Generic;

namespace map
{
    class Map
    {
        private int[] tamanho = new int[2];
        private string terreno = "";
        private string rastro = "."; // Caractere para o rastro da partícula
        private List<int[]> posicoesRastro = new List<int[]>(); // Armazena todas as posições de rastro

        public string _terreno
        {
            get { return terreno; }
            set { terreno = value; }
        }

        public int[] _tamanho
        {
            get { return tamanho; }
        }

        public void _setTamanho(int largura, int altura)
        {
            tamanho[0] = altura;
            tamanho[1] = largura;
        }

        public void Create(int x, int y, string particula)
        {
            Console.Clear(); // Limpa o console a cada iteração para atualizar o mapa

            // Adiciona a posição atual da partícula ao rastro
            posicoesRastro.Add(new int[] { x, y });

            for (int i = 0; i < tamanho[0]; i++)
            {
                string linha = "";
                for (int j = 0; j < tamanho[1]; j++)
                {
                    // Desenha a partícula na posição (x, y)
                    if (j == y && i == x)
                    {
                        linha += particula;
                    }
                    // Verifica se a posição (i, j) faz parte do rastro e desenha o caractere do rastro
                    else if (posicoesRastro.Exists(pos => pos[0] == i && pos[1] == j))
                    {
                        linha += rastro;
                    }
                    // Desenha as bordas do mapa
                    else if (i == 0 || i == tamanho[0] - 1)
                    {
                        linha += "-";
                    }
                    else if (j == 0 || j == tamanho[1] - 1)
                    {
                        linha += ":";
                    }
                    // Desenha o terreno vazio
                    else
                    {
                        linha += terreno;
                    }
                }
                Console.WriteLine(linha);
            }
        }
    }
}