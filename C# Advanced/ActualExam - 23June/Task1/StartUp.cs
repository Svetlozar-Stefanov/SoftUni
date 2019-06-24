namespace Task3
{
    using System;
    public class StartUp
    {
        struct Object
        {
            public int Row { get; set; }
            public int Col { get; set; }

        }

        static Object Spaceship;
        static Object FirstBlackHole;
        static Object SecondBlackHole;
        static char[,] theVastSpace;
        static bool isDead;
        static int StarPowder = 0;
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            theVastSpace = new char[n, n];

            int holeCount = 0;
            for (int row = 0; row < theVastSpace.GetLength(0); row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < theVastSpace.GetLength(1); col++)
                {
                    theVastSpace[row, col] = input[col];
                    if (theVastSpace[row,col] == 'S')
                    {
                        theVastSpace[row, col] = '-';
                        Spaceship.Row = row;
                        Spaceship.Col = col;
                    }
                    else if (holeCount == 0 && theVastSpace[row,col] == 'O')
                    {
                        FirstBlackHole.Row = row;
                        FirstBlackHole.Col = col;
                        holeCount++;
                    }
                    else if (holeCount > 0 && theVastSpace[row, col] == 'O')
                    {
                        SecondBlackHole.Row = row;
                        SecondBlackHole.Col = col;
                        holeCount++;
                    }
                }
            }

            isDead = false;
            while (true)
            {
                string command = Console.ReadLine();

                MovePlayer(command);
                if (isDead)
                {
                    break;
                }

                string currentPosition = theVastSpace[Spaceship.Row, Spaceship.Col].ToString();
                if (int.TryParse(currentPosition, out int stardust))
                {
                    StarPowder += stardust;
                    theVastSpace[Spaceship.Row, Spaceship.Col] = '-';
                }

                if (StarPowder >= 50)
                {
                    break;
                }

                if (currentPosition == "O")
                {
                    if (Spaceship.Row == FirstBlackHole.Row && Spaceship.Col == FirstBlackHole.Col)
                    {
                        theVastSpace[Spaceship.Row, Spaceship.Col] = '-';

                        Spaceship.Row = SecondBlackHole.Row;
                        Spaceship.Col = SecondBlackHole.Col;

                        theVastSpace[Spaceship.Row, Spaceship.Col] = '-';
                    }
                    else if (Spaceship.Row == SecondBlackHole.Row && Spaceship.Col == SecondBlackHole.Col)
                    {
                        theVastSpace[Spaceship.Row, Spaceship.Col] = '-';

                        Spaceship.Row = FirstBlackHole.Row;
                        Spaceship.Col = FirstBlackHole.Col;

                        theVastSpace[Spaceship.Row, Spaceship.Col] = '-';
                    }
                }
            }

            if (isDead)
            {
                Console.WriteLine($"Bad news, the spaceship went to the void.");
            }
            else if (StarPowder >= 50)
            {
                theVastSpace[Spaceship.Row, Spaceship.Col] = 'S';
                Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
            }

            Console.WriteLine($"Star power collected: {StarPowder}");
            PrintMatrix();
        }

        private static void PrintMatrix()
        {
            for (int row = 0; row < theVastSpace.GetLength(0); row++)
            {
                for (int col = 0; col < theVastSpace.GetLength(1); col++)
                {
                    Console.Write(theVastSpace[row,col]);
                }
                Console.WriteLine();
            }
        }

        private static void MovePlayer(string command)
        {
            if (command == "up")
            {
                if (Spaceship.Row - 1 >= 0)
                {
                    Spaceship.Row--;
                }
                else
                {
                    isDead = true;
                }
            }
            if (command == "down")
            {
                if (Spaceship.Row + 1 < theVastSpace.GetLength(0))
                {
                    Spaceship.Row++;
                }
                else
                {
                    isDead = true;
                }
            }
            if (command == "left")
            {
                if (Spaceship.Col - 1 >= 0)
                {
                    Spaceship.Col--;
                }
                else
                {
                    isDead = true;
                }
            }
            if (command == "right")
            {
                if (Spaceship.Col + 1 < theVastSpace.GetLength(1))
                {
                    Spaceship.Col++;
                }
                else
                {
                    isDead = true;
                }
            }
        }
    }
}
