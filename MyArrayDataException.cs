using System;
using System.Runtime.Serialization;

namespace ConsoleApp8
{
    [Serializable]
    internal class MyArrayDataException : Exception
    {
        int row, column;

        public MyArrayDataException(int row, int column)
        {
            this.row = row;
            this.column = column;
        }
    }
}