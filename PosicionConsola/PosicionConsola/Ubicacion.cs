using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PosicionConsola
{
    class Ubicacion
    {
        public void Gotoxy(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }

        public Ubicacion()
        {
            int Posx, Posy;

            for (Posx = 20; Posx <= 60; Posx++) //lineas Horizontales
            {
                Gotoxy(Posx, 10);
                Console.Write("▄");
                Gotoxy(Posx, 20);
                Console.Write("▀");
                //Thread.Sleep(50);
            }
            for (Posy = 11; Posy <= 19; Posy++) //lineas Verticales
            {
                Gotoxy(20, Posy);
                Console.Write("█");

                Gotoxy(60, Posy);
                Console.Write("█");
                //Thread.Sleep(300);
            }


        }


        public void MovimientoH()
        {
            int Posx = 40, Posy = 15, Ban = 0, u = 0;
            while (u == 0)
            {
                if (Ban == 0)
                {
                    Posx++;
                    if (Posx == 60)
                    {
                        Ban = 1;
                    }
                    else
                    {
                        Gotoxy(Posx, Posy);
                        Console.WriteLine("█");
                        if (Posx > 21)
                        {
                            Gotoxy(Posx - 1, Posy);
                            Console.Write(" ");
                        }

                    }
                }



                if (Ban == 1)
                {
                    Posx--;
                    if (Posx == 20)
                    {
                        Ban = 0;
                    }
                    else
                    {
                        Gotoxy(Posx, Posy);
                        Console.WriteLine("█");
                        if (Posx < 59)
                        {
                            Gotoxy(Posx + 1, Posy);
                            Console.Write(" ");
                        }

                    }
                }
                Thread.Sleep(50);
            }
        }

    }
}

