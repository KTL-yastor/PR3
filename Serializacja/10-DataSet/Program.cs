using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Data;

namespace XMLDataSet
{
    class Program
    {

        static void Main(string[] args)
        {
            Serializacja();
            Deserializacja();
        }

        static void Serializacja()
        {
            XmlSerializer xs = new XmlSerializer(typeof(DataSet));
            DataSet ds = new DataSet("Zbior");
            DataTable dt = new DataTable("Tabela");
            DataColumn dc1 = new DataColumn("PierwszaKolumna");
            DataColumn dc2 = new DataColumn("DrugaKolumna");
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            ds.Tables.Add(dt);
            DataRow dr;
            for (int i = 0; i < 5; i++)
            {
                dr = dt.NewRow();
                dr[0] = "Element A" + i.ToString();
                if (i < 4) dr[1] = "Element B" + i.ToString();
                dt.Rows.Add(dr);
            }
            TextWriter tw = new StreamWriter("dane.xml");
            xs.Serialize(tw, ds);
            tw.Close();
        }

        static void Deserializacja()
        {
            XmlSerializer xs = new XmlSerializer(typeof(DataSet));
            TextReader tr = new StreamReader("dane.xml");
            DataSet ds = (DataSet)xs.Deserialize(tr);
            tr.Close();

            Console.WriteLine(ds.DataSetName);
            foreach (DataTable dt in ds.Tables)
            {
                Console.WriteLine("  " + dt.TableName);
                foreach (DataRow dr in dt.Rows)
                {
                    //foreach (var element in dr.ItemArray)
                    //{
                    //    Console.WriteLine("    " + element);
                    //}
                    Console.WriteLine("    Nowy wiersz:");
                    foreach (DataColumn dc in dt.Columns)
                    {
                        string field = dr.Field<string>(dc.ColumnName);
                        if (field != null)
                        {
                            Console.WriteLine("      " + dc.ColumnName + ": " + field);
                        }
                    }
                    //Console.WriteLine("    " + dr.ColumnName + ": " + dr);
                }
            }
        }
    }
}
