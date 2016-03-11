using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExamCSharp2016_3_11
{
    public class Piece
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
        private int _pieceLength;
        private string _pieceName;
        public List<string> CreatePiece(string pieceName, int pieceLength)
        {
            this._pieceName = pieceName;
            this._pieceLength = pieceLength;
            List<string>newPiece = new List<string>();
            for (int i = 0; i < pieceLength; i++)
            {
                newPiece.Add(pieceName);
            }
            return newPiece;
        }
        public int  pieceLength
        {
            get { return _pieceLength; }
            set { _pieceLength = value; }
        }
        public string pieceName
        {
            get { return _pieceName; }
            set { _pieceName = value; }
        }
    }
}
