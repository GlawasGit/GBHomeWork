using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class Program
    {
        class Cross
        {
            static int SIZE_X = 5;
            static int SIZE_Y = 5;

            static char[,] field = new char[SIZE_Y, SIZE_X];

            static char PLAYER_DOT = 'X';
            static char AI_DOT = 'O';
            static char EMPTY_DOT = '.';

            static Random random = new Random();

            private static void InitField()
            {
                for (int i = 0; i < SIZE_Y; i++)
                {
                    for (int j = 0; j < SIZE_X; j++)
                    {
                        field[i, j] = EMPTY_DOT;
                    }
                }
            }

            private static void PrintField()
            {
                Console.Clear();
                Console.WriteLine("---------");
                for (int i = 0; i < SIZE_Y; i++)
                {
                    Console.Write("|");
                    for (int j = 0; j < SIZE_X; j++)
                    {
                        Console.Write(field[i, j] + "|");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("---------");
            }
            private static void SetSym(int y, int x, char sym)
            {
                field[y, x] = sym;
            }

            private static bool IsCellValid(int y, int x)
            {
                if (x < 0 || y < 0 || x > SIZE_X - 1 || y > SIZE_Y - 1)
                {
                    return false;
                }

                return field[y, x] == EMPTY_DOT;
            }

            private static void playerMove()
            {
                int x, y;
                do
                {
                    Console.WriteLine("Координат по строке ");
                    Console.WriteLine("Введите координаты вашего хода в диапозоне от 1 до " + SIZE_Y);
                    x = Int32.Parse(Console.ReadLine()) - 1;
                    Console.WriteLine("Координат по столбцу ");
                    Console.WriteLine("Введите координаты вашего хода в диапозоне от 1 до " + SIZE_X);
                    y = Int32.Parse(Console.ReadLine()) - 1;
                } while (!IsCellValid(y, x));
                SetSym(y, x, PLAYER_DOT);
            }

            private static void AiMove()
            {
                int x, y;
                do
                {
                    x = random.Next(0, SIZE_X);
                    y = random.Next(0, SIZE_Y);
                } while (!IsCellValid(y, x));
                SetSym(y, x, AI_DOT);
            }

            private static bool IsFieldFull()
            {
                for (int i = 0; i < SIZE_Y; i++)
                {
                    for (int j = 0; j < SIZE_X; j++)
                    {
                        if (field[i, j] == EMPTY_DOT)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }

            public static bool CheckWin(char sym)
            {
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    var a = 0;
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        var b = 0;
                        if (field[i, j] == sym || field[j, i] == sym)
                        {
                            a += 1;
                            b += 1;
                            if (a == 4 || b == 4)
                            {
                                return true;
                            }
                        }
                    }  
                }
                int mdig = 0; 
                int supdig = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (field[i, i] == sym)
                    {
                        mdig++;
                    }
                    if (field[i, 2 - i] == sym)
                    {
                        supdig++;
                    }
                }
                    if (mdig == 3 || supdig == 3)
                    {
                        return true;
                    }
                return false;
            }

            static void Main(string[] args)
            {
                InitField();
                PrintField();
                do
                {
                    playerMove();
                    Console.WriteLine("Ваш ход на поле");
                    PrintField();
                    if (CheckWin(PLAYER_DOT))
                    {
                        Console.WriteLine("Вы выиграли");
                        break;
                    }
                    else if (IsFieldFull()) break;
                    AiMove();
                    Console.WriteLine("Ход Компа на поле");
                    PrintField();
                    if (CheckWin(AI_DOT))
                    {
                        Console.WriteLine("Выиграли Комп");
                        break;
                    }
                    else if (IsFieldFull()) break;
                } while (true);
                Console.WriteLine("!Конец игры!");
            }

        }
    }
}
