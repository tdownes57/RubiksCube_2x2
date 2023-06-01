#pragma once
#include "EnumColors.cpp"
#include "Piece2x2x2.cpp"

//enum class EnumColors
//{
//	Green, Red, White, Blue, Orange, Yellow
//};

class TwoColorEdge
{
private:
	EnumColors clockwiseColor1;
	EnumColors clockwiseColor2;
	//Piece2x2x2^ pieceMy;   // Managed by .NET 
	Piece2x2x2* pieceMy;
	TwoColorEdge* nextEdgeOfPieceCW;
	TwoColorEdge* priorEdgeOfPieceCW;
	//---Not my job. TwoColorEdge* adjacentEdgeOtherPiece;

public:
	//CW = ClockWise 
	TwoColorEdge(EnumColors ec1, EnumColors ec2) : 
		clockwiseColor1 ( ec1 ), clockwiseColor2( ec2 ) {};
	Piece2x2x2* GetMyPiece() { return pieceMy; }
	//---Not my job. Piece2x2x2* GetAdjacentEdgeOfOtherPiece();

	//TwoColorEdge* GetNextEdgeCW();
	//TwoColorEdge* GetPriorEdgeCW();

	~TwoColorEdge()
	{
		delete pieceMy;
		pieceMy = nullptr;
	}

};







