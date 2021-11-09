using System;
using System.Collections.Generic;
using System.Threading;

namespace TetrissGame
{
    class Program
    {

        static int TetrisRow = 20;
        static int TetrisCol = 10;

        static int InfoCol = 10;
        // State
        static int Score = 0;
        static int Frame = 0;
        static int FramesToMoveFigure = 15;
        static bool[,] TetrisField = new bool[TetrisRow, TetrisCol];
        static List<bool[,]> ListOFFigures = new List<bool[,]>()
        {
            new bool[ , ] { { true, true, true, true } }, // I
            new bool[ , ] 
            { 
              { false, true, false}, // T
              { true, true, true}           
            },
            new bool [ , ] {                    // Z
                            { true, true, false },
                            {false, true, true }
                            },

            new bool [ , ] {                    // S
                             {false, true, true },
                             { true, true, false},
            
                           },

            new bool [ , ] {    {false, false, true },            // L
                                {true, true, true, },
                            },

            new bool [ , ] { { true, false, false,},            // J
                             {true, true, true }            
                            }
        };
        static int CurrentFigureRow = 0;
        static int CurrentFigureCol = 0;
        static int CurrentFigureIndex = new Random().Next(5);
        static void Main(string[] args)
        {
            // Settings
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "Tetris_v1.0";
            Console.SetWindowSize(1 + TetrisCol + 1 + InfoCol + 1, 1 + TetrisRow + 1);
            Console.SetBufferSize(1 + TetrisCol + 1 + InfoCol + 1, 1 + TetrisRow + 1);
            Console.CursorVisible = false;
            DrawBorder();
            while (true)
            {
                    Frame++;
               

                if (Console.KeyAvailable)
                {

                    var key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        return ;
                    }
                    if (key.Key == ConsoleKey.Spacebar || key.Key == ConsoleKey.W || key.Key == ConsoleKey.UpArrow)
                    {
                        // TODO rotate
                    }
                    if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.A)
                    {
                        CurrentFigureCol--;
                    }
                    if (key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.D)
                    {
                        CurrentFigureCol++;
                    }
                    if (key.Key == ConsoleKey.S || key.Key == ConsoleKey.DownArrow)
                    {
                        Score++;
                        CurrentFigureRow++;
                        Frame = 1;
                    }
                }
                // Update the game state
                DrawFigure();

                if (Frame % FramesToMoveFigure == 0)
                {
                    CurrentFigureRow++;
                    
                    Frame = 0;
                }
                /* TODO: Check for Collision {}
                 
                

                    
                 */
                // Redraw UI
            Thread.Sleep(40);  // 24 FPS             

            DrawInfo();
            DrawBorder();
            }

            

        }

        static void DrawBorder() 
        {

            DrawElement(0, 0, "┏");

            for (int cols = 1; cols <= TetrisCol; cols++)
            {
                DrawElement(0, cols, "━");
            }
            Console.Write('┳');
            for (int cols = TetrisCol + 2; cols < 1 + TetrisCol + 1 + InfoCol; cols++)
            {
                DrawElement(0, cols, "━");
            }

            Console.Write('┓');
            for (int row = 1; row <= TetrisRow; row++)
            {
                Console.Write('┃');
                for (int col = 1; col < TetrisCol + 1; col++)
                {
                    DrawElement(row, col, " ");
                }
                DrawElement(row, TetrisCol + 1 , "┃");
                DrawElement(row, InfoCol + TetrisCol + 2, "┃");
            }

            Console.Write('┖');
            for (int col = 1; col <= TetrisCol; col++)
            {
                DrawElement(TetrisRow + 1, col, "━");
            }
            Console.Write('┻');
            for (int col = TetrisCol + 2; col <= TetrisCol + InfoCol + 1; col++)
            {
                DrawElement(TetrisRow + 1, col, "━");
            }
            Console.Write('┛');

        }            // DRAWING BORDER

        static void DrawInfo()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            DrawElement(1, 3 + TetrisCol, "Score:");
            DrawElement(2, TetrisCol + 3, Score.ToString());

            DrawElement(3, TetrisCol + 3, "Frame:");
            DrawElement(4, TetrisCol + 3, Frame.ToString());
        }               // DRAW INFO

        static void DrawFigure()
        {
            var currentFig = ListOFFigures[CurrentFigureIndex];

            for (int row = 0; row < currentFig.GetLength(0) ; row++)
            {
                for (int col = 0 ; col < currentFig.GetLength(1); col++)
                {
                    if (currentFig[row, col])
                    {
                        DrawElement(row + 1 + CurrentFigureRow, col + 1 + CurrentFigureCol, "*");
                    }
                }

            }
        
        }
        static void DrawElement(int row, int col, string element)
        {
            Console.SetCursorPosition(col, row);
            Console.Write(element);
        
        }   
    }
}
