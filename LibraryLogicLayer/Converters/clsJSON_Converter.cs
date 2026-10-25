using LibraryLogicLayer.Interfaces;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;
namespace LibraryLogicLayer.Converters
{
    public class clsJSON_Converter : IF_Convertible , IF_ConvertToDataTable
    {

        public  bool Convert(DataTable dt, string FilePath, string TableName)
        {
            try
            {
                dt.TableName = TableName;
                DataContractJsonSerializer Serializer = new DataContractJsonSerializer(typeof(DataTable));
                using (MemoryStream stream = new MemoryStream())
                {
                    Serializer.WriteObject(stream, dt);
                    string jsonString = System.Text.Encoding.UTF8.GetString(stream.ToArray());

                    File.WriteAllText(FilePath, jsonString);
                    return true;
                }
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public DataTable ConvertToDataTable(string FilePath)
        {
            DataTable dtResult = new DataTable();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(DataTable));
            try
            {
                using (FileStream stream = new FileStream(FilePath, FileMode.Open))
                {
                    dtResult = (DataTable)serializer.ReadObject(stream);
                    return dtResult;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }

    }
}
