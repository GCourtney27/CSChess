using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChessLibrary;
using System.Diagnostics;

namespace BoardTests
{
    [TestClass]
    public class Chess960Test
    {
        [TestMethod]
        public void Test_No_Pawns_Added()
        {
            // Arange
            Board board = new Board();
            
            // Act
            Piece.PieceType piece = (Piece.PieceType)board.GetRandomLocationForPiece(1, 6);

            // Assert
            Assert.AreNotEqual(Piece.PieceType.Pawn, piece);
        }

        [TestMethod]
        public void Test_No_Empty_Pieces_Added()
        {
            // Arange
            Board board = new Board();

            // Act
            Piece.PieceType piece = (Piece.PieceType)board.GetRandomLocationForPiece(1, 6);

            // Assert
            Assert.AreNotEqual(Piece.PieceType.Empty, piece);
        }

        [TestMethod]
        public void Test_No_Triple_Rooks_Added()
        {
            // Arange
            Board board = new Board();
            int expectedValue = 2;
            board.Init(true);

            // Act
            board.InitRandomCells(true);

            // Assert
            Assert.AreEqual(expectedValue, board.NumRooks);
        }

        [TestMethod]
        public void Test_No_Triple_Knights_Added()
        {
            // Arange
            Board board = new Board();
            int expectedValue = 2;
            board.Init(true);

            // Act
            board.InitRandomCells(true);

            // Assert
            Assert.AreEqual(expectedValue, board.NumKnights);
        }

        [TestMethod]
        public void Test_No_Triple_Bishop_Added()
        {
            // Arange
            Board board = new Board();
            int expectedValue = 2;
            board.Init(true);

            // Act
            board.InitRandomCells(true);

            // Assert
            Assert.AreEqual(expectedValue, board.NumBishops);
        }

    }

}
