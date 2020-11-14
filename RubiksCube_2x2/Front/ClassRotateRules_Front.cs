using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;  //Added 11/13/2020 thomas downes

namespace RubiksCube_2x2
{
    namespace Front
    {
        //
        // Added 11/13/2020 thomas downes
        //

        class ClassRotateRules_Front : BackOrFront
        {
            BlueOrangeWhite _pieceBOW;
            BlueRedWhite _pieceBRW;
            GreenRedWhite _pieceGRW;
            GreenOrangeWhite _pieceGOW; 

            public ClassRotateRules_Front(BlueOrangeWhite par_BOW, 
                                    BlueRedWhite par_BRW,
                                    GreenRedWhite par_GRW,
                                    GreenOrangeWhite par_GOW)
            {
                //
                // Added 11/12/2020 thomas downes
                //
                _pieceBOW = par_BOW;
                _pieceBRW = par_BRW;
                _pieceGRW = par_GRW;
                _pieceGOW = par_GOW; 

            }

            public override void Simple_Clockwise90()
            {
                //
                // Added 11/12/2020 thomas downes
                //
                _pieceBOW.Rotate_Clockwise90();
                _pieceBRW.Rotate_Clockwise90();
                _pieceGRW.Rotate_Clockwise90();
                _pieceGOW.Rotate_Clockwise90();
                 
            }

            public override void ComplexRotation()
            {
                //
                // Added 11/13/2020 thomas downes
                //
                //EnumFaceNum temp = _pieceGOW.WhichFaceIsFront; 
                //_pieceGOW.WhichFaceIsFront = _pieceGOW.WhichFaceIsS_of_front;
                //_pieceGOW.WhichFaceIsS_of_front = _pieceGOW.WhichFaceIsE_of_front;
                //_pieceGOW.WhichFaceIsE_of_front = temp;
                _pieceGOW.RotateJustThisPiece_Clockwise();

            }

            public override void Simple_Counterwise90()
            {
                //
                // Added 11/12/2020 thomas downes
                //


            }

            //Added 11/13/2020 thomas downes
            public override bool SideIsASolidColor()
            {
                //
                // Added 11/13/2020 thomas downes
                //
                Color colorOfSide = _pieceBOW.GetColorOfFrontFace();

                return (colorOfSide == _pieceBRW.GetColorOfFrontFace()) &&
                       (colorOfSide == _pieceGRW.GetColorOfFrontFace()) &&
                       (colorOfSide == _pieceGOW.GetColorOfFrontFace());

            }

        }
    }
}
