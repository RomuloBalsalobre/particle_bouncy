using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using map;
using particle;

namespace program
{
    class Program
    {
        static void Main(String[] args)
        {
            int sentidox = 1;
            int sentidoy = 1;
            Map mapa = new Map();
            Particle particula = new Particle();
            particula._newPosition(2,1);
            mapa._terreno = "~";
            mapa._setTamanho(20,5);
            int x = particula._position[0];
            int y = particula._position[1];
            while(true)
            {
                Console.Clear();
                if (x == 0)
                {
                    sentidox*=-1;
                }
                if (y == mapa._tamanho[1]-1)
                {
                    sentidoy *= -1;
                }
                if (y < 1)
                {
                    sentidoy *= -1;
                }
                if  (x== mapa._tamanho[0])
                {
                    sentidox *= -1;
                }

                mapa.Create(x,y,particula._forma);
                /*ConsoleKeyInfo move =  Console.ReadKey(true);

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
                }*/
                y+=1*sentidoy;
                x+=1*sentidox;
                particula._newPosition(x,y);
                Thread.Sleep(100);
            }
        }
    }
}