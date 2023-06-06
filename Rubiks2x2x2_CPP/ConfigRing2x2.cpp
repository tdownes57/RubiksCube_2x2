#include "ConfigRing2x2.h"


ConfigRing2x2::ConfigRing2x2(const Piece2x2x2& clockwise0,
    const Piece2x2x2& clockwise1,
    const Piece2x2x2& clockwise2,
    const Piece2x2x2& clockwise3)
{
    _mapNextPieceClockwise.insert(clockwise0, clockwise1);
    _mapNextPieceClockwise.insert(clockwise1, clockwise2);
    _mapNextPieceClockwise.insert(clockwise2, clockwise3);
    _mapNextPieceClockwise.insert(clockwise3, clockwise0);

}

ConfigRing2x2::ConfigRing2x2(const ConfigRing2x2& par_ringToCopy)
{
	//
	// Added 6/05/2023 Thomas Downes 
	//
    this->_mapNextPieceClockwise = par_ringToCopy._mapNextPieceClockwise;
    //this->_mapToExternalPiecesAdjacent = par_ringToCopy._mapToExternalPiecesAdjacent;
    //this->_adjacentRing = par_copy._adjacentRing;

}


//---The 2nd parameter (par_ringAdjacentRing) doesn't make a lot of sense. 
// 
//---ConfigRing2x2::ConfigRing2x2(const ConfigRing2x2& par_ringToCopy,
//                             const ConfigRing2x2& par_ringAdjacentRing)
//{
//    //
//    // Added 6/05/2023 Thomas Downes 
//    //
//    this->_mapNextPieceClockwise = par_ringToCopy._mapNextPieceClockwise;
//    this->_mapToExternalPiecesAdjacent = par_ringToCopy._mapToExternalPiecesAdjacent;
//    this->_adjacentRing = &par_ringAdjacentRing;
//
//}


void ConfigRing2x2::SetAdjacentRing(ConfigRing2x2* par_otherRing,
    Piece2x2x2* par_pieceInternalToBeginLinkToOtherRing,
    Piece2x2x2* par_pieceExternalOfOtherRing)
{
    _adjacentRing = par_otherRing;

    RefreshLinksToOtherRing(par_pieceInternalToBeginLinkToOtherRing,
        par_pieceExternalOfOtherRing);

}

//
//  In a particular configuration, for a particular 2x2 set of four(4) 
//    pieces, each piece is linked to a piece in a parallel 2x2 set of four(4)
//    pieces (w/ no pieces overlapping, but existing in a parallel plane).
//
Piece2x2x2* ConfigRing2x2::GetLinkedPieceFromOtherRing(Piece2x2x2* par_pieceOfRingToBeRotated)
{
    //
    // Added 6/5/2023  
    //
    return _mapToExternalPiecesAdjacent.at(par_pieceOfRingToBeRotated);

}


void ConfigRing2x2::RefreshLinksToOtherRing(Piece2x2x2* par_pieceInternalToBeginLinkToOtherRing,
    Piece2x2x2* par_pieceExternalOfOtherRing)
{

    _mapToExternalPiecesAdjacent.clear();

    //Insert #1 of 3.
    _mapToExternalPiecesAdjacent.insert(par_pieceInternalToBeginLinkToOtherRing,
        par_pieceExternalOfOtherRing);

    //Insert #2 of 3.
    Piece2x2x2* tempPieceInternal = par_pieceInternalToBeginLinkToOtherRing;
    Piece2x2x2* tempPieceOtherRing = par_pieceExternalOfOtherRing; // tempPieceExternal

    //Get next external piece, but COUNTER-clockwise!!   
    tempPieceOtherRing = _adjacentRing->GetNextPieceCounterCW(tempPieceOtherRing);
    tempPieceInternal = _mapNextPieceClockwise.at(tempPieceInternal);
    _mapToExternalPiecesAdjacent.insert(tempPieceInternal,
        tempPieceOtherRing);

    //Insert #2 of 3.
    tempPieceInternal = _mapNextPieceClockwise.at(tempPieceInternal);

    //Get next external piece, but COUNTER-clockwise!!   
    tempPieceOtherRing = _adjacentRing->GetNextPieceCounterCW(tempPieceOtherRing);
    _mapToExternalPiecesAdjacent.insert(tempPieceInternal,
        tempPieceOtherRing);

}


//void ConfigRing2x2::SetAdjacentRing(ConfigRing2x2* par_otherRing,
//    Piece2x2x2* par_pieceOfOtherRing,
//    Piece2x2x2* par_pieceToBeginLinkToOtherRing)
//{
//    _adjacentRing = par_otherRing;
//
//    _mapToExternalPiecesAdjacent.clear();
//
//    //Insert #1 of 3.
//    _mapToExternalPiecesAdjacent.insert(par_pieceToBeginLinkToOtherRing,
//        par_pieceOfOtherRing);
//
//    //Insert #2 of 3.
//    Piece2x2x2* tempPieceInternal = par_pieceToBeginLinkToOtherRing;
//    Piece2x2x2* tempPieceOtherRing = par_pieceOfOtherRing;
//
//    //Get next external piece, but COUNTER-clockwise!!   
//    tempPieceOtherRing = par_otherRing->GetNextPieceCounterCW(tempPieceExternal);
//    tempPieceInternal = &_mapNextPieceClockwise.at(*tempPieceInternal);
//    _mapToExternalPiecesAdjacent.insert(tempPieceInternal,
//        tempPieceOtherRing);
//
//    //Insert #2 of 3.
//    tempPieceInternal = &_mapNextPieceClockwise.at(*tempPieceInternal);
//
//    //Get next external piece, but COUNTER-clockwise!!   
//    tempPieceOtherRing = par_otherRing->GetNextPieceCounterCW(tempPieceOtherRing);
//    _mapToExternalPiecesAdjacent.insert(tempPieceInternal,
//        tempPieceOtherRing);
//
//}





