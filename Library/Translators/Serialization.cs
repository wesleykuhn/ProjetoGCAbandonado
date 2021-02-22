using System.Web.Script.Serialization;
using System.IO;
using System.Collections.Generic;
using GC.Library.Objects;
using System;
using Newtonsoft.Json;

namespace GC.Library.Translators
{
    public class Serialization
    {
        public static T TxtStringToObject<T>(string text)
        {
            try
            {                
                JavaScriptSerializer jss = new JavaScriptSerializer();
                T result = (T)jss.Deserialize(text, typeof(T));
                return result;
            }
            catch (Exception ex)
            {
                Errors.Care.AppendOnErrorLogFile(ex.Message);
                T nullObj = default(T);
                return nullObj;
            }
        }

        public static void ObjectToTxtFile<T>(T obj, string path, bool useCrypto)
        {
            JsonSerializerSettings microsoftDateFormatSettings = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
            };
            string result = JsonConvert.SerializeObject(obj, microsoftDateFormatSettings);
            if (useCrypto)
            {
                File.WriteAllText(path, WKCrypto.W530(result));
            }
            else
            {
                File.WriteAllText(path, result);
            }            
        }

        public static T TxtFileToObject<T>(string path, bool isCrypto)
        {
            try
            {
                string serializedObject = File.ReadAllText(path);
                JsonSerializerSettings microsoftDateFormatSettings = new JsonSerializerSettings
                {
                    DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
                };

                T obj = default(T);
                if (isCrypto)
                {
                    obj = JsonConvert.DeserializeObject<T>(WKCrypto.W710(serializedObject), microsoftDateFormatSettings);
                }
                else
                {
                    obj = JsonConvert.DeserializeObject<T>(serializedObject, microsoftDateFormatSettings);
                }
                
                return obj;
            }
            catch (Exception ex)
            {
                Errors.Care.AppendOnErrorLogFile(ex.Message);
                T nullObj = default(T);
                return nullObj;
            }                    
        }

        public static void ObjectsListToTxtFile<T>(List<T> objs, string path, bool useCrypto)
        {
            JsonSerializerSettings microsoftDateFormatSettings = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
            };
            string result = JsonConvert.SerializeObject(objs, microsoftDateFormatSettings);

            if (useCrypto)
            {
                File.WriteAllText(path, WKCrypto.W530(result));
            }
            else
            {
                File.WriteAllText(path, result);
            }                  
        }

        /// <summary>
        /// Class to read a serialized List<T> of the files. It will return an empty List<T> if there's something wrong.
        /// </summary>
        /// <typeparam name="T">Type of the List.</typeparam>
        /// <param name="path">THe path where the file is.</param>
        /// <returns>If it get success returns a list with the generic itens else returns and empty list.</returns>
        public static List<T> TxtFileToObjectsList<T>(string path, bool isCrypto)
        {
            try
            {
                string serializedObject = File.ReadAllText(path);
                JsonSerializerSettings microsoftDateFormatSettings = new JsonSerializerSettings
                {
                    DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
                };

                List<T> objs;
                if (isCrypto)
                {
                    objs = JsonConvert.DeserializeObject<List<T>>(WKCrypto.W710(serializedObject), microsoftDateFormatSettings);
                }
                else
                {
                    objs = JsonConvert.DeserializeObject<List<T>>(serializedObject, microsoftDateFormatSettings);
                }
                 
                return objs;
            }
            catch (Exception ex)
            {
                Errors.Care.AppendOnErrorLogFile(ex.Message);
                List<T> nullList = new List<T>();
                return nullList;
            }            
        }

        public static void SerializeRequest(Request request)
        {
            string fileDir = Informations.Directories.Requests + request.Number + "_" +
                GlobalVariables.User.Id.ToString() + ".txt";
            ObjectToTxtFile<Request>(request, fileDir, true); 
        }

        internal static void SerializeDailySale(DayRecord daysRecord)
        {
            string fileDir = Informations.Directories.DaysRecords + DateTime.Now.ToString("ddMMyyyy") + "_" + GlobalVariables.User.Id.ToString() + ".txt";
            ObjectToTxtFile<DayRecord>(daysRecord, fileDir, true);
        }
        
        public static void SerializeWarranty(Warranty warranty)
        {
            string fileDir = Informations.Directories.Warranties + warranty.Number + "_" + GlobalVariables.User.Id.ToString() + ".txt";
            ObjectToTxtFile<Warranty>(warranty, fileDir, true);
        }

        public static void SerializeReminder(Reminder reminder)
        {
            string fileDir = Informations.Directories.Reminders + reminder.Id + "_" + GlobalVariables.User.Id.ToString() + ".txt";
            // 1_1.txt
            ObjectToTxtFile<Reminder>(reminder, fileDir, true);
        }
    }
}
