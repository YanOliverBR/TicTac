using System;

namespace Tic_Tac_Toe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char player = 'X';
            int Movements = 0;
            char[,] Board = new char[3, 3];
            bool Rounds = false;
        
            
            while (Rounds == false)
            {

                Console.Clear();

                Table(Board);

                Console.WriteLine();

                Console.WriteLine("Insert Line :");
                int Linha = int.Parse(Console.ReadLine());

                Console.WriteLine("Insert Column :");
                int Coluna = int.Parse(Console.ReadLine());

                Board[Linha, Coluna] = player;

                if (player == Board [0, 0] && player == Board[0, 1] && player == Board[0, 2])     // Lines
                {
                    Console.WriteLine(player + " Winner !!");
                    break;
                }

                if (player == Board [1, 0] && player == Board [1, 1] && player == Board [1, 2])     // Lines
                {
                    Console.WriteLine(player + " Winner !!");
                    break;
                }

                if (player == Board [2, 0] && player == Board [2, 1] && player == Board [2, 2])     // Lines
                {
                    Console.WriteLine(player + " Winner !!");
                    break;
                }

                if (player == Board [0, 0] && player == Board [1, 0] && player == Board [2, 0])     // Columns
                {
                    Console.WriteLine(player + " Winner !!");
                    break;
                }

                if (player == Board [0, 1] && player == Board [1, 1] && player == Board [2, 1])     // Columns
                {
                    Console.WriteLine(player + " Winner !!");
                    break;
                }

                if (player == Board [0, 2] && player == Board [1, 2] && player == Board [2, 2])     // Columns
                {
                    Console.WriteLine(player + " Winner !!");
                    break;
                }

                if (player == Board [0, 0] && player == Board [1, 1] && player == Board [2, 2])     // Diagonals
                {
                    Console.WriteLine(player + " Winner !!");
                    break;
                }

                if (player == Board [0, 2] && player == Board [1, 1] && player == Board [2, 0])     // Diagonals
                {
                    Console.WriteLine(player + " Winner !!");
                    break;
                }

                Movements = Movements++;

                if (Movements == 9)
                {
                    Rounds = true;
                    Console.WriteLine("TIED GAME...");
                    break;   
                }


                player = Jogadas(player);

            }



        } 

       
        public static void Table (char[,] arr)
        {


            Console.WriteLine("    0     1    2   ");
            Console.WriteLine($"{" 0 "} {arr[0, 0]}   |  {arr[0, 1]}  | {arr[0, 2]} ");
            Console.Write("   ______________");
            Console.WriteLine();
            Console.WriteLine($"{" 1 "} {arr[1, 0]}   |  {arr[1, 1]}  | {arr[1, 2]} ");
            Console.Write("   ______________");
            Console.WriteLine();
            Console.WriteLine($"{" 2 "} {arr[2, 0]}   |  {arr[2, 1]}  | {arr[2, 2]} ");


        }


        public static char Jogadas (char player)
        {

            if (player == 'X')
            {
                return 'O';
            }

            else
            {
                return 'X';
            }

        }

    }


}