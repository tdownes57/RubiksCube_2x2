using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;   // Added 2/1/2021 thomas downes

namespace HorizontalScroller
{
    class PanelAndLinksList
    {
        //
        // Added 2/1/2021 thomas
        //
        public List<PanelAndLinks> myList = new List<PanelAndLinks>();

        // private static int CompareDinosByLength(PanelAndLinks par_x, PanelAndLinks par_y)
        // {
        //     //
        //     //   https://stackoverflow.com/questions/20902248/sorting-a-list-in-c-sharp-using-list-sortcomparisont-comparison
        //     //
        //     return (par_x.PanelLeft() - par_y.PanelLeft());

        //}


        public PanelAndLinksList()
        {
            //
            // Added 2/1/2021  
            //
            //   https://stackoverflow.com/questions/20902248/sorting-a-list-in-c-sharp-using-list-sortcomparisont-comparison
            //
            //   sm = sm.OrderBy(i => i.num_of_words).ToList();
            //
            //   or
            //
            //   sm.Sort((x,y)=>x.num_of_words.CompareTo(y.num_of_words));
            //


        }

        public void AddToList(Panel par_panel, LinkLabel par_linkCW, LinkLabel par_linkCCW)
        {
            //
            // Added 2/1/2021 thomas downes  
            //
            var objNew = new PanelAndLinks();
            objNew.myPanel = par_panel;
            objNew.myRotateCW = par_linkCW;
            objNew.myRotateCCW = par_linkCCW;
            this.myList.Add(objNew);

            //
            // Sort the objects, by the Panel.Left property. 
            //
            this.myList.Sort();  // This will use the public int CompareTo method of the class PanelAndLinks.cs.

        }

        public void PositionLeft_Subtract(int par_left_subtract)
        {
            //
            // Added 2/1/2021 thomas
            //
            foreach (PanelAndLinks objPLink in myList)
            {
                objPLink.PositionLeft_Subtract(par_left_subtract);
            }
        }


        public void PositionLeft_Add(int par_left_add)
        {
            //
            // Added 2/1/2021 thomas
            //
            foreach (PanelAndLinks objPLink in myList)
            {
                objPLink.PositionLeft_Add(par_left_add);
            }
        }


    }
}
