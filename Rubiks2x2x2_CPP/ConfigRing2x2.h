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
   std::map<Piece2x2x2, Piece2x2x2> _mapNextPieceClockwise;
   std::map<Piece2x2x2, Piece2x2x2> _mapToExternalPiecesAdjacent;
   ConfigRing2x2* _adjacentRing;    

public: 
    ConfigRing2x2(const Piece2x2x2& clockwise0,
        const Piece2x2x2& clockwise1,
        const Piece2x2x2& clockwise2,
        const Piece2x2x2& clockwise3)
    {
        _mapNextPieceClockwise.insert(clockwise0, clockwise1);
        _mapNextPieceClockwise.insert(clockwise1, clockwise2);
        _mapNextPieceClockwise.insert(clockwise2, clockwise3);
        _mapNextPieceClockwise.insert(clockwise3, clockwise0);

    }

    void SetOtherRing(ConfigRing2x2* par_otherRing,
                      Piece2x2x2* par_pieceOfOtherRing,
                      Piece2x2x2* par_pieceToBeginLinkToOtherRing)
    {
        _adjacentRing = par_otherRing;

        _mapToExternalPiecesAdjacent.clear();
        
        //Insert #1 of 3.
        _mapToExternalPiecesAdjacent.insert(par_pieceToBeginLinkToOtherRing,
            par_pieceOfOtherRing);

        //Insert #2 of 3.
        Piece2x2x2* tempPieceInternal = par_pieceToBeginLinkToOtherRing;
        Piece2x2x2* tempPieceOtherRing = par_pieceOfOtherRing;

        //Get next external piece, but COUNTER-clockwise!!   
        tempPieceOtherRing = par_otherRing->GetNextPieceCounterCW(tempPieceExternal);
        tempPieceInternal = & _mapNextPieceClockwise.at(*tempPieceInternal);
        _mapToExternalPiecesAdjacent.insert(tempPieceInternal,
                                           tempPieceOtherRing);

        //Insert #2 of 3.
        tempPieceInternal = &_mapNextPieceClockwise.at(*tempPieceInternal);

        //Get next external piece, but COUNTER-clockwise!!   
        tempPieceOtherRing = par_otherRing->GetNextPieceCounterCW(tempPieceOtherRing);
        _mapToExternalPiecesAdjacent.insert(tempPieceInternal,
            tempPieceOtherRing);

    }


    Piece2x2x2* GetNextPieceClockwise(Piece2x2x2* par_piece)
    {

        Piece2x2x2* tempPiece = par_piece;
        tempPiece = &_mapNextPieceClockwise.at(*tempPiece);
        return tempPiece;

    }


    Piece2x2x2* GetNextPieceCounterCW(Piece2x2x2* par_piece)
    {

        Piece2x2x2* tempPiece = par_piece;
        tempPiece = &_mapNextPieceClockwise.at(*tempPiece);
        tempPiece = &_mapNextPieceClockwise.at(*tempPiece);
        tempPiece = &_mapNextPieceClockwise.at(*tempPiece);

        // We need to make sure we've come full circle, so that
        //   the next piece is 
        Piece2x2x2* tempPieceChecking = &_mapNextPieceClockwise.at(*tempPiece);
        bool bChecksOkay = (tempPieceChecking == par_piece);
        if (bChecksOkay) return tempPiece;

    }


    //ConfigRing2x2(ConfigEdgePair p0, ConfigEdgePair p1,
    //    ConfigEdgePair p2, ConfigEdgePair p3)
    //{
    //    cep0 = p0;
    //    cep1 = p1;
    //    cep2 = p2;
    //    cep3 = p3;
    //}

};

