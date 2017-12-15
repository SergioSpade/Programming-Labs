using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almost_Chess
{
    class Program
    {
        static int size = 8;
        static string[][] board;
        private static int column;
        private static int row;

        static void Main(string[] args)
        {
            CreateBoard();
            FillBoard();
            PrintBoard();
            System.Threading.Thread.Sleep(100000);
        }
        static void CreateBoard()
        {
            board = new string[size][];

            for (int i = 0; i < 8; i++)
            {
                board[i] = new string[size];
            }
        }
        static void FillBoard()
        {
            for (int i = 0; i < size; i++)
            {
                for (int k = 0; k < size; k++)
                {
                    board[i][k] = (i < 2 | i > 5) ? "X " : " ";
                }
                if (i <= 2 && i >= 5)
                {
                }

            }

        }
        static void PrintBoard()
        {
            for (int i = 0; i < size; i++)
            {
                for (int i; i < row; row++)
                {
                    for (int j; j < column; column++)
                    {
                    }
                    
                }


                System.Console.WriteLine();
                System.Console.Write("+---+---+---+---+---+---+");
                System.Console.Write(" |");
                for (int j = 0; j < size; j++)
                {
                    System.Console.Write(" " + board[i][j] + " |");
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine("+---+---+---+---+---+---+");
            }
        }
    }
