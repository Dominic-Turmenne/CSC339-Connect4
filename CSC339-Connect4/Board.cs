using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC339_Connect4
{
    enum Player
    {
        EMPTY, RED, YELLOW
    }
    class Board
    {
        private const int rows = 6;
        private const int cols = 7;
        private Player[,] board = new Player[rows, cols];
        private Player currentPlayer;
        private string playerOne;
        private string playerTwo;
        public string winningPlayer;
        public bool gameStarted = false;
        public bool win = false;

        public Board()
        {
            //constructor
            ResetBoard();
        }

        public void ResetBoard()
        {
            win = false;
            currentPlayer = Player.RED;

            //reset the game board to empty
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    board[i, j] = Player.EMPTY;
                }
            }

        }

        public void SetPlayerNames(string playerOne, string playerTwo)
        {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
        }

        // Returns current player's name
        public string GetPlayerName()
        {
            if (currentPlayer == Player.RED)
            {
                return playerOne;
            }
            else
            {
                return playerTwo;
            }
        }

        // Switches current player
        public void NextTurn()
        {
            if (currentPlayer == Player.RED)
            {
                currentPlayer = Player.YELLOW;
            }
            else
            {
                currentPlayer = Player.RED;
            }
        }

        public bool AddPiece(int column)
        {
            bool success = false;
            if(!ColumnFull(column))
            {
                // Check for empty spaces
                for (int i = rows - 1; i >= 0; i--)
                {
                    if (board[i, column] == Player.EMPTY)
                    {
                        // Place piece in empty space
                        board[i, column] = currentPlayer;
                        success = true;
                        break;
                    }
                }
            } 
            return success;
        }

        private bool ColumnFull(int column)
        {
            if (board[0, column] != Player.EMPTY)
            {
                return true;
            }
            else
                return false;
        }

        public bool CheckTie()
        {
            for (int i = 0; i < cols; i++)
            {
                if (!ColumnFull(i))
                    return false;
            }

            return true;
        }

        public bool CheckWin()
        {
            if (CheckHorizontalWin() || CheckVerticalWin() || CheckUpDiagonalWin() || CheckDownDiagonalWin())
            {
                win = true;
                if (currentPlayer == Player.RED)
                    winningPlayer = playerOne;
                else
                    winningPlayer = playerTwo;
            }

            return win;
        }

        public bool CheckHorizontalWin()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols - 3; j++)
                {
                    if (board[i, j] == currentPlayer && board[i, j + 1] == currentPlayer && board[i, j + 2] == currentPlayer && board[i, j + 3] == currentPlayer)
                        return true;
                }
            }
            return false;
        }

        public bool CheckVerticalWin()
        {
            for (int i = 0; i < rows - 3; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (board[i, j] == currentPlayer && board[i + 1, j] == currentPlayer && board[i + 2,j] == currentPlayer && board[i + 3, j] == currentPlayer)
                        return true;
                }
            }
            return false;
        }

        public bool CheckUpDiagonalWin()
        {
            for (int i = 3; i < rows; i++)
            {
                for (int j = 0; j < cols - 3; j++)
                {
                    if (board[i, j] == currentPlayer && board[i - 1, j + 1] == currentPlayer && board[i - 2, j + 2] == currentPlayer && board[i - 3, j + 3] == currentPlayer)
                        return true;
                }
            }
            return false;
        }

        public bool CheckDownDiagonalWin()
        {
            for (int i = 0; i < rows - 3; i++)
            {
                for (int j = 0; j < cols - 3; j++)
                {
                    //Console.WriteLine("( " + i + ", " + j + " )" + "( " + (i + 1) + ", " + (j + 1) + " )" + "( " + (i + 2) + ", " + (j + 2) + " )" + "( " + (i + 3) + ", " + (j + 3) + " )");
                    if (board[i, j] == currentPlayer && board[i + 1, j + 1] == currentPlayer && board[i + 2, j + 2] == currentPlayer && board[i + 3, j + 3] == currentPlayer)
                        return true;
                }
            }
            return false;
        }

        public void DrawBoard(Graphics g)
        {
            int start = 50; //board top left corner offset

            g.FillRectangle(Brushes.Navy, start, start, 700, 600);

            //draw the board columns
            for (int i = 100; i <= 600; i = i + 100)
                g.DrawLine(Pens.White, start + i, start, start + i, start + 600);

            //draw the board rows
            for (int i = 100; i <= 500; i = i + 100)
                g.DrawLine(Pens.White, start, start + i, start + 700, start + i);


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (board[i, j] == Player.RED)
                    {
                        g.FillEllipse(Brushes.Red, (start + 5) + (j * 100), (start + 5) + (i * 100), 90, 90);
                    }
                    else if (board[i, j] == Player.YELLOW)
                    {
                        g.FillEllipse(Brushes.Yellow, (start + 5) + (j * 100), (start + 5) + (i * 100), 90, 90);
                    }
                    else
                    {
                        g.FillEllipse(Brushes.White, (start + 5) + (j * 100), (start + 5) + (i * 100), 90, 90);
                    }
                }
            }
        }
    }
}