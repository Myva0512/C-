using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ManejoConsola
{
    internal class Ubicacion
    {
        int i, j;
        public void Gotoxy(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }
        public Ubicacion()
        {
            int Posx, Posy;
            // Lineas horizontales
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (Posx = 20; Posx <= 60; Posx++)
            {
                Gotoxy(Posx, 10);
                Console.Write("▄");
                Gotoxy(Posx, 20);
                Console.Write("▀");
                //Thread.Sleep(50);
            }
            // Lineas verticales
            for (Posy = 10; Posy <= 20; Posy++)
            {
                Gotoxy(20, Posy);
                Console.Write("█");
                Gotoxy(60, Posy);
                Console.Write("█");
                //Thread.Sleep(50);
            }
        }

        public void Movimiento()
        {
            int Posx = 40, Posy = 15, Ban = 0,Ban1=1, u = 0, PX1=0,PY1=0;
            while (u == 0)
            {
                // Movimiento Horizontal
                Console.ForegroundColor = ConsoleColor.Red;
                while (u == 0)
                {
                    if (Ban == 0)
                    {
                        PX1 = Posx;
                        Posx++;
                        if (Posx == 59)
                        {
                            Ban = 1;
                        }
                       
                    }
                    else
                    {
                        PX1 = Posx;
                        Posx--;
                        if (Posx == 21)
                        {
                            Ban = 0;
                        }
                        
                    }

                    if (Ban1 == 0)
                    {
                        PY1 = Posy;
                        Posy++;
                        if (Posy == 19)
                        {
                            Ban1 = 1;
                        }
                    }
                    else
                    {
                        PY1 = Posy;
                        Posy--;
                        if (Posy == 11)
                        {
                            Ban1 = 0;
                        }

                    }

                    Gotoxy(PX1, PY1);
                    Console.WriteLine(" ");
                    Gotoxy(Posx, Posy);
                    Console.WriteLine("■");
                    Thread.Sleep(50);
                   
                }
               


            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ubicacion IG1 = new Ubicacion();
            IG1.Movimiento();
            Console.ReadKey();
        }
    }
}
