using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;  //Added 11/17/2020 thomas downes  
using System.Windows.Forms;   //Added 11/17/2020 thomas downes

namespace RubiksCube_2x2
{
    class JsonStaticClass_Save
    {
        //
        // Added 11/17/2020 thomas Downes  
        //
        public static void SavePiece_BOY(Back.BlueOrangeYellow par_BOY)
        {
            //
            // Added 11/17/2020 thomas Downes  
            //
            string strJsonStringFor_BOY = ""; // Properties.Settings.Default.PositionOf_BOY;

            //var objectNewtonJsonConverter = new Newtonsoft.Json.JsonConverter();

            var objSettings = new JsonSerializerSettings(); //Added 11/17/2020 td  

            try
            {
                //
                // Convert the JSON to the object. 
                //
                //-----strJsonStringFor_BOY = JsonConvert.SerializeObject(par_BOY);
                strJsonStringFor_BOY = JsonConvert.SerializeObject(par_BOY, 
                    typeof(Back.BlueOrangeYellow), objSettings);

                //return objectBOY;
                Properties.Settings.Default.PositionOf_BOY = strJsonStringFor_BOY;
                Properties.Settings.Default.Save(); 

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //return null; 
            }
            //return null;
        }


        public static void SavePiece_BYR(Back.BlueYellowRed par_BYR)
        {
            //
            // Added 11/17/2020 thomas Downes  
            //
            string strJsonStringFor_BYR = ""; // Properties.Settings.Default.PositionOf_BOY;

            //var objectNewtonJsonConverter = new Newtonsoft.Json.JsonConverter();

            var objSettings = new JsonSerializerSettings(); //Added 11/17/2020 td  

            try
            {
                //
                // Convert the JSON to the object. 
                //
                //---strJsonStringFor_BYR = JsonConvert.SerializeObject(par_BYR);
                strJsonStringFor_BYR = JsonConvert.SerializeObject(par_BYR,
                    typeof(Back.BlueYellowRed), objSettings);

                //return objectBYR;
                Properties.Settings.Default.PositionOf_BYR = strJsonStringFor_BYR;
                Properties.Settings.Default.Save();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //return null; 
            }
            //return null;
        }


        public static void SavePiece_GRY(Back.GreenRedYellow par_GRY)
        {
            //
            // Added 11/17/2020 thomas Downes  
            //
            string strJsonStringFor_GRY = ""; // Properties.Settings.Default.PositionOf_BOY;

            //var objectNewtonJsonConverter = new Newtonsoft.Json.JsonConverter();

            var objSettings = new JsonSerializerSettings(); //Added 11/17/2020 td  

            try
            {
                //
                // Convert the JSON to the object. 
                //
                //-----strJsonStringFor_BOY = JsonConvert.SerializeObject(par_BOY);
                strJsonStringFor_GRY = JsonConvert.SerializeObject(par_GRY,
                    typeof(Back.GreenRedYellow), objSettings);

                //return objectBOY;
                Properties.Settings.Default.PositionOf_GRY = strJsonStringFor_GRY;
                Properties.Settings.Default.Save();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //return null; 
            }
            //return null;
        }


        public static void SavePiece_GYO(Back.GreenYellowOrange par_GYO)
        {
            //
            // Added 11/17/2020 thomas Downes  
            //
            string strJsonStringFor_GYO = ""; // Properties.Settings.Default.PositionOf_BOY;

            //var objectNewtonJsonConverter = new Newtonsoft.Json.JsonConverter();

            var objSettings = new JsonSerializerSettings(); //Added 11/17/2020 td  

            try
            {
                //
                // Convert the JSON to the object. 
                //
                //-----strJsonStringFor_BOY = JsonConvert.SerializeObject(par_BOY);
                strJsonStringFor_GYO = JsonConvert.SerializeObject(par_GYO,
                    typeof(Back.GreenYellowOrange), objSettings);

                //return objectBOY;
                Properties.Settings.Default.PositionOf_GYO = strJsonStringFor_GYO;
                Properties.Settings.Default.Save();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //return null; 
            }
            //return null;
        }


    }
}
