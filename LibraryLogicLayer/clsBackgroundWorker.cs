using LibraryLogicLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    /// <summary>
    /// this class contains any operations or business logic  that requires Multithreading or MultiProcessing
    /// </summary>
    public class clsBackgroundWorker
    {
        /// <summary>
        /// this method converts a data table into various forms XML PDF JSON using a new thread.
        /// </summary>
        /// <param name="obj">put the result file you want to convert to XML JSON PDF objects. </param>
        /// <param name="dt">Put the data table as a source material for converting.</param>
        /// <param name="FileName"></param>
        /// <param name="TableName">Optional by default it's Table </param>
        /// <returns>boolean result. </returns>
        public static async Task<bool> Converter(IF_Convertible obj, DataTable dt,
            string FileName , string TableName = "Table1")
        {
           return await Task.Run(() =>  (obj.Convert(dt, FileName, TableName)));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"> XML JSON PDF objects that implements IF_Convertible interface.</param>
        /// <param name="FilePath">the selected file path. </param>
        /// <returns> a data table.</returns>
        public static async Task<DataTable> ConvertToDataTable( IF_ConvertToDataTable obj ,string FilePath)
        {
            return await Task.Run(() => obj.ConvertToDataTable(FilePath));
        }


    }
}
