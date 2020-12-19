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
        public static void SaveToDiskPiece_BOY(Back.BlueOrangeYellow par_BOY, bool par_briefly)
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

                string strSerializationFor_BOY = "";  // Added 12/14/2020 td

                if (par_briefly)
                {
                    //
                    // Added 12/14/2020 td
                    //
                    //var objectSide = new Back.ClassBacksideBrief()
                    //   Example:   BOY/NE==F1:N_F2:E_F3:F 
                    //   Example:   BOY/SW==F1:S_F2:W_F3:F 
                    strSerializationFor_BOY = par_BOY.ToString();
                    Properties.Settings.Default.PositionOf_BOY = strSerializationFor_BOY;
                }
                else
                {
                    strJsonStringFor_BOY = JsonConvert.SerializeObject(par_BOY,
                        typeof(Back.BlueOrangeYellow), objSettings);
                    Properties.Settings.Default.PositionOf_BOY = strJsonStringFor_BOY;
                }

                //return objectBOY;
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


        public static void SaveToDiskPiece_BYR(Back.BlueYellowRed par_BYR, bool par_briefly)
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

                //Added 12/14/2020 td
                //   Example:   BYR/NE==F1:N_F2:E_F3:F 
                //   Example:   BYR/SW==F1:S_F2:W_F3:F 
                if (par_briefly) strJsonStringFor_BYR = par_BYR.ToString();

                else strJsonStringFor_BYR = JsonConvert.SerializeObject(par_BYR,
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


        public static void SaveToDiskPiece_GRY(Back.GreenRedYellow par_GRY, bool par_briefly)
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

                //Added 12/14/2020 td
                //   Example:   GRY/NE==F1:N_F2:E_F3:F 
                //   Example:   GRY/SW==F1:S_F2:W_F3:F 
                if (par_briefly) strJsonStringFor_GRY = par_GRY.ToString();

                else strJsonStringFor_GRY = JsonConvert.SerializeObject(par_GRY,
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


        public static void SavePiece_GYO(Back.GreenYellowOrange par_GYO, bool par_briefly)
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

                //Added 12/14/2020 td
                //   Example:   GYO/NE==F1:N_F2:E_F3:F 
                //   Example:   GYO/SW==F1:S_F2:W_F3:F 
                if (par_briefly) strJsonStringFor_GYO = par_GYO.ToString();

                else strJsonStringFor_GYO = JsonConvert.SerializeObject(par_GYO,
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
