using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExamCSharp2016_3_11
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodPlayground playground = new MethodPlayground();
            Board board = new Board();

            //playground.CreateBoardLength();
            board.CreateGameBoard();
            Console.ReadKey();
        }
    }
}
