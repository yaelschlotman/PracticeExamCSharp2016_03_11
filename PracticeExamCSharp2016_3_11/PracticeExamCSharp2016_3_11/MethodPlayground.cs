using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PracticeExamCSharp2016_3_11.Tools;

namespace PracticeExamCSharp2016_3_11
{
    public class MethodPlayground
    {
        public List<Piece> GivePlayerPieces()
        {
            List<Piece> playerPieceList = new List<Piece>();
            playerPieceList.Add(new Destroyer());
            playerPieceList.Add(new Submarine());
            playerPieceList.Add(new Battleship());
            playerPieceList.Add(new AircraftCarrier());
            return playerPieceList;
        }        
    }
}
