using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Soru
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] chessBoard = new int[8, 8];
            int count = 0;
            int[,] locateKnight(int a, int b)
            {
                for (int i = a; i < 8; i += 2)
                {
                    for (int j = b; j < 8; j += 2)
                    {
                        chessBoard[i, j] = 1;
                        if (i == 0)
                        {
                            if (j == 0)
                            {
                                chessBoard[i + 2, j + 1] = 0; chessBoard[i + 1, j + 2] = 0;

                            }
                            else if (j == 1)
                            {
                                chessBoard[i + 2, j + 1] = 0; chessBoard[i + 1, j + 2] = 0;

                            }
                            else if (j == 6)
                            {
                                chessBoard[i + 2, j + 1] = 0; chessBoard[i + 2, j - 1] = 0; chessBoard[i + 1, j - 2] = 0;

                            }
                            else if (j == 7)
                            {
                                chessBoard[i + 2, j - 1] = 0; chessBoard[i + 1, j - 2] = 0;

                            }
                            else
                            {
                                chessBoard[i + 2, j + 1] = 0; chessBoard[i + 2, j - 1] = 0; chessBoard[i + 1, j - 2] = 0; chessBoard[i + 1, j + 2] = 0;


                            }

                        }
                        else if (i == 1)
                        {
                            if (j == 0)
                            {
                                chessBoard[i + 2, j + 1] = 0; chessBoard[i + 2, j - 1] = 0; chessBoard[i + 1, j + 2] = 0;

                            }
                            else if (j == 1)
                            {
                                chessBoard[i + 2, j + 1] = 0; chessBoard[i + 2, j - 1] = 0; chessBoard[i + 1, j + 2] = 0;

                            }
                            else if (j == 6)
                            {
                                chessBoard[i + 2, j + 1] = 0; chessBoard[i + 2, j - 1] = 0; chessBoard[i + 1, j - 2] = 0;

                            }
                            else if (j == 7)
                            {
                                chessBoard[i + 2, j - 1] = 0; chessBoard[i + 1, j - 2] = 0; chessBoard[i - 1, j - 2] = 0;

                            }
                            else
                            {
                                chessBoard[i + 2, j + 1] = 0; chessBoard[i + 2, j - 1] = 0; chessBoard[i + 1, j - 2] = 0; chessBoard[i + 1, j + 2] = 0; chessBoard[i - 1, j - 2] = 0; chessBoard[i - 1, j + 2] = 0;


                            }

                        }
                        else if (i == 6)
                        {
                            if (j == 0)
                            {
                                chessBoard[i + 1, j + 2] = 0; chessBoard[i - 1, j + 2] = 0; chessBoard[i - 2, j + 1] = 0;

                            }
                            else if (j == 1)
                            {
                                chessBoard[i + 1, j + 2] = 0; chessBoard[i - 1, j + 2] = 0; chessBoard[i - 2, j + 1] = 0; chessBoard[i - 2, j - 1] = 0;

                            }
                            else if (j == 6)
                            {
                                chessBoard[i - 2, j + 1] = 0; chessBoard[i - 2, j - 1] = 0; chessBoard[i + 1, j - 2] = 0; chessBoard[i - 1, j - 2] = 0;

                            }
                            else if (j == 7)
                            {
                                chessBoard[i - 2, j - 1] = 0; chessBoard[i + 1, j - 2] = 0; chessBoard[i - 1, j - 2] = 0;

                            }
                            else
                            {
                                chessBoard[i + 1, j + 2] = 0; chessBoard[i + 1, j - 2] = 0; chessBoard[i - 1, j - 2] = 0; chessBoard[i - 1, j + 2] = 0; chessBoard[i - 2, j - 1] = 0; chessBoard[i - 2, j + 1] = 0;


                            }


                        }
                        else if (i == 7)
                        {
                            if (j == 0)
                            {
                                chessBoard[i - 2, j + 1] = 0; chessBoard[i - 1, j + 2] = 0;

                            }
                            else if (j == 1)
                            {
                                chessBoard[i - 2, j + 1] = 0; chessBoard[i - 2, j - 1] = 0; chessBoard[i - 1, j + 2] = 0;

                            }
                            else if (j == 6)
                            {
                                chessBoard[i - 2, j + 1] = 0; chessBoard[i - 2, j - 1] = 0; chessBoard[i - 1, j - 2] = 0;

                            }
                            else if (j == 7)
                            {
                                chessBoard[i - 2, j - 1] = 0; chessBoard[i - 1, j - 2] = 0;

                            }
                            else
                            {
                                chessBoard[i - 1, j + 2] = 0; chessBoard[i - 1, j - 2] = 0; chessBoard[i - 2, j - 1] = 0; chessBoard[i - 2, j + 1] = 0;


                            }

                        }
                        else
                        {
                            if (j == 0)
                            {
                                chessBoard[i - 2, j + 1] = 0; chessBoard[i - 1, j + 2] = 0; chessBoard[i + 1, j + 2] = 0; chessBoard[i + 2, j + 1] = 0;

                            }
                            else if (j == 1)
                            {
                                chessBoard[i - 2, j + 1] = 0; chessBoard[i - 2, j - 1] = 0; chessBoard[i - 1, j + 2] = 0; chessBoard[i + 1, j + 2] = 0; chessBoard[i + 2, j + 1] = 0; chessBoard[i + 2, j - 1] = 0;

                            }
                            else if (j == 6)
                            {
                                chessBoard[i - 2, j + 1] = 0; chessBoard[i - 2, j - 1] = 0; chessBoard[i - 1, j - 2] = 0; chessBoard[i + 1, j - 2] = 0; chessBoard[i + 2, j - 1] = 0; chessBoard[i + 2, j + 1] = 0;

                            }
                            else if (j == 7)
                            {
                                chessBoard[i - 2, j - 1] = 0; chessBoard[i + 2, j - 1] = 0; chessBoard[i - 1, j - 2] = 0; chessBoard[i + 1, j - 2] = 0;

                            }
                            else
                            {
                                chessBoard[i - 1, j + 2] = 0; chessBoard[i - 1, j - 2] = 0; chessBoard[i - 2, j - 1] = 0; chessBoard[i - 2, j + 1] = 0; chessBoard[i + 2, j + 1] = 0; chessBoard[i + 2, j - 1] = 0; chessBoard[i + 1, j - 2] = 0; chessBoard[i + 1, j + 2] = 0;


                            }

                        }

                    }
                }
                return chessBoard;
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    chessBoard[i, j] = -1;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == 0)
                    {
                        if (j == 0)
                        {
                            if (chessBoard[i + 2, j + 1] != 1 && chessBoard[i + 1, j + 2] != 1)
                            {
                                locateKnight(i, j);
                            }
                        }
                        else if (j == 1)
                        {
                            if (chessBoard[i + 2, j + 1] != 1 && chessBoard[i + 1, j + 2] != 1 && chessBoard[i, j] != 1)
                            {
                                locateKnight(i, j);
                            }
                        }
                        else if (j == 6)
                        {
                            if (chessBoard[i + 2, j + 1] != 1 && chessBoard[i, j] != 1 && chessBoard[i + 2, j - 1] != 1 && chessBoard[i + 1, j - 2] != 1)
                            {
                                locateKnight(i, j);
                            }
                        }
                        else if (j == 7)
                        {
                            if (chessBoard[i + 2, j - 1] != 1 && chessBoard[i + 1, j - 2] != 1 && chessBoard[i, j] != 1)
                            {
                                locateKnight(i, j);
                            }
                        }
                        else
                        {
                            if (chessBoard[i + 2, j + 1] != 1 && chessBoard[i, j] != 1 && chessBoard[i + 2, j - 1] != 1 && chessBoard[i + 1, j - 2] != 1 && chessBoard[i + 1, j + 2] != 1)
                            {
                                locateKnight(i, j);
                            }

                        }

                    }
                    else if (i == 1)
                    {
                        if (j == 0)
                        {
                            if (chessBoard[i + 2, j + 1] != 1 && chessBoard[i, j] != 1 &&  chessBoard[i + 1, j + 2] != 1)
                            {
                                locateKnight(i, j);
                            }
                        }
                        else if (j == 1)
                        {
                            if (chessBoard[i + 2, j + 1] != 1 && chessBoard[i, j] != 1 && chessBoard[i + 2, j - 1] != 1 && chessBoard[i + 1, j + 2] != 1)
                            {
                                locateKnight(i, j);
                            }
                        }
                        else if (j == 6)
                        {
                            if (chessBoard[i + 2, j + 1] != 1 && chessBoard[i, j] != 1 && chessBoard[i + 2, j - 1] != 1 && chessBoard[i + 1, j - 2] != 1)
                            {
                                locateKnight(i, j);
                            }
                        }
                        else if (j == 7)
                        {
                            if (chessBoard[i + 2, j - 1] != 1 && chessBoard[i, j] != 1 && chessBoard[i + 1, j - 2] != 1 && chessBoard[i - 1, j - 2] != 1)
                            {
                                locateKnight(i, j);
                            }
                        }
                        else
                        {
                            if (chessBoard[i + 2, j + 1] != 1 && chessBoard[i, j] != 1 && chessBoard[i + 2, j - 1] != 1 && chessBoard[i + 1, j - 2] != 1 && chessBoard[i + 1, j + 2] != 1 && chessBoard[i - 1, j - 2] != 1 && chessBoard[i - 1, j + 2] != 1)
                            {
                                locateKnight(i, j);
                            }

                        }

                    }
                    else if (i == 6)
                    {
                        if (j == 0)
                        {
                            if (chessBoard[i + 1, j + 2] != 1 && chessBoard[i, j] != 1 && chessBoard[i - 1, j + 2] != 1 && chessBoard[i - 2, j + 1] != 1)
                            {
                                locateKnight(i, j);
                            }
                        }
                        else if (j == 1)
                        {
                            if (chessBoard[i + 1, j + 2] != 1 && chessBoard[i, j] != 1 && chessBoard[i - 1, j + 2] != 1 && chessBoard[i - 2, j + 1] != 1 && chessBoard[i - 2, j - 1] != 1)
                            {
                                locateKnight(i, j);
                            }
                        }
                        else if (j == 6)
                        {
                            if (chessBoard[i - 2, j + 1] != 1 && chessBoard[i, j] != 1 && chessBoard[i - 2, j - 1] != 1 && chessBoard[i + 1, j - 2] != 1 && chessBoard[i - 1, j - 2] != 1)
                            {
                                locateKnight(i, j);
                            }
                        }
                        else if (j == 7)
                        {
                            if (chessBoard[i - 2, j - 1] != 1 && chessBoard[i, j] != 1 && chessBoard[i + 1, j - 2] != 1 && chessBoard[i - 1, j - 2] != 1)
                            {
                                locateKnight(i, j);
                            }
                        }
                        else
                        {
                            if (chessBoard[i + 1, j + 2] != 1 && chessBoard[i, j] != 1 && chessBoard[i + 1, j - 2] != 1 && chessBoard[i - 1, j - 2] != 1 && chessBoard[i - 1, j + 2] != 1 && chessBoard[i - 2, j - 1] != 1 && chessBoard[i - 2, j + 1] != 1)
                            {
                                locateKnight(i, j);
                            }

                        }


                    }
                    else if (i == 7)
                    {
                        if (j == 0)
                        {
                            if (chessBoard[i - 2, j + 1] != 1 && chessBoard[i, j] != 1 && chessBoard[i - 1, j + 2] != 1)
                            {
                                locateKnight(i, j);
                            }
                        }
                        else if (j == 1)
                        {
                            if (chessBoard[i - 2, j + 1] != 1 && chessBoard[i, j] != 1 && chessBoard[i - 2, j - 1] != 1 && chessBoard[i - 1, j + 2] != 1)
                            {
                                locateKnight(i, j);
                            }
                        }
                        else if (j == 6)
                        {
                            if (chessBoard[i - 2, j + 1] != 1 && chessBoard[i, j] != 1 && chessBoard[i - 2, j - 1] != 1 && chessBoard[i - 1, j - 2] != 1)
                            {
                                locateKnight(i, j);
                            }
                        }
                        else if (j == 7)
                        {
                            if (chessBoard[i - 2, j - 1] != 1 && chessBoard[i, j] != 1 && chessBoard[i - 1, j - 2] != 1)
                            {
                                locateKnight(i, j);
                            }
                        }
                        else
                        {
                            if (chessBoard[i - 1, j + 2] != 1 && chessBoard[i, j] != 1 && chessBoard[i - 1, j - 2] != 1 && chessBoard[i - 2, j - 1] != 1 && chessBoard[i - 2, j + 1] != 1)
                            {
                                locateKnight(i, j);
                            }

                        }

                    }
                    else
                    {
                        if (j == 0)
                        {
                            if (chessBoard[i - 2, j + 1] != 1 && chessBoard[i, j] != 1 && chessBoard[i - 1, j + 2] != 1 && chessBoard[i + 1, j + 2] != 1 && chessBoard[i + 2, j + 1] != 1)
                            {
                                locateKnight(i, j);
                            }
                        }
                        else if (j == 1)
                        {
                            if (chessBoard[i - 2, j + 1] != 1 && chessBoard[i, j] != 1 && chessBoard[i - 2, j - 1] != 1 && chessBoard[i - 1, j + 2] != 1 && chessBoard[i + 1, j + 2] != 1 && chessBoard[i + 2, j + 1] != 1 && chessBoard[i + 2, j - 1] != 1)
                            {
                                locateKnight(i, j);
                            }
                        }
                        else if (j == 6)
                        {
                            if (chessBoard[i - 2, j + 1] != 1 && chessBoard[i, j] != 1 && chessBoard[i - 2, j - 1] != 1 && chessBoard[i - 1, j - 2] != 1 && chessBoard[i + 1, j - 2] != 1 && chessBoard[i + 2, j - 1] != 1 && chessBoard[i + 2, j + 1] != 1)
                            {
                                locateKnight(i, j);
                            }
                        }
                        else if (j == 7)
                        {
                            if (chessBoard[i - 2, j - 1] != 1 && chessBoard[i, j] != 1 && chessBoard[i + 2, j - 1] != 1 && chessBoard[i - 1, j - 2] != 1 && chessBoard[i + 1, j - 2] != 1)
                            {
                                locateKnight(i, j);
                            }
                        }
                        else
                        {
                            if (chessBoard[i - 1, j + 2] != 1 && chessBoard[i, j] != 1 && chessBoard[i - 1, j - 2] != 1 && chessBoard[i - 2, j - 1] != 1 && chessBoard[i - 2, j + 1] != 1 && chessBoard[i + 2, j + 1] != 1 && chessBoard[i + 2, j - 1] != 1 && chessBoard[i + 1, j - 2] != 1 && chessBoard[i + 1, j + 2] != 1)
                            {
                                locateKnight(i, j);
                            }

                        }

                    }
                }
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (chessBoard[i, j] == 1)
                    {
                        count += 1;
                        Console.Write("AT"+count + "\t");
                    }
                    else
                    {
                        Console.Write("0 \t");
                    }

                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
