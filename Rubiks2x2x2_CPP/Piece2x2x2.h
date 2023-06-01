#pragma once
#include "TwoColorEdge.h"
#include "Face1x1.h"

class Piece2x2x2
{
private:
	//TwoColorEdge^ twoColorEdge0; // Managed by .NET 
	//TwoColorEdge^ twoColorEdge1; // Managed by .NET 
	//TwoColorEdge^ twoColorEdge2; // Managed by .NET
	Face1x1* _face0;
	Face1x1* _face1;
	Face1x1* _face2;

	//TwoColorEdge* _twoColorEdge0;
	//TwoColorEdge* _twoColorEdge1;
	//TwoColorEdge* _twoColorEdge2;

public: 
	//CW = Clockwise, CCW = Counter-clockwise 
	Piece2x2x2(TwoColorEdge* e1, TwoColorEdge* e2, TwoColorEdge* e3);
	TwoColorEdge AdjacentEdgeCW(TwoColorEdge* par_edge);
	TwoColorEdge AdjacentEdgeCCW(TwoColorEdge* par_edge);
	//---Not my job. Piece2x2x2 AdjacentPiece(TwoColorEdge* par_edgeTouching);

	~Piece2x2x2()
	{
		//delete _twoColorEdge0;
		//delete _twoColorEdge1;
		//delete _twoColorEdge2;
		//_twoColorEdge0 = nullptr;
		//_twoColorEdge1 = nullptr;
		//_twoColorEdge2 = nullptr;

		delete _face0;
		delete _face1;
		delete _face2;
		_face0 = nullptr;
		_face1 = nullptr;
		_face2 = nullptr;
	}



};




