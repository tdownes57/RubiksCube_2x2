#pragma once
#include <stdexcept>
//#include "EnumColors.cpp"
//#include "Piece2x2x2.cpp"
#include "TwoColorEdge.cpp"

class ConfigEdgePair
{
private:
	TwoColorEdge _tce0;
	TwoColorEdge _tce1;
	FacePair _fp0;
	FacePair _fp2;

public:
	ConfigEdgePair() : _tce0{nullptr}, _tce1{nullptr}
	{


	}

	ConfigEdgePair(TwoColorEdge* par0, TwoColorEdge* par1) : 
		_tce0(par1), _tce1(par1)
	{

	}

	TwoColorEdge* GetAdjacentEdge(TwoColorEdge* par_edge)
	{
		if (par_edge == _tce0) return _tce1;
		else if (par_edge == _tce1) return _tce0;
		else throw std::invalid_argument("Edge unrecognized");
	}

	TwoColorEdge* ContainsEdge(TwoColorEdge* par_edge)
	{
		bool result = false;
		if (par_edge == _tce0) result = true;
		else if (par_edge == _tce1) result = true;
		else result;
	}


};

