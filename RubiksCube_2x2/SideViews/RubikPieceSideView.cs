using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube_2x2.SideViews
{
    class RubikPieceSideView : RubikPieceCorner
    {
        //
        // Added 1/31/2021 thomas downes
        //
        RubikPieceCorner mod_basePiece;  //Added 2/1/2021 td 

        public RubikPieceSideView(RubikPieceCorner par_piece, EnumPrimaryView par_enum)
        {
            //
            // Added 1/31/2021 thomas downes
            //
            mod_basePiece = par_piece;  //Added 2/1/2021 td

            if (par_enum == EnumPrimaryView.Unassigned) throw new NotImplementedException();
            if (par_enum == EnumPrimaryView.Back) throw new NotImplementedException();
            if (par_enum == EnumPrimaryView.Front) throw new NotImplementedException();

            //
            // Create a Side-View version of the parameter-passed Rubik 2x2 Piece (Corner). 
            //
            switch (par_piece.FrontClockFacePosition) 
            {
                case FrontClockFace.four_thirty: this.FrontClockFacePosition = FrontClockFace.seven_thirty; break;
                case FrontClockFace.one_thirty: this.FrontClockFacePosition = FrontClockFace.ten_thirty; break;
                case FrontClockFace.seven_thirty: this.FrontClockFacePosition = FrontClockFace.four_thirty; break;
                case FrontClockFace.ten_thirty: par_piece.FrontClockFacePosition = FrontClockFace.one_thirty; break;
            }

            //---bool bValidFace_East = (EnumFaceNum.NotApplicable_DifferentPiece != this.WhichFaceIsE_of_front);
            bool bValidFace_East = (EnumFaceNum.NotApplicable_DifferentPiece != par_piece.WhichFaceIsE_of_front
                                     && EnumFaceNum.NotSpecified != par_piece.WhichFaceIsE_of_front);
            
            if (bValidFace_East) this.WhichFaceIsFront = par_piece.WhichFaceIsE_of_front;

            //---bool bValidFace_West = (EnumFaceNum.NotApplicable_DifferentPiece != this.WhichFaceIsW_of_front);
            bool bValidFace_West = (EnumFaceNum.NotApplicable_DifferentPiece != par_piece.WhichFaceIsW_of_front
                                     && EnumFaceNum.NotSpecified != par_piece.WhichFaceIsW_of_front);

            if (bValidFace_West) this.WhichFaceIsFront = par_piece.WhichFaceIsE_of_front;

            //
            // Error handling!!!!
            //
            if (this.WhichFaceIsFront == EnumFaceNum.NotSpecified)
            {
                throw new NotImplementedException();  
            }

            //
            // Switch East & West. 
            //
            //___EnumFaceNum tempFaceNum_East = this.WhichFaceIsE_of_front; 
            //___this.WhichFaceIsE_of_front = this.WhichFaceIsW_of_front;
            //___this.WhichFaceIsW_of_front = tempFaceNum_East;

            //The East & West pieces __do__ switch.
            this.WhichFaceIsE_of_front = par_piece.WhichFaceIsW_of_front;
            this.WhichFaceIsW_of_front = par_piece.WhichFaceIsE_of_front;

            //The North & South pieces do __NOT__ switch.
            this.WhichFaceIsN_of_front = par_piece.WhichFaceIsN_of_front;
            this.WhichFaceIsS_of_front = par_piece.WhichFaceIsS_of_front;

        }

        public override System.Drawing.Color FaceColor1of3 { get { return mod_basePiece.FaceColor1of3; } }
        public override System.Drawing.Color FaceColor2of3 { get { return mod_basePiece.FaceColor2of3; } }
        public override System.Drawing.Color FaceColor3of3 { get { return mod_basePiece.FaceColor3of3; } }


        public override string GetColorAbbreviationXYZ()
        {
            throw new NotImplementedException();
        }

        public override void LoadInitialState_NotInUse()
        {
            throw new NotImplementedException();
        }

        public override void ReorientPiece(FrontClockFace par_enum, Color par_frontfacecolor)
        {
            throw new NotImplementedException();
        }

        public override void Revolve_Clockwise90()
        {
            throw new NotImplementedException();
        }
    }
}
