using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Chessboard
    {
        public const int BoardSize = 8;
        public Figure[,] board;

        public Chessboard()
        {
            board = new Figure[BoardSize, BoardSize];
            InitializeBoard();
        }

        private void InitializeBoard()
        {


            King whiteKing = new King("White");
            PlacePiece(whiteKing, 0, 4);

            King blackKing = new King("black");
            PlacePiece(blackKing, 7, 4);

            Pawn whitePawn1 = new Pawn("white");
            PlacePiece(whitePawn1, 1, 1);

            Pawn whitePawn2 = new Pawn("white");
            PlacePiece(whitePawn1, 1, 2);

            Pawn blackPawn1 = new Pawn("black");
            PlacePiece(blackPawn1, 6, 1);

            Pawn blackPawn2 = new Pawn("black");
            PlacePiece(blackPawn1, 6, 2);

            Knight whiteKnight1 = new Knight("white");
            PlacePiece(whiteKnight1, 0, 1);

            Knight whiteKnigh2 = new Knight("white");
            PlacePiece(whiteKnigh2, 0, 6);

            Knight blackKnight1 = new Knight("black");
            PlacePiece(blackKnight1, 7, 1);

            Knight blackKnight2 = new Knight("black");
            PlacePiece(blackKnight2, 7, 6);

            Rook whiteRook1 = new Rook("white");
            PlacePiece(whiteRook1, 0, 0);

            Rook whiteRook2 = new Rook("white");
            PlacePiece(whiteRook1, 0, 7);

            Rook blackRook1 = new Rook("black");
            PlacePiece(blackRook1, 7, 0);

            Rook blackRook2 = new Rook("black");
            PlacePiece(blackRook2, 7, 7);


        }

        public void PlacePiece(Figure piece, int row, int col)
        {
            if (row < 0 || row >= BoardSize || col < 0 || col >= BoardSize)
            {
                throw new ArgumentOutOfRangeException("Invalid position on the board");
            }

            if (board[row, col] != null)
            {
                throw new InvalidOperationException("Position already occupied");
            }

            board[row, col] = piece;
        }

    }
}
