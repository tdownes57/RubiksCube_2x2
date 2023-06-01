#pragma once
#include "EnumColors.cpp"
#include "Piece2x2x2.h"

class Face1x1
{
private:
	EnumColors _enumColor;
	Piece2x2x2* _pieceMy;
	Face1x1* _nextFaceCW; // CW = Clockwise.
	Face1x1* _priorFaceCW; // CW = Clockwise.

public:
	Face1x1()  {
		_enumColor = _Undetermined;
		_pieceMy = nullptr;
	}

	Face1x1(EnumColors par_enumColor, Piece2x2x2* par_pieceParent)
	{
		_enumColor = par_enumColor;
		_pieceMy = par_pieceParent;
	}




};

