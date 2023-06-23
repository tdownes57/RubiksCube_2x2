#pragma once
#include <map>
#include "EnumColors.cpp"
//#include "Piece2x2x2.cpp"
//#include "TwoColorEdge.cpp"
#include "ConfigEdgePair.cpp"

//
//
//
class ConfigRing2x2
{
private: 
    //
    //In a particular configuration, 
    //   the following describes how 
    //   four(4) two-color edges are paired 
    //   up. 
    //
    //ConfigEdgePair cep0;
    //ConfigEdgePair cep1;
    //ConfigEdgePair cep2;
    //ConfigEdgePair cep3;
    // 6/5/2023 std::map<Piece2x2x2, Piece2x2x2> _mapNextPieceClockwise;
    // 6/5/2023 std::map<Piece2x2x2, Piece2x2x2> _mapToExternalPiecesAdjacent;
    std::map<Piece2x2x2*, Piece2x2x2*> _mapNextPieceClockwise;
   std::map<Piece2x2x2*, Piece2x2x2*> _mapToExternalPiecesAdjacent;
   ConfigRing2x2* _adjacentRing;    

public: 
    ConfigRing2x2();  // We need a default constructor. ---6/23/2023 thomas downes

    ConfigRing2x2(const ConfigRing2x2& par_copy);

    ConfigRing2x2(const ConfigRing2x2& par_copy, 
                  const ConfigRing2x2& par_adjacent);

    ConfigRing2x2(const Piece2x2x2& clockwise0,
            const Piece2x2x2& clockwise1,
            const Piece2x2x2& clockwise2,
            const Piece2x2x2& clockwise3);
    //   {
    //       _mapNextPieceClockwise.insert(clockwise0, clockwise1);
    //        _mapNextPieceClockwise.insert(clockwise1, clockwise2);
    //        _mapNextPieceClockwise.insert(clockwise2, clockwise3);
    //        _mapNextPieceClockwise.insert(clockwise3, clockwise0);
    //   }

    void SetAdjacentRing(ConfigRing2x2* par_otherRing,
        Piece2x2x2* par_pieceInternalToBeginLinkToOtherRing,
        Piece2x2x2* par_pieceExternalOfOtherRing);

    void RefreshLinksToOtherRing(Piece2x2x2* par_pieceInternalToBeginLinkToOtherRing,
        Piece2x2x2* par_pieceExternalOfOtherRing);



    Piece2x2x2* GetAnyPiece() const
    {

        return (*(_mapNextPieceClockwise.begin())).first;

    }


    Piece2x2x2* GetNextPieceClockwise(Piece2x2x2* par_piece) const
    {

        Piece2x2x2* tempPiece = par_piece;
        tempPiece = _mapNextPieceClockwise.at(tempPiece);
        return tempPiece;

    }


    Piece2x2x2* GetNextPieceCounterCW(Piece2x2x2* par_piece)
    {

        Piece2x2x2* tempPiece = par_piece;
        tempPiece = _mapNextPieceClockwise.at(tempPiece);
        tempPiece = _mapNextPieceClockwise.at(tempPiece);
        tempPiece = _mapNextPieceClockwise.at(tempPiece);

        // We need to make sure we've come full circle, so that
        //   the next piece is 
        Piece2x2x2* tempPieceChecking = _mapNextPieceClockwise.at(tempPiece);
        bool bChecksOkay = (tempPieceChecking == par_piece);
        if (bChecksOkay) return tempPiece;

    }


    //
    //  In a particular configuration, for a particular 2x2 set of four(4) 
    //    pieces, each piece is linked to a piece in a parallel 2x2 set of four(4)
    //    pieces (w/ no pieces overlapping, but existing in a parallel plane).
    //
    Piece2x2x2* GetLinkedPieceFromOtherRing(Piece2x2x2* par_pieceOfRingToBeRotated);





    //ConfigRing2x2(ConfigEdgePair p0, ConfigEdgePair p1,
    //    ConfigEdgePair p2, ConfigEdgePair p3)
    //{
    //    cep0 = p0;
    //    cep1 = p1;
    //    cep2 = p2;
    //    cep3 = p3;
    //}

};

