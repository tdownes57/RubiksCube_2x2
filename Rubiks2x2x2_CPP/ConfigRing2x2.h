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

public: 
    ConfigRing2x2(Piece2x2x2 clockwise0,
        Piece2x2x2 clockwise1,
        Piece2x2x2 clockwise2,
        Piece2x2x2 clockwise3)
    {
        _mapNextPieceClockwise.insert(clockwise0, clockwise1);
        _mapNextPieceClockwise.insert(clockwise1, clockwise2);
        _mapNextPieceClockwise.insert(clockwise2, clockwise3);
        _mapNextPieceClockwise.insert(clockwise3, clockwise0);

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

