﻿using System.Diagnostics;
using static Chess.ChessHelper;
namespace Chess;

public class SAN : IEquatable<SAN>, IEquatable<Notation>
{
    public int Castling { get; set; }
    public bool Capturing { get; set; } = false;
    public bool Check { get; set; } = false;
    public bool CheckMate { get; set; } = false;
    public (char, int) PawnCapturing { get; set; }
    public PieceType Piece { get; set; }
    public char? SpecifyPiece { get; set; }
    public PieceType? IsQueening { get; set; } = null;
    public Notation Square { get; set; }


    // This ToString override is used to print the SAN in proper notation

    public override string ToString() =>
        GetNotation().Trim();
    public string GetNotation()
    {
        if(Castling == 1)
        {
            return "O-O";
        }
        else if(Castling == -1)
        {
            return "O-O-O";
        }

        string ret =  $"{Piece.GetChar()}" +
        $"{(SpecifyPiece is null ? "" : SpecifyPiece)}" +
        $"{(Capturing && Piece == PieceType.PAWN ? (
            PawnCapturing.Item2 == -1 ? $"{PawnCapturing.Item1}" : $"{PawnCapturing.Item2}"
            ) : "")}" +
        $"{(Capturing ? "x" : "")}" +
        $"{Square.File}" +
        $"{Square.Rank}" +
        $"{(IsQueening == null ? "" : $"={((PieceType)IsQueening).GetChar()}")}";

        return ret.Trim();

    }

    public SAN(string str)
    {
        From(str);
    }

    public SAN()
    {
    }

    public static SAN From(string str)
    {
        SAN san = new SAN();
        // ed
        // exd4
        // Nd4
        // Nxd4

        if(str.Count(x => x == 'O') == 2)
        {
            san.Castling = 1;
            // return san;
        }
        else if(str.Count(x => x == 'O') == 3)
        {
            san.Castling = -1;
            // return;
        }

        if (str.Contains('x'))
        {
            san.Capturing = true;
        }

        if(str.Contains('+'))
        {
            san.Check = true;
        }

        if(str.Contains('#'))
        {
            san.Check = true;
            san.CheckMate = true;
        }

        // CharToNotation.TryGetValue(str[0], out PieceType p);
        if (char.IsUpper(str[0]))
        {
            san.Piece = str[0].GetPiece();
        }
        else if(san.Capturing)
        {
            san.PawnCapturing = (str[0], -1);
            san.Piece = PieceType.PAWN;
        }
        else
        {
            san.Piece = PieceType.PAWN;
        }

        int numLocation = str.IndexOfAny("123456789".ToArray());

        char file = str[numLocation - 1];
        Debug.Print($"{str[numLocation]}");
        int rank = Convert.ToInt16(str[numLocation].ToString());


        Debug.Print($"File: {file}, Rank: {rank}");

        san.Square = Notation.From(file, rank);

        return san;
    }

    public bool Equals(SAN? other)
    {
        return ToString() == other?.ToString();
    }

    public bool Equals(Notation other)
    {
        return GetNotation() == other.ToString();
    }
}
