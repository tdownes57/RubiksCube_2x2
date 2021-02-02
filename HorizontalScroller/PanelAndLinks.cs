using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Added 2/1/2021 thomas downes 
/// </summary>

namespace HorizontalScroller
{
    class PanelAndLinks : IComparable<PanelAndLinks>
    {
        //
        // Added 2/1/2021 thoomas downes  
        //  
        public Panel myPanel;
        public LinkLabel myRotateCW;
        public LinkLabel myRotateCCW;

        public int PanelLeft() { return this.myPanel.Left; }

        public void SetPositionLeft(int par_left)
        {
            //
            // Added 2/1/2021 thomas downes 
            //
            //myPanel.Left += par_left;
            myRotateCCW.Left += (par_left - myPanel.Left);   // Let's shift the link the same amount as the Panel, below.
            myRotateCW.Left += (par_left - myPanel.Left);
            //myPanel.Left += (par_left - myPanel.Left);  // Ovely complex. Simplifies to:  myPanel.Left = par_left;
            myPanel.Left = par_left;   // Simplified !!
        }

        public void PositionLeft_Subtract(int par_left_subtract)
        {
            //
            // Added 2/1/2021 thomas
            //
            //myPanel.Left += par_left_subtract;
            //myRotateCCW.Left += par_left_subtract;
            //myRotateCW.Left += par_left_subtract;

            myPanel.Left -= par_left_subtract;
            myRotateCCW.Left -= par_left_subtract;
            myRotateCW.Left -= par_left_subtract;

        }


        public void PositionLeft_Add(int par_left_add)
        {
            //   
            // Added 2/1/2021 thomas
            //
            myPanel.Left += par_left_add;
            myRotateCCW.Left += par_left_add;
            myRotateCW.Left += par_left_add;

        }

        public int CompareTo(PanelAndLinks other)
        {
            //
            // See https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.sort?view=net-5.0
            //----throw new NotImplementedException();
            //
            return this.myPanel.Left.CompareTo(other.myPanel.Left);

        }
    }
}
