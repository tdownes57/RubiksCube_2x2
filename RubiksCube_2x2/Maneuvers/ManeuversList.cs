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




     }
}
