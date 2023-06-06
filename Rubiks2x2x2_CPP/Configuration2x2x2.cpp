#include "Configuration2x2x2.h"

//
// Added 6/05/2023 Thomas Downes 
//

Configuration2x2x2::Configuration2x2x2(const Configuration2x2x2& par_copy)
{
	//
	// Added 6/05/2023 Thomas Downes 
	//
	//  this->crLeft = par_copy.crLeft;
	//  this->crRight = par_copy.crRight;
	//  this->crTop = par_copy.crTop;
	//  this->crBottom = par_copy.crBottom;

	//this->crLeft = new ConfigRing2x2(par_copy.crLeft);
	//this->crRight = new ConfigRing2x2(par_copy.crRight);
	//this->crTop = new ConfigRing2x2(par_copy.crTop);
	//this->crBottom = new ConfigRing2x2(par_copy.crBottom);

	this->crLeft = new ConfigRing2x2(par_copy.crLeft);
	this->crRight = new ConfigRing2x2(par_copy.crRight);
	this->crTop = new ConfigRing2x2(par_copy.crTop);
	this->crBottom = new ConfigRing2x2(par_copy.crBottom);



}



void Configuration2x2x2::RotateConfigRing2x2_Clockwise(ConfigRing2x2& par_ringToRotateCW)
{
	//
	// Added 6/5/2023 thomas downes 
	//
	//Piece2x2x2 tempPieceOfRingToRotate; 
	//tempPieceOfRingToRotate = par_ringToRotateCW.GetAnyPiece();

	Piece2x2x2* tempPieceOfRingToRotate = par_ringToRotateCW.GetAnyPiece();
	
	// The linked, parallel ring will rotate in the opposite 
	//    direction (Counter-CW), hence the suffix "CCW".
	ConfigRing2x2 ringOtherToRotateCCW = this->crBack;

    // If the addresses match, they are the same for us & C#.NET.
	if (&crBack == &par_ringToRotateCW) ringOtherToRotateCCW = this->crFront;
	else if (&crFront == &par_ringToRotateCW) ringOtherToRotateCCW = this->crBack;

	else if (&crTop == &par_ringToRotateCW) ringOtherToRotateCCW = this->crBottom;
	else if (&crBottom == &par_ringToRotateCW) ringOtherToRotateCCW = this->crTop;

	else if (&crLeft == &par_ringToRotateCW) ringOtherToRotateCCW = this->crRight;
	else if (&crRight == &par_ringToRotateCW) ringOtherToRotateCCW = this->crLeft;

	//
	//  In a particular configuration, for a particular 2x2 set of four(4) 
	//    pieces, each piece is linked to a piece in a parallel 2x2 set of four(4)
	//    pieces (w/ no pieces overlapping, but existing in a parallel plane).
	//
	Piece2x2x2* tempExternalLinkedPiecePreRotate =
		par_ringToRotateCW.GetLinkedPieceFromOtherRing(tempPieceOfRingToRotate);

	// CCW = Counter-clockwise
	Piece2x2x2* tempExternalLinkedPieceCCW =
		ringOtherToRotateCCW.GetNextPieceCounterCW(tempExternalLinkedPiecePreRotate);


	for (int index = 0; index < 3; ++index)
	{
		//
		//  In a particular configuration, for a particular 2x2 set of four(4) 
		//    pieces, each piece is linked to a piece in a parallel 2x2 set of four(4)
		//    pieces (w/ no pieces overlapping, but existing in a parallel plane).
		//
		par_ringToRotateCW.SetLinkedPieceToOtherRing(tempPieceOfRingToRotate,
			 tempExternalLinkedPiece.

	}



}

