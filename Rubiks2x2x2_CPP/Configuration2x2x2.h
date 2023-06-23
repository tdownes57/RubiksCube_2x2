#pragma once
//#include "EnumColors.cpp"
//#include "Piece2x2x2.cpp"
//#include "TwoColorEdge.cpp"
#include "ConfigRing2x2.cpp"

class Configuration2x2x2
{
	//
	// This is a current state of the Rubiks 2x2x2.
	// 
	// This is a collection of mutually-connected,
	//    triply-linked pieces.  
	//
private:
	//Piece2x2x2* p0;
	//Piece2x2x2* p1;
	//Piece2x2x2* p2;
	//Piece2x2x2* p3;
	//Piece2x2x2* p4;
	//Piece2x2x2* p5;
	//Piece2x2x2* p6;
	//Piece2x2x2* p7;
	ConfigRing2x2 crLeft;
	ConfigRing2x2 crRight;
	ConfigRing2x2 crTop;
	ConfigRing2x2 crBottom;
	ConfigRing2x2 crFront;
	ConfigRing2x2 crBack;

public:
	// Class copy construction can't have parameter of type of the class
	// https://stackoverflow.com/questions/17207898/class-copy-construction-cant-have-parameter-of-type-of-the-class/17207936#17207936
	// ---Configuration2x2x2(Configuration2x2x2 par_copy);
	//
	Configuration2x2x2();
	Configuration2x2x2(const Configuration2x2x2& par_copy);

	Piece2x2x2* GetAdjacentPiece(const TwoColorEdge* par_edgeCommon);
	ConfigRing2x2* GetAdjacentConfigRing(const TwoColorEdge* par_edgeCommon);

	void RotateConfigRing2x2_Clockwise(ConfigRing2x2& par_ringToRotateCW);

	//
	// The following will run a check of the configuration using a X-Y-Z 
	//   coordinate system. 
	//
	bool TestConfigUsingXYZCoordinates();

};

