using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;  //Added 11/13/2020 thomas downes

namespace RubiksCube_2x2
{
    namespace Back
    {
        //
        // Added 11/12/2020 thomas downes
        //

        class ClassRotateRules : BackOrFront
        {
            BlueOrangeYellow _pieceBOY;
            BlueYellowRed _pieceBYR;
            GreenRedYellow _pieceGRY;
            GreenYellowOrange _pieceGYO; 

            public ClassRotateRules(BlueOrangeYellow par_BOY, 
                                    BlueYellowRed par_BYR,
                                    GreenRedYellow par_GRY,
                                    GreenYellowOrange par_GYO)
            {
                //
                // Added 11/12/2020 thomas downes
                //
                _pieceBOY = par_BOY;
                _pieceBYR = par_BYR;
                _pieceGRY = par_GRY;
                _pieceGYO = par_GYO; 

            }

            public override void Simple_Clockwise90()
            {
                //
                // Added 11/12/2020 thomas downes
                //
                _pieceBOY.Rotate_Clockwise90();
                _pieceBYR.Rotate_Clockwise90();
                _pieceGRY.Rotate_Clockwise90();
                _pieceGYO.Rotate_Clockwise90();

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
                Color colorOfSide = _pieceBOY.GetColorOfFrontFace();

                return (colorOfSide == _pieceBYR.GetColorOfFrontFace()) &&
                       (colorOfSide == _pieceGRY.GetColorOfFrontFace()) &&
                       (colorOfSide == _pieceGYO.GetColorOfFrontFace());

            }

        }
    }
}
