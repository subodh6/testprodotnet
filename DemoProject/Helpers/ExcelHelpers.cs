using DemoProject.Config;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;



namespace DemoProject.Helpers
{
    public class ExcelHelpers
    {

        private static List<Datacollection> _dataCol = new List<Datacollection>();
        //private static int rowNumber;
       // private static string colName;
       // private static string colValue;

        public static void PopulateInCollection()
        {
            DataTable table = ExcelToDataTable(Settings.EXCELPATH);

            //Iterate through the rows and columns of the table
            for (int row = 1; row <= table.Rows.Count; row++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    Datacollection dtTable = new Datacollection();
                    {
                        dtTable.rowNumber = row;
                        dtTable.colName = table.Columns[col].ColumnName;
                        dtTable.colValue = table.Rows[row - 1][col].ToString();
                    }

                    //Add all the details for each row
                    _dataCol.Add(dtTable);
                }
            }



        }

        private static  DataTable ExcelToDataTable(string filename)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = File.Open(filename, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (data) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });
                    //get all the tables
                    DataTableCollection table = result.Tables;

                    //store it in DataTable
                    DataTable resultTable = table["Sheet1"];
                    //return
                    return resultTable;
                }
             
            }

            }

            //Open file and returns as stream
           // FileStream filestream = File.Open(filename, FileMode.Open, FileAccess.Read);

            //create openExcelReader via ExcelReader
          //  IExcelDataReader excelReader = ExcelReaderFactory.CreateReader(filestream);

            //set the first row as column name

            //excelReader.isFirstRowAsColumnNames = true;
           // UseHeaderRow = true


            //DataSet result = excelReader.AsDataSet(new ExcelDataSetConfiguration());

            


            

            




     

        public static string ReadData(int rowNumber, string columnName)
        {
            try
            {
                //Retrieving Data using linq to reduce much of iterations
                            string Data = (from colData in _dataCol
                            where colData.colName == columnName && colData.rowNumber == rowNumber
                            select colData.colValue).SingleOrDefault();


               // var datas = _dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).SingleOrDefault().colValue;

                return Data.ToString();
            }
            catch (Exception)
            {

                return null;
            }


        }

        //public static int ReadIntData(int rowNumber, string columnName)
        //{
        //    try
        //    {
        //        //Retrieving Data using linq to reduce much of iterations
        //         Data = (from colData in _dataCol
        //                    where colData.colName == columnName && colData.rowNumber == rowNumber
        //                       select colData.colValue).SingleOrDefault();


        //        // var datas = _dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).SingleOrDefault().colValue;

        //        return Data;
        //    }
        //    catch (Exception)
        //    {

        //        return null;
        //    }


        //}

    }
    public class Datacollection
    {
        public int rowNumber { get; set; }
        public string colName { get; set; }
        public string colValue { get; set; }


    }
}
