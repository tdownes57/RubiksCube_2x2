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
                //Copy 2 of 4 pieces from the front side. 
                base.Piece1 = par_cubeFrontAndBack.FrontSide.GetPiece(FrontClockFace.ten_thirty);
                base.Piece2 = par_cubeFrontAndBack.FrontSide.GetPiece(FrontClockFace.seven_thirty);

                //Copy 2 of 4 pieces from the back side. 
                base.Piece3 = par_cubeFrontAndBack.BackSide.GetPiece(FrontClockFace.one_thirty);
                base.Piece4 = par_cubeFrontAndBack.BackSide.GetPiece(FrontClockFace.four_thirty);

            }
            else if (par_enum == EnumLeftOrRight.Right)
            {
                //Copy 2 of 4 pieces from the front side. 
                base.Piece1 = par_cubeFrontAndBack.FrontSide.GetPiece(FrontClockFace.one_thirty);
                base.Piece2 = par_cubeFrontAndBack.FrontSide.GetPiece(FrontClockFace.four_thirty);

                //Copy 2 of 4 pieces from the back side. 
                base.Piece3 = par_cubeFrontAndBack.BackSide.GetPiece(FrontClockFace.ten_thirty);
                base.Piece4 = par_cubeFrontAndBack.BackSide.GetPiece(FrontClockFace.seven_thirty);

            }


        }


        public ClassSideViewSide(RubiksCubeOneSide par_cubeSideToCopy, 
                   EnumLeftOrRight par_enumSideViewIsLeftOrRight,
                   bool par_bPivotPerspective_BackOrFrontToSide,
                   EnumCubeRotation_NorthPole par_cubeRotation = EnumCubeRotation_NorthPole.Unassigned)
        {
            //
            // Added 4/01/2021 thomas downes 
            //
            //Copy 2 of 4 pieces from the front side. 
            const bool boolUseKeywordBase = false;
            if (boolUseKeywordBase)
            {
                base.Piece1 = par_cubeSideToCopy.GetPiece(FrontClockFace.one_thirty);
                base.Piece2 = par_cubeSideToCopy.GetPiece(FrontClockFace.four_thirty);

                //Copy 2 of 4 pieces from the back side. 
                base.Piece3 = par_cubeSideToCopy.GetPiece(FrontClockFace.ten_thirty);
                base.Piece4 = par_cubeSideToCopy.GetPiece(FrontClockFace.seven_thirty);
            }

            //Added 4/1/2021 thomas downes
            //Copy 2 of 4 pieces from the front side.
            //
            const bool boolUseKeywordThis = (!boolUseKeywordBase);
            if (boolUseKeywordThis)
            {
                 this.Piece1 = par_cubeSideToCopy.GetPiece(FrontClockFace.one_thirty);
                this.Piece2 = par_cubeSideToCopy.GetPiece(FrontClockFace.four_thirty);
                //Copy 2 of 4 pieces from the back side. 
                this.Piece3 = par_cubeSideToCopy.GetPiece(FrontClockFace.ten_thirty);
                this.Piece4 = par_cubeSideToCopy.GetPiece(FrontClockFace.seven_thirty);
            }

            //Added 4/2/2021 thomas downes
            if (par_bPivotPerspective_BackOrFrontToSide)
            {
                //Added 4/2/2021 thomas downes
                this.Piece1.PivotPerspective_BackOrFrontToSide(par_cubeRotation);
                this.Piece2.PivotPerspective_BackOrFrontToSide(par_cubeRotation);
                this.Piece3.PivotPerspective_BackOrFrontToSide(par_cubeRotation);
                this.Piece4.PivotPerspective_BackOrFrontToSide(par_cubeRotation);
            }

            // Added 4/2/2021 thomas downes
            this.OriginalFront = par_cubeSideToCopy.OriginalFront; 

        }


        public override void ComplexRevolution()
        {
            throw new NotImplementedException();
        }

        public override RubikPieceCorner GetPiece(FrontClockFace par_enum)
        {
            //throw new NotImplementedException();
            //
            // Added 4/1/2020 thomas d. 
            //
            if (par_enum == Piece1.FrontClockFacePosition) return Piece1;
            if (par_enum == Piece2.FrontClockFacePosition) return Piece2;
            if (par_enum == Piece3.FrontClockFacePosition) return Piece3;
            if (par_enum == Piece4.FrontClockFacePosition) return Piece4;
            throw new ArgumentOutOfRangeException(); //return null; 

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
