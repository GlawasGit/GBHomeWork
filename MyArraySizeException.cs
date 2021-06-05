using System;
using System.Runtime.Serialization;

namespace ConsoleApp8
{
    [Serializable]
    internal class MyArraySizeException : Exception
    {
        public MyArraySizeException()
        {
        }
    }
}