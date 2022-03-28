using System;

namespace XMLCommentDemo
{
    /// <summary>
    /// MainClass is a simple illustrating how to use XML
    /// documentation in C#
    /// </summary>
    class MainClass
    {
        /// <summary>Calculates the square of anumber</summary>
        /// <param name="num">The number to calculate</param>
        /// <returns>The calculated square</returns>
        /// <exception cref="OverflowException">Throw when the
        /// result is too big to be storein an int</exception>
        /// <seealso cref="System.Int32"/>
        public static int Square(int num)
        {
            checked
            {
                return num * num;
            }

        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args">The command line arguments</param>
        

        static void Main(string[] args)
        {
            Console.WriteLine("3*3 = " + Square(3));
        }

    }
}
