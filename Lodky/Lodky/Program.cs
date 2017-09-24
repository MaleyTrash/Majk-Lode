using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lodky
{
    class Program
    {
        static void Main(string[] args)
        {   
            string[,] BoatPos = new string[12,12];
            string[,] Boats = new string[12,12];
            int[] Boattypes = [1, 2, 3, 4, 5];
            Neco.RenderField(1,BoatPos,Boats);
        }
    }
    class Neco
    {
        public static void RenderField(int Player, string[,] BoatPos, string[,] Boats)
        {
            for (int c = 0; c < BoatPos.GetLength(0); c++)
            {
                for (int b = 0; b < BoatPos.GetLength(1); b++)
                {
                    if (c == 0 || c == BoatPos.GetLength(0) - 1)
                    {
                        BoatPos[c, b] = "x ";
                    }
                    if (b == 0 && c != 0 && c != BoatPos.GetLength(0) - 1)
                    {
                        BoatPos[c, b] = "x";
                    }
                    if (c != 0 && b != 0 && c != BoatPos.GetLength(0) - 1 && b != BoatPos.GetLength(1) - 1)
                    {
                        BoatPos[c, b] = " -";
                    }
                    else
                    {
                        BoatPos[c, b] = " x";
                    }
                    if (BoatPos[c, b] == Boats[c, b])
                    {
                        BoatPos[c, b] = " +";
                    }
                }
            }
            RenderFullField(BoatPos);

        }
        public static void RenderFullField(string[,] BoatPos)
        {
            Console.Clear();
            Console.WriteLine("Rendered");
            Console.WriteLine("     A B C D E F G H I J");
            for (int c = 0; c < BoatPos.GetLength(0); c++)
            {
                if (c != 0 && c != 11 && c != 10)
                {
                    Console.Write(c + " ");
                }
                else if (c == 10)
                {
                    Console.Write(c);
                }
                else
                {
                    Console.Write("  ");

                }
                for (int b = 0; b < BoatPos.GetLength(1); b++)
                {
                    Console.Write(BoatPos[c, b]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public static void BoatField(string[,] Boats,int Player, string[,] BoatPos,int[] Boattype,int Boat)
        {
            int b = 1;
            int c = 5;
            ConsoleKeyInfo name = Console.ReadKey();
            //Console.WriteLine(name.Key);
            while (true)
            {
                if (name.Key == ConsoleKey.DownArrow)
                {
                    b += 1;
                    for (int i = 0; i < Boattype[Boat]; i++)
                    {
                        if (b > 10)
                        {
                            b = 10;
                        }
                        Boats[c + i, b] = " -";
                    }
                        
                }
                if (name.Key == ConsoleKey.UpArrow)
                {
                    b -= 1;
                    for (int i = 0; i < Boattype[Boat]; i++)
                    {
                        if (b > 1)
                        {
                            b = 1;
                        }
                        Boats[c + i, b] = " -";
                    }
                }
                if (name.Key == ConsoleKey.RightArrow)
                {
                    c += 1;
                    for (int i = 0; i < Boattype[Boat]; i++)
                    {
                        if (c > 1)
                        {
                            c = 1;
                        }
                        Boats[c, b + i] = " -";
                    }
                }
                if (name.Key == ConsoleKey.LeftArrow)
                {
                    c -= 1;
                    for (int i = 0; i < Boattype[Boat]; i++)
                    {
                        if (b > 1)
                        {
                            b = 1;
                        }
                        Boats[c, b + i] = " -";
                    }
                }
                else if(name.Key == ConsoleKey.Enter)
                {
                    break;
                }
            }
            RenderField(Player, BoatPos, Boats);
        }
    }
}
