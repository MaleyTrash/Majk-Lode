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
            string[,] BoatPos = new string[12, 12];

            string[,] BoatsPO = new string[12, 12];
            string[,] BoatsPT = new string[12, 12];
            string[,] BoatsTemp = new string[12, 12];

            BoatsTemp[1, 1] = " -";

            string[,] FireField = new string[12, 12];

            string[,] FireFieldPO = new string[12, 12];
            string[,] FireFieldPT = new string[12, 12];
            string[,] FireFieldTemp = new string[12, 12];

            int[] Boattypes = new int[] { 1, 2, 3, 4, 5 };
            Neco.RenderField(1, BoatPos, true, 1, 1, 0, Boattypes, BoatsPO, BoatsPT, BoatsTemp, false, FireField, FireFieldPO, FireFieldPT, FireFieldTemp,false,false,false);

        }
    }
    class Neco
    {
        public static void RenderField(int Player, string[,] BoatPos, bool check, int bB, int cB, int boat, int[] Boattypes, string[,] BoatsPO, string[,] BoatsPT, string[,] BoatsTemp, bool BoatFieldCh, string[,] FireField, string[,] FireFieldPO, string[,] FireFieldPT, string[,] FireFieldTemp, bool Field, bool FireFieldCh, bool Rotate)
        {

            Console.Clear();
            /*Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(bB + " " + cB);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Rotate " + Rotate);*/
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Player " + Player);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("     A B C D E F G H I J");
            Console.ResetColor();
            for (int c = 0; c < BoatPos.GetLength(0); c++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
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
                    if (c == 0 || c == BoatPos.GetLength(0) - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        BoatPos[c, b] = "x ";
                    }
                    if (b == 0 && c != 0 && c != BoatPos.GetLength(0) - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        BoatPos[c, b] = "x";
                    }
                    if (c != 0 && b != 0 && c != BoatPos.GetLength(0) - 1 && b != BoatPos.GetLength(1) - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        BoatPos[c, b] = " -";
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        BoatPos[c, b] = " x";
                    }

                    if (Player == 1)
                    {

                        if (BoatPos[c, b] == BoatsTemp[c, b])
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;

                            BoatPos[c, b] = " +";
                        }
                        if (BoatPos[c, b] == BoatsPO[c, b])
                        {
                            if (FireFieldPT[c, b] == BoatsPO[c, b])
                            {
                                Console.ForegroundColor = ConsoleColor.Red;

                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.White;

                            }
                            BoatPos[c, b] = " +";
                        }
                        if (BoatsPO[c, b] == " -" && BoatsTemp[c, b] == " -")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;

                            BoatPos[c, b] = " 0";
                        }

                    }
                    else
                    {


                        if (BoatPos[c, b] == BoatsTemp[c, b])
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;

                            BoatPos[c, b] = " +";
                        }
                        if (BoatPos[c, b] == BoatsPT[c, b])
                        {
                            if (FireFieldPO[c, b] == BoatsPT[c, b])
                            {
                                Console.ForegroundColor = ConsoleColor.Red;

                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.White;

                            }
                            BoatPos[c, b] = " +";
                        }
                        if (BoatsPT[c, b] == " -" && BoatsTemp[c, b] == " -")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;

                            BoatPos[c, b] = " 0";
                        }

                    }

                    Console.Write(BoatPos[c, b]);
                    Console.ResetColor();
                    if (c == 4 && b == 11)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("    -");
                        Console.ResetColor();
                        Console.Write(" - Mapa");
                    }
                    if (c == 5 && b == 11)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("    X");
                        Console.ResetColor();
                        Console.Write(" - Hranice mapy");
                    }
                    if (c == 6 && b == 11)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("    +");
                        Console.ResetColor();
                        Console.Write(" - Nepoložená loď");
                    }
                    if (c == 7 && b == 11)
                    {
                        Console.Write("    +");
                        Console.Write(" - Položená loď");
                    }
                    if (c == 8 && b == 11)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("    +");
                        Console.ResetColor();
                        Console.Write(" - Zníčená loď");
                    }
                    if (c == 9 && b == 11)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("    0");
                        Console.ResetColor();
                        Console.Write(" - Loďe se překrývají");
                    }

                }
                Console.WriteLine();

            }
            if (BoatFieldCh)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lodě se nesmí překrývat!!!");
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("     A B C D E F G H I J");
            Console.ResetColor();
            for (int c = 0; c < FireField.GetLength(0); c++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
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
                for (int b = 0; b < FireField.GetLength(1); b++)
                {
                    if (c == 0 || c == FireField.GetLength(0) - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        FireField[c, b] = "x ";
                    }
                    if (b == 0 && c != 0 && c != FireField.GetLength(0) - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        FireField[c, b] = "x";
                    }
                    if (c != 0 && b != 0 && c != FireField.GetLength(0) - 1 && b != FireField.GetLength(1) - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        FireField[c, b] = " -";
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        FireField[c, b] = " x";
                    }
                    if (Player == 1)
                    {
                        if (FireField[c, b] == FireFieldTemp[c, b])
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            FireField[c, b] = " +";
                        }
                        if (FireField[c, b] == FireFieldPO[c, b])
                        {
                            if (FireFieldPO[c, b] == BoatsPT[c, b])
                            {
                                FireField[c, b] = " x";
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else
                            {
                                FireField[c, b] = " +";
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                        }
                        if (FireFieldPO[c, b] == " -" && FireFieldTemp[c, b] == " -")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            FireField[c, b] = " 0";
                        }

                    }
                    else
                    {
                        if (FireField[c, b] == FireFieldTemp[c, b])
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            FireField[c, b] = " +";
                        }
                        if (FireField[c, b] == FireFieldPT[c, b])
                        {
                            if (FireFieldPT[c, b] == BoatsPO[c, b])
                            {
                                FireField[c, b] = " x";
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else
                            {
                                FireField[c, b] = " +";
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                        }
                        if (FireFieldPT[c, b] == " -" && FireFieldTemp[c, b] == " -")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            FireField[c, b] = " 0";
                        }

                    }
                   
                    Console.Write(FireField[c, b]);
                    Console.ResetColor();
                    if (c == 5 && b == 11)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("    X");
                        Console.ResetColor();
                        Console.Write(" - Zásah");
                    }
                    if (c == 6 && b == 11)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("    +");
                        Console.ResetColor();
                        Console.Write(" - Pozice výstřelu");
                    }
                    if (c == 7 && b == 11)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("    +");
                        Console.ResetColor();
                        Console.Write(" - Minutí");
                    }
                    
                    if (c == 8 && b == 11)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("    0");
                        Console.ResetColor();
                        Console.Write(" - Výstřely se překrývají");
                    }
                }
                Console.WriteLine();

            }
            if (FireFieldCh)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Na tuto pozici bylo již vystřeleno!!!");
                Console.ResetColor();
            }

            if(Player == 2)
            {
                check = WinCheck(FireFieldPO, BoatsPT);
            }

            else
            {
                check = WinCheck(FireFieldPT, BoatsPO);
            }
            if (check)
            {
                BoatField(Player, Boattypes, boat, bB, cB, BoatPos, BoatsPO, BoatsPT, BoatsTemp, FireField, FireFieldPO, FireFieldPT, FireFieldTemp,Field, FireFieldCh,Rotate);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if(Player == 1)
                {
                    Console.WriteLine("Zvítězil hráč 2");

                }
                else
                {
                    Console.WriteLine("Zvítězil hráč 1");

                }
                Console.ResetColor();
                Console.ReadKey();
            }

        }
        public static void BoatField(int Player, int[] Boattype, int Boat, int b, int c, string[,] BoatPos, string[,] BoatsPO, string[,] BoatsPT, string[,] BoatsTemp, string[,] FireField, string[,] FireFieldPO, string[,] FireFieldPT, string[,] FireFieldTemp,bool Field,bool FireFieldCh,bool Rotate)
        {
            ConsoleKeyInfo name = Console.ReadKey();
            if (name.Key == ConsoleKey.R)
            {
                if (!Rotate)
                {
                    Rotate = true;

                }
                else
                {
                    Rotate = false ;
                }
                RenderField(Player, BoatPos, true, b, c, Boat, Boattype, BoatsPO, BoatsPT, BoatsTemp, false, FireField, FireFieldPO, FireFieldPT, FireFieldTemp, Field, FireFieldCh, Rotate);
            }
            if (name.Key == ConsoleKey.DownArrow)
            {
                if (!Field)
                {
                    c += 1;
                    BoatsTemp = new string[12, 12];

                    for (int i = 0; i < Boattype[Boat]; i++)
                    {

                        if (c > 10)
                        {
                            c = 10;
                        }
                        
                        
                        if (Rotate)
                        {
                            if (c + Boattype[Boat] > 10)
                            {
                                c = 11 - Boattype[Boat];
                            }
                            
                            BoatsTemp[c + i, b] = " -";

                        }
                        else
                        {
                            if (c > 10)
                            {
                                c = 10;
                            }
                            BoatsTemp[c, b + i] = " -";
                        }


                    }
                }
                else
                {
                    c += 1;
                    for (int i = 0; i < 1; i++)
                    {
                        if (c > 10)
                        {
                            c = 10;
                        }
                     
                        FireFieldTemp[c - 1, b + i] = " ";
                        FireFieldTemp[c, b + i] = " -";

                    }
                }
                RenderField(Player, BoatPos, true, b, c, Boat, Boattype, BoatsPO, BoatsPT, BoatsTemp, false, FireField, FireFieldPO, FireFieldPT, FireFieldTemp,Field, FireFieldCh, Rotate);

            }
            if (name.Key == ConsoleKey.UpArrow)
            {
                if (!Field)
                {
                    c -= 1;
                    BoatsTemp = new string[12, 12];
                    if (c == 0)
                    {
                        c = 1;
                    }
                    for (int i = 0; i < Boattype[Boat]; i++)
                    {
                        if (Rotate)
                        {
                            BoatsTemp[c + i, b] = " -";
                        }
                        else
                        {

                            BoatsTemp[c, b + i] = " -";
                        }

                    }
                }
                else
                {
                    c -= 1;
                    for (int i = 0; i < 1; i++)
                    {
                        if (c == 0)
                        {
                            c = 1;
                        }
                        FireFieldTemp[c + 1, b + i] = " ";
                        FireFieldTemp[c, b + i] = " -";

                    }
                }
                RenderField(Player, BoatPos, true, b, c, Boat, Boattype, BoatsPO, BoatsPT, BoatsTemp, false, FireField, FireFieldPO, FireFieldPT, FireFieldTemp, Field, FireFieldCh, Rotate);
            }
            if (name.Key == ConsoleKey.RightArrow)
            {
                if (!Field)
                {
                    b += 1;
                    BoatsTemp = new string[12, 12];
                    if (Rotate)
                    {
                        if(b > 10)
                        {
                            b = 10;
                        }
                        for (int i = 0; i < Boattype[Boat]; i++)
                        {
                            BoatsTemp[c + i, b] = " -";
                        }
                    }
                    else
                    {

                        if (b + Boattype[Boat] > 10)
                        {
                            b = 11 - Boattype[Boat];
                        }
                        for (int i = 0; i < Boattype[Boat]; i++)
                        {
                            BoatsTemp[c, b + i] = " -";
                        }
                    }

                }
                else
                {
                    b += 1;
                    if (b >= 10)
                    {
                        b = 10;
                    }
                    FireFieldTemp[c, b - 1] = " ";
                    FireFieldTemp[c, b] = " -";
                }
               
                RenderField(Player, BoatPos, true, b, c, Boat, Boattype, BoatsPO, BoatsPT, BoatsTemp, false, FireField, FireFieldPO, FireFieldPT, FireFieldTemp, Field, FireFieldCh, Rotate);
            }
            if (name.Key == ConsoleKey.LeftArrow)
            {
                if (!Field)
                {
                    b -= 1;
                    BoatsTemp = new string[12, 12];
                    if (b < 1)
                    {
                        b = 1;
                    }
                    if (Rotate)
                    {
                        for (int i = 0; i < Boattype[Boat]; i++)
                        {
                            BoatsTemp[c + i, b] = " -";
                        }
                    }
                    else
                    {
                        for(int i=0;i < Boattype[Boat];i++)
                        {
                            BoatsTemp[c, b + i] = " -";
                        }
                    }
                    
                }
                else
                {
                    b -= 1;
                    if (b <= 1)
                    {
                        b = 1;
                    }
                    FireFieldTemp[c, b + 1] = " ";
                    FireFieldTemp[c, b] = " -";
                }
               
                RenderField(Player, BoatPos, true, b, c, Boat, Boattype, BoatsPO, BoatsPT, BoatsTemp, false, FireField, FireFieldPO, FireFieldPT, FireFieldTemp, Field, FireFieldCh, Rotate);
            }
            else if (name.Key == ConsoleKey.Enter)
            {
                bool BoatFieldCh = false;
                if (!Field)
                {
                    if (Player == 1)
                    {
                        BoatFieldCh = BoatFieldCheck(BoatsPO, BoatsTemp);
                    }
                    else
                    {
                        BoatFieldCh = BoatFieldCheck(BoatsPT, BoatsTemp);
                    }
                    if (!BoatFieldCh)
                    {
                        if (Boat <= Boattype.GetLength(0))
                        {
                            if (Player == 1)
                            {

                                for (int i = 0; i < Boattype[Boat]; i++)
                                {
                                    if (Rotate)
                                    {
                                        BoatsPO[c + i, b] = " -";
                                    }else
                                    {
                                        BoatsPO[c, b + i] = " -";
                                    }
                                }
                            }
                            else
                            {
                                for (int i = 0; i < Boattype[Boat]; i++)
                                {
                                    if (Rotate)
                                    {
                                        BoatsPT[c + i, b] = " -";
                                    }
                                    else
                                    {
                                        BoatsPT[c, b + i] = " -";
                                    }
                                }
                            }
                        }

                        Boat += 1;

                        if (Boat >= Boattype.GetLength(0))
                        {
                            Rotate = false;
                            if (Player == 1)
                            {
                                Player = 2;
                                Boat = 0;
                            }
                            else
                            {
                                Boat = 0;
                                Player = 1;
                                FireFieldTemp[1, 1] = " -";
                                Field = true;
                            }
                        }

                        b = 1;
                        c = 1;
                        BoatsTemp = new string[12, 12];
                        if (5 >= Boat && !Field)
                        {
                            for (int i = 0; i < Boattype[Boat]; i++)
                            {
                                if (Rotate)
                                {
                                    BoatsTemp[c + i, b] = " -";
                                }
                                else
                                {
                                    BoatsTemp[c, b + i] = " -";
                                }
                            }
                        }
                        RenderField(Player, BoatPos, true, b, c, Boat, Boattype, BoatsPO, BoatsPT, BoatsTemp, BoatFieldCh, FireField, FireFieldPO, FireFieldPT, FireFieldTemp, Field, FireFieldCh, Rotate);
                    }
                    else
                    {
                        RenderField(Player, BoatPos, true, b, c, Boat, Boattype, BoatsPO, BoatsPT, BoatsTemp, BoatFieldCh, FireField, FireFieldPO, FireFieldPT, FireFieldTemp, Field, FireFieldCh, Rotate);
                    }
                }
                else
                {
                    if (Field)
                    {
                        if (Player == 1)
                        {
                            FireFieldCh = BoatFieldCheck(FireFieldPO, FireFieldTemp);
                        }
                        else
                        {
                            FireFieldCh = BoatFieldCheck(FireFieldPT, FireFieldTemp);
                        }
                        if (!FireFieldCh)
                        {
                            if (Player == 1)
                            {
                                FireFieldPO[c, b] = FireFieldTemp[c, b];
                                Player = 2;
                            }
                            else
                            {
                                FireFieldPT[c,b] = FireFieldTemp[c, b];
                                Player = 1;
                            }
                            b = 1;
                            c = 1;
                            FireFieldTemp = new string[12, 12];
                            FireFieldTemp[c, b] = " -";
                            RenderField(Player, BoatPos, true, b, c, Boat, Boattype, BoatsPO, BoatsPT, BoatsTemp, BoatFieldCh, FireField, FireFieldPO, FireFieldPT, FireFieldTemp, Field, FireFieldCh, Rotate);
                        }
                        else
                        {
                            RenderField(Player, BoatPos, true, b, c, Boat, Boattype, BoatsPO, BoatsPT, BoatsTemp, BoatFieldCh, FireField, FireFieldPO, FireFieldPT, FireFieldTemp, Field, FireFieldCh, Rotate);
                        }
                    }
                    
                }
            }
        }
        public static bool BoatFieldCheck(string[,] Boats, string[,] BoatsTemp)
        {
            bool check = false;
            for (int c = 0; c < Boats.GetLength(0)-2; c++)
            {
                for (int b = 0; b < BoatsTemp.GetLength(0)-2; b++)
                {
                    if (Boats[c,b] == " -" && BoatsTemp[c, b] == " -")
                    {
                        check = true;
                    }
                }
            }
            if (check)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool WinCheck(string[,] FireField,string[,] BoatPos)
        {
            int counter = 0;
            for (int c = 0; c < BoatPos.GetLength(0) - 2; c++)
            {
                for (int b = 0; b < FireField.GetLength(0) - 2; b++)
                {
                    if (BoatPos[c, b] == " -" && FireField[c, b] == " -")
                    {
                        counter += 1;
                    }
                }
            }
            if (counter == 15)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}