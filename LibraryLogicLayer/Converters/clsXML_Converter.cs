using LibraryLogicLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace LibraryLogicLayer.Converters
{
    public class clsXML_Converter : IF_Convertible , IF_ConvertToDataTable
    {
        private static bool ConvertToXML(DataTable d , string Filename , string TableName)
        {

            try
            {
                var result = "";
                d.TableName = TableName;
                XmlSerializer XMLSerializer = new XmlSerializer(d.GetType());
                using (StringWriter sw = new StringWriter())
                {
                    using (XmlWriter w = XmlWriter.Create(sw, new XmlWriterSettings { Indent = true }))
                    {
                        XMLSerializer.Serialize(w, d);
                        result = sw.ToString();
                        File.WriteAllText(Filename, result);
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public DataTable ConvertToDataTable(string FilePath)
        {
            try
            {
                DataTable dt = new DataTable();
                string Content = File.ReadAllText(FilePath);
                var xmlSerializer = new XmlSerializer(typeof(DataTable));
                using (TextReader reader = new StringReader(Content))
                {
                    dt = xmlSerializer.Deserialize(reader) as DataTable;
                }
                return dt;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public bool Convert(DataTable dt, string Filename , string TableName)
        {
            return ConvertToXML(dt,Filename , TableName);
        }
    }
}
