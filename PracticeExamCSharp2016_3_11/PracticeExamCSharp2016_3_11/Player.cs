using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExamCSharp2016_3_11
{
    public class Player
    {
        public List<List<string>> PlayerBoard;
        public List<Piece> PlayerPieces;

        public Player(List<List<string>> playerBoard, List<Piece>playerPieces)
        {
            this.PlayerBoard = playerBoard;
            this.PlayerPieces = playerPieces;
        }


        public List<Piece> playerPieces
        {
            get { return PlayerPieces; }
            set { PlayerPieces = value; }
        }        

        public List<List<string>> playerBoard
        {
            get { return PlayerBoard; }
            set { PlayerBoard = value; }
        }
    }
}
