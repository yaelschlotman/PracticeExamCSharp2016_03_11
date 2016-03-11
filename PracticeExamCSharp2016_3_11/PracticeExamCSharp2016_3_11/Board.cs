using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExamCSharp2016_3_11
{
    public class Board
    {
        public List<string> CreateBoardLength()
        {
            string boardSpace = "x";
            List<string> boardLength = new List<string>();
            for (int i = 1; i < 21; i++)
            {
                boardLength.Add(boardSpace);
            }
            return boardLength;
        }
        public List<List<string>> CreateGameBoard()
        {
            List<string> boardLength = CreateBoardLength();
            List<List<string>> playerGameBoard = new List<List<string>>();

            for (int i = 1; i < 21; i++)
            {
                playerGameBoard.Add(boardLength);
            }

            foreach (List<string> listItem in playerGameBoard)
            {
                foreach (string listNumber in listItem)
                {
                    Console.Write(listNumber + " ");
                }
                Console.WriteLine();
            }
            return playerGameBoard;
        }      
    }
}
