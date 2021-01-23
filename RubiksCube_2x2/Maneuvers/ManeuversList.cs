using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube_2x2.Maneuvers
{
    public class ManeuversList
    {
        //
        // Added 1/13/2021 Thomas Downes 
        //
        public List<Maneuver> MyList = new List<Maneuver>();

        public ManeuversList()
        {
        }

        public Maneuver this[int i]
        {
            //
            // This is an indexer.  https://www.c-sharpcorner.com/uploadfile/puranindia/indexers-in-C-Sharp/#:~:text=Indexers%20in%20C#%20.NET.%20An%20indexer,%20also%20called,be%20accessed%20using%20the%20[]%20array%20access%20operator.
            //
            get
            {
                return MyList[i];
            }
            set
            {
                MyList[i] = value;
            }
        }

        
        public void Load_HardcodedItems()
        {
            //
            // Added 1/21/2021 Thomas DOWNES
            //
            if (this.MyList.Count() != 0) return;   //Exit if this procedure is not needed.  

            var objMan1 = new Maneuver();
            var objMan2 = new Maneuver();

            objMan1.backside_move1_from130 = Maneuvers.ComplexRulesEngine0130.this_complex_move;
            objMan1.backside_move2_from430 = Maneuvers.ComplexRulesEngine0430.this_complex_move;
            objMan1.backside_move3_from730 = Maneuvers.ComplexRulesEngine0730.this_complex_move;
            objMan1.backside_move4_from1030 = Maneuvers.ComplexRulesEngine0130.this_complex_move;

            objMan1.frontside_move1_from130 = (new ComplexPieceMove() { NothingHappens = true });
            objMan1.frontside_move2_from430 = (new ComplexPieceMove() { NothingHappens = true });
            objMan1.frontside_move3_from730 = (new ComplexPieceMove() { NothingHappens = true });
            objMan1.frontside_move4_from1030 = (new ComplexPieceMove() { NothingHappens = true });




            this.MyList.Add(objMan1);
            this.MyList.Add(objMan2);

        }



    }
}
