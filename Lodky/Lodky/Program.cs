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

            string[,] FireField = new string[12, 12];

            string[,] FireFieldPO = new string[12, 12];
            string[,] FireFieldPT = new string[12, 12];
            string[,] FireFieldTemp = new string[12, 12];

            int[] Boattypes = new int[] { 1, 2, 3, 4, 5 };
            Neco.RenderField(1, BoatPos, true, 1, 1, 0, Boattypes, BoatsPO, BoatsPT, BoatsTemp, false, FireField, FireFieldPO, FireFieldPT, FireFieldTemp,false,false);

        }
    }
    class Neco
    {
        public static void RenderField(int Player, string[,] BoatPos, bool check, int bB, int cB, int boat, int[] Boattypes, string[,] BoatsPO, string[,] BoatsPT, string[,] BoatsTemp, bool BoatFieldCh, string[,] FireField, string[,] FireFieldPO, string[,] FireFieldPT, string[,] FireFieldTemp, bool Field, bool FireFieldCh)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Field);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Player " + Player);
            Console.ResetColor();
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
                    if (Player == 1)
                    {
                        if (BoatPos[c, b] == BoatsTemp[c, b])
                        {
                            BoatPos[c, b] = " +";
                        }
                        if (BoatPos[c, b] == BoatsPO[c, b])
                        {
                            BoatPos[c, b] = " +";
                        }
                        if (BoatsPO[c, b] == " -" && BoatsTemp[c, b] == " -")
                        {
                            BoatPos[c, b] = " 0";
                        }

                    }
                    else
                    {
                        if (BoatPos[c, b] == BoatsTemp[c, b])
                        {
                            BoatPos[c, b] = " +";
                        }
                        if (BoatPos[c, b] == BoatsPT[c, b])
                        {
                            BoatPos[c, b] = " +";
                        }
                        if (BoatsPT[c, b] == " -" && BoatsTemp[c, b] == " -")
                        {
                            BoatPos[c, b] = " 0";
                        }

                    }

                    Console.Write(BoatPos[c, b]);
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
            Console.WriteLine();
            Console.WriteLine("     A B C D E F G H I J");
            for (int c = 0; c < FireField.GetLength(0); c++)
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
                for (int b = 0; b < FireField.GetLength(1); b++)
                {
                    if (c == 0 || c == FireField.GetLength(0) - 1)
                    {
                        FireField[c, b] = "x ";
                    }
                    if (b == 0 && c != 0 && c != FireField.GetLength(0) - 1)
                    {
                        FireField[c, b] = "x";
                    }
                    if (c != 0 && b != 0 && c != FireField.GetLength(0) - 1 && b != FireField.GetLength(1) - 1)
                    {
                        FireField[c, b] = " -";
                    }
                    else
                    {
                        FireField[c, b] = " x";
                    }
                    if (Player == 1)
                    {
                        if (FireField[c, b] == FireFieldTemp[c, b])
                        {
                            FireField[c, b] = " +";
                        }
                        if (FireField[c, b] == FireFieldPO[c, b])
                        {
                            FireField[c, b] = " +";
                        }
                        if (FireFieldPO[c, b] == " -" && FireFieldTemp[c, b] == " -")
                        {
                            FireField[c, b] = " 0";
                        }

                    }
                    else
                    {
                        if (FireField[c, b] == FireFieldTemp[c, b])
                        {
                            FireField[c, b] = " +";
                        }
                        if (FireField[c, b] == FireFieldPT[c, b])
                        {
                            FireField[c, b] = " +";
                        }
                        if (FireFieldPT[c, b] == " -" && FireFieldTemp[c, b] == " -")
                        {
                            FireField[c, b] = " 0";
                        }

                    }

                    Console.Write(FireField[c, b]);
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
            if(Player == 1)
            {
                check = WinCheck(FireFieldPO, BoatsPO);
            }
            else
            {
                check = WinCheck(FireFieldPT, BoatsPT);
            }
            if (check)
            {
                BoatField(Player, Boattypes, boat, bB, cB, BoatPos, BoatsPO, BoatsPT, BoatsTemp, FireField, FireFieldPO, FireFieldPT, FireFieldTemp,Field, FireFieldCh);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Zvítězil hráč " + Player);
                Console.ResetColor();
                Console.ReadKey();
            }

        }
        public static void BoatField(int Player, int[] Boattype, int Boat, int b, int c, string[,] BoatPos, string[,] BoatsPO, string[,] BoatsPT, string[,] BoatsTemp, string[,] FireField, string[,] FireFieldPO, string[,] FireFieldPT, string[,] FireFieldTemp,bool Field,bool FireFieldCh)
        {

            ConsoleKeyInfo name = Console.ReadKey();
            if (name.Key == ConsoleKey.DownArrow)
            {
                if (!Field)
                {
                    c += 1;
                    for (int i = 0; i < Boattype[Boat]; i++)
                    {
                        if (c > 10)
                        {
                            c = 10;
                        }
                        if (b > 10)
                        {
                            b = 10;
                        }
                        BoatsTemp[c - 1, b + i] = " ";
                        BoatsTemp[c, b + i] = " -";

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
                        if (b > 10)
                        {
                            b = 10;
                        }
                        FireFieldTemp[c - 1, b + i] = " ";
                        FireFieldTemp[c, b + i] = " -";

                    }
                }
                RenderField(Player, BoatPos, true, b, c, Boat, Boattype, BoatsPO, BoatsPT, BoatsTemp, false, FireField, FireFieldPO, FireFieldPT, FireFieldTemp,Field, FireFieldCh);

            }
            if (name.Key == ConsoleKey.UpArrow)
            {
                if (!Field)
                {
                    c -= 1;
                    for (int i = 0; i < Boattype[Boat]; i++)
                    {
                        if (c == 0)
                        {
                            c = 1;
                        }
                        BoatsTemp[c + 1, b + i] = " ";
                        BoatsTemp[c, b + i] = " -";

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
                RenderField(Player, BoatPos, true, b, c, Boat, Boattype, BoatsPO, BoatsPT, BoatsTemp, false, FireField, FireFieldPO, FireFieldPT, FireFieldTemp, Field, FireFieldCh);
            }
            if (name.Key == ConsoleKey.RightArrow)
            {
                if (!Field)
                {
                    b += Boattype[Boat];
                    if (b >= 10)
                    {
                        b = 10;
                    }
                    BoatsTemp[c, b - Boattype[Boat]] = " ";
                    BoatsTemp[c, b] = " -";
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
               
                RenderField(Player, BoatPos, true, b, c, Boat, Boattype, BoatsPO, BoatsPT, BoatsTemp, false, FireField, FireFieldPO, FireFieldPT, FireFieldTemp, Field, FireFieldCh);
            }
            if (name.Key == ConsoleKey.LeftArrow)
            {
                if (!Field)
                {
                    b -= Boattype[Boat];
                    if (b <= 1)
                    {
                        b = 1;
                    }
                    BoatsTemp[c, b + Boattype[Boat]] = " ";
                    BoatsTemp[c, b] = " -";
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
               
                RenderField(Player, BoatPos, true, b, c, Boat, Boattype, BoatsPO, BoatsPT, BoatsTemp, false, FireField, FireFieldPO, FireFieldPT, FireFieldTemp, Field, FireFieldCh);
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
                        if (Boat <= 5)
                        {
                            if (Player == 1)
                            {

                                for (int i = 0; i < Boattype[Boat]; i++)
                                {
                                    if (b + i > 10)
                                    {
                                        b -= Boattype[Boat];
                                    }
                                    BoatsPO[c, b + i] = " -";
                                }
                            }
                            else
                            {
                                for (int i = 0; i < Boattype[Boat]; i++)
                                {
                                    BoatsPT[c, b + i] = " -";
                                }
                            }
                        }

                        Boat += 1;

                        if (Boat >= 5)
                        {
                            if(Player == 1)
                            {
                                Player = 2;
                                Boat = 0;
                            }
                            else
                            {
                                Player = 1;
                                Field = true;
                            }
                        }

                        b = 1;
                        c = 1;
                        BoatsTemp = new string[12, 12];
                        RenderField(Player, BoatPos, true, b, c, Boat, Boattype, BoatsPO, BoatsPT, BoatsTemp, BoatFieldCh, FireField, FireFieldPO, FireFieldPT, FireFieldTemp, Field, FireFieldCh);
                    }
                    else
                    {
                        RenderField(Player, BoatPos, true, b, c, Boat, Boattype, BoatsPO, BoatsPT, BoatsTemp, BoatFieldCh, FireField, FireFieldPO, FireFieldPT, FireFieldTemp, Field, FireFieldCh);
                    }
                }
                else
                {
                    //RenderField(Player, BoatPos, true, b, c, Boat, Boattype, BoatsPO, BoatsPT, BoatsTemp, BoatFieldCh, FireField, FireFieldPO, FireFieldPT, FireFieldTemp, Field, FireFieldCh);
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

                            RenderField(Player, BoatPos, true, b, c, Boat, Boattype, BoatsPO, BoatsPT, BoatsTemp, BoatFieldCh, FireField, FireFieldPO, FireFieldPT, FireFieldTemp, Field, FireFieldCh);
                        }
                        else
                        {
                            RenderField(Player, BoatPos, true, b, c, Boat, Boattype, BoatsPO, BoatsPT, BoatsTemp, BoatFieldCh, FireField, FireFieldPO, FireFieldPT, FireFieldTemp, Field, FireFieldCh);
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