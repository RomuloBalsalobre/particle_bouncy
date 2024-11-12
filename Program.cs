using System;
using map;
using particle;

namespace program
{
    class Program
    {
        static void Main(String[] args)
        {
            Map mapa = new Map();
            Particle particula = new Particle();
            particula._newPosition(0,0);
            mapa._terreno = "^";
            mapa._setTamanho(8,8);

            while(true)
            {
                Console.Clear();
                if (particula._position[1] == mapa._tamanho[1])
                {
                    particula._newPosition(particula._position[0],0);
                    mapa._terreno = ";";
                }
                if (particula._position[1] < 0)
                {
                    particula._newPosition(particula._position[0],mapa._tamanho[1]-1);
                    mapa._terreno = "^";
                }
                if  (particula._position[0]== mapa._tamanho[0])
                {
                    particula._newPosition(0,particula._position[1]);
                    mapa._terreno = "~";
                }

                mapa.Create(particula._position[0],
                            particula._position[1],
                            particula._forma);
                ConsoleKeyInfo move =  Console.ReadKey(true);

                switch(move.Key)
                {
                    case ConsoleKey.RightArrow:
                        particula._newPosition(particula._position[0],particula._position[1]+1);
                        continue;
                    case ConsoleKey.LeftArrow:
                        particula._newPosition(particula._position[0],particula._position[1]-1);
                        continue;
                    case ConsoleKey.UpArrow:
                        particula._newPosition(particula._position[0]-1,particula._position[1]);
                        continue;
                    case ConsoleKey.DownArrow:
                        particula._newPosition(particula._position[0]+1,particula._position[1]);
                        continue;
                }
            }
        }
    }
}