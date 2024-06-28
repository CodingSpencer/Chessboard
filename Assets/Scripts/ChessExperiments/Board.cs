/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;*/

public class Board
{
    public Square[, ] squares;

    public Board()
    {
        SetBoard();
    }

    public void SetBoard()
    {
        squares = new Square[8, 8] {
            {new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square()},
            {new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square()},
            {new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square()},
            {new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square()},
            {new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square()},
            {new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square()},
            {new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square()},
            {new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square()}
        };

        squares[0, 0].setPieceAndColor(Piece.Rook, Piece.White);
        squares[1, 0].setPieceAndColor(Piece.Knight, Piece.White);
        squares[2, 0].setPieceAndColor(Piece.Bishop, Piece.White);
        squares[3, 0].setPieceAndColor(Piece.Queen, Piece.White);
        squares[4, 0].setPieceAndColor(Piece.King, Piece.White);
        squares[5, 0].setPieceAndColor(Piece.Bishop, Piece.White);
        squares[6, 0].setPieceAndColor(Piece.Knight, Piece.White);
        squares[7, 0].setPieceAndColor(Piece.Rook, Piece.White);

        for (int i = 0; i < 8; i++) {
            squares[i, 1].setPieceAndColor(Piece.Pawn, Piece.White);
            squares[i, 6].setPieceAndColor(Piece.Pawn, Piece.Black);
        }
        
        squares[0, 7].setPieceAndColor(Piece.Rook, Piece.Black);
        squares[1, 7].setPieceAndColor(Piece.Knight, Piece.Black);
        squares[2, 7].setPieceAndColor(Piece.Bishop, Piece.Black);
        squares[3, 7].setPieceAndColor(Piece.Queen, Piece.Black);
        squares[4, 7].setPieceAndColor(Piece.King, Piece.Black);
        squares[5, 7].setPieceAndColor(Piece.Bishop, Piece.Black);
        squares[6, 7].setPieceAndColor(Piece.Knight, Piece.Black);
        squares[7, 7].setPieceAndColor(Piece.Rook, Piece.Black);

        for (int rank = 0; rank < 8; rank++) {
            for (int file = 0; file < 8; file++) {
                squares[file, rank].setFile(file);
                squares[file, rank].setRank(rank);
            }
        }
    }

    public Square[, ] GetSquares()
    {
        return squares;
    }
}
