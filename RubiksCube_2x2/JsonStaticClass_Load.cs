using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;  // Added 11/17/2020 thomas downes   

namespace RubiksCube_2x2
{
    static class JsonStaticClass_Load
    {
        //
        // Added 11/17/2020 thomas Downes  
        //
        private const bool c_boolDebugging = true;  // false;  //true; 

        public static Back.BlueOrangeYellow LoadPiece_BOY()
        {
            //
            // Added 11/17/2020 thomas Downes  
            //
            string strJsonStringFor_BOY = Properties.Settings.Default.PositionOf_BOY;

            //const bool c_boolDebugging = true; 
            if (c_boolDebugging) System.IO.File.WriteAllText("NotUsed_LoadPiece_BOY.txt", strJsonStringFor_BOY);

            if (strJsonStringFor_BOY == "")
            {
                return null;
            }

            if (strJsonStringFor_BOY == "JSON")
            {
                return null;
            }

            //var objectNewtonJsonConverter = new Newtonsoft.Json.JsonConverter();

            try
            {
                //
                // Convert the JSON to the object. 
                //
                Back.BlueOrangeYellow objectBOY =
                    (Back.BlueOrangeYellow)JsonConvert.DeserializeObject(strJsonStringFor_BOY, 
                                                            typeof(Back.BlueOrangeYellow));

                return objectBOY;
            }
            catch (Exception ex)
            {
                string strError = ex.Message;
            }
            finally
            {
                //return null; 
            }
            return null; 
        }


        public static Back.BlueYellowRed LoadPiece_BYR()
        {
            //
            // Added 11/17/2020 thomas Downes  
            //
            string strJsonStringFor_BYR = Properties.Settings.Default.PositionOf_BYR;

            //const bool c_boolDebugging = true; 
            if (c_boolDebugging) System.IO.File.WriteAllText("NotUsed_LoadPiece_BYR.txt", strJsonStringFor_BYR);

            if (strJsonStringFor_BYR == "")
            {
                return null;
            }

            if (strJsonStringFor_BYR == "JSON")
            {
                return null;
            }

            //var objectNewtonJsonConverter = new Newtonsoft.Json.JsonConverter();

            try
            {
                //
                // Convert the JSON to the object. 
                //
                Back.BlueYellowRed objectBYR =
                    (Back.BlueYellowRed)JsonConvert.DeserializeObject(strJsonStringFor_BYR,
                                                     typeof(Back.BlueYellowRed));

                return objectBYR;
            }
            catch (Exception ex)
            {
                string strError = ex.Message;
            }
            finally
            {
                //return null; 
            }
            return null;

        }


        public static Back.GreenRedYellow LoadPiece_GRY()
        {
            //---public static RubikPieceCorner LoadPiece_GRY()
            //
            // Added 11/17/2020 thomas Downes  
            //
            string strJsonStringFor_GRY = Properties.Settings.Default.PositionOf_GRY;

            //const bool c_boolDebugging = true; 
            if (c_boolDebugging) System.IO.File.WriteAllText("NotUsed_LoadPiece_GRY.txt", strJsonStringFor_GRY);

            if (strJsonStringFor_GRY == "")
            {
                return null;
            }

            if (strJsonStringFor_GRY == "JSON")
            {
                return null;
            }
            //var objectNewtonJsonConverter = new Newtonsoft.Json.JsonConverter();

            try
            {
                //
                // Convert the JSON to the object. 
                //
                Back.GreenRedYellow objectGRY =
                    (Back.GreenRedYellow)JsonConvert.DeserializeObject(strJsonStringFor_GRY, 
                                                            typeof(Back.GreenRedYellow));

            return objectGRY;
            }
            catch (Exception ex)
            {
                string strError = ex.Message;
            }
            finally
            {
                //return null; 
            }
            return null;

        }


        public static Back.GreenYellowOrange LoadPiece_GYO()
        {
            //----public static RubikPieceCorner LoadPiece_GYO()
            //
            // Added 11/17/2020 thomas Downes  
            //
            string strJsonStringFor_GYO = Properties.Settings.Default.PositionOf_GYO;

            //const bool c_boolDebugging = true; 
            if (c_boolDebugging) System.IO.File.WriteAllText("NotUsed_LoadPiece_GYO.txt", strJsonStringFor_GYO);

            if (strJsonStringFor_GYO == "")
            {
                return null;
            }

            if (strJsonStringFor_GYO == "JSON")
            {
                return null;
            }

            //var objectNewtonJsonConverter = new Newtonsoft.Json.JsonConverter();

            try
            {
                //
                // Convert the JSON to the object. 
                //
                Back.GreenYellowOrange objectGYO =
                   (Back.GreenYellowOrange)JsonConvert.DeserializeObject(strJsonStringFor_GYO, 
                                                            typeof(Back.GreenYellowOrange));

            return objectGYO;
            }
            catch
            {

            }
            finally
            {
                //return null; 
            }
            return null;

        }



    }
}
