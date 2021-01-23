using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube_2x2.SideViews
{
    class ClassSideViewSide : RubiksCubeOneSide
    {
        //
        // Added 1/23/2021  
        //
        //private Rubiks SideNewFront;
        //private RubiksCubeOneSide SideNewBack;  

        public ClassSideViewSide(RubiksCubeBothSides par_cubeFrontAndBack, EnumLeftOrRight par_enum)
        {
            //
            // Added 1/23/2021 thomas downes 
            //
            //SideNewFront = new RubiksCubeOneSide();

            if (par_enum == EnumLeftOrRight.Left)
            {
                base.Piece1 = par_cubeFrontAndBack.FrontSide.GetPiece(FrontClockFace.ten_thirty);
                base.Piece2 = par_cubeFrontAndBack.FrontSide.GetPiece(FrontClockFace.seven_thirty);
                base.Piece3 = par_cubeFrontAndBack.BackSide.GetPiece(FrontClockFace.one_thirty);
                base.Piece4 = par_cubeFrontAndBack.BackSide.GetPiece(FrontClockFace.four_thirty);
            }
            else if (par_enum == EnumLeftOrRight.Right)
            {
                base.Piece1 = par_cubeFrontAndBack.FrontSide.GetPiece(FrontClockFace.one_thirty);
                base.Piece2 = par_cubeFrontAndBack.FrontSide.GetPiece(FrontClockFace.four_thirty);
                base.Piece3 = par_cubeFrontAndBack.BackSide.GetPiece(FrontClockFace.ten_thirty);
                base.Piece4 = par_cubeFrontAndBack.BackSide.GetPiece(FrontClockFace.seven_thirty);
            }


        }


        public override void ComplexRevolution()
        {
            throw new NotImplementedException();
        }

        public override RubikPieceCorner GetPiece(FrontClockFace par_enum)
        {
            throw new NotImplementedException();
        }

        public override void GodlikeSwitch(RubikPieceCorner par_dragged, RubikPieceCorner par_replaced)
        {
            throw new NotImplementedException();
        }

        public override void LoadInitialPositions()
        {
            throw new NotImplementedException();
        }

        public override bool PiecesAreAdjacent(RubikPieceCorner par_piece1, RubikPieceCorner par_piece2)
        {
            throw new NotImplementedException();
        }

        public override bool PiecesAreAdjacent_Clockwise(RubikPieceCorner par_piece1, RubikPieceCorner par_piece2)
        {
            throw new NotImplementedException();
        }

        public override bool PiecesAre_BottomSWSE(RubikPieceCorner par_piece1, RubikPieceCorner par_piece2)
        {
            throw new NotImplementedException();
        }

        public override bool PiecesBelongToThisSide(RubikPieceCorner par_piece1, RubikPieceCorner par_piece2)
        {
            throw new NotImplementedException();
        }

        public override bool SideIsASolidColor()
        {
            throw new NotImplementedException();
        }

        public override void Simple_Clockwise90()
        {
            throw new NotImplementedException();
        }

        public override void Simple_Counterwise90()
        {
            throw new NotImplementedException();
        }

        public override RubikPieceCorner WhichPieceHasMouseHover(Point par_point)
        {
            throw new NotImplementedException();
        }

        public override RubikPieceCorner WhichPieceIsClicked(Point par_point)
        {
            throw new NotImplementedException();
        }
    }
}
