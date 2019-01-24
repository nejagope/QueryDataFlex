using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataFlex
{
    public class DataFlexODBC
    {
        public static bool TestConnection(string ConnectionString)
        {
            bool ret = false;
            OdbcConnection con = new OdbcConnection(ConnectionString);
            try
            {

                con.Open();
                ret = true;
            }
            catch
            {
                ret = false;                                
            }
            finally
            {
                try
                {
                    con.Close();
                }
                catch { }
            }
            return ret;
        }

        public static DataTable Select(string ConnectionString, string sql)
        {            
            DataTable dt = new DataTable();
            
            try
            {
                OdbcConnection con = new OdbcConnection(ConnectionString);
                con.Open();

                OdbcDataAdapter da2 = new OdbcDataAdapter(sql, con);

                da2.Fill(dt);
                con.Close();
            }
            catch
            {
                
            }
            return dt;
        }

        public static DataTable Export(string ConnectionString, string TableName, int MaxRowCount, Label msj)
        {
            
            DataTable dt = new DataTable();
            int filas = 0;

            try
            {
                bool salir = false;                
                
                int i = 0;

                while (!salir)
                {
                    int filasTemp = 0;
                    DataTable dtTemp = new DataTable();
                    OdbcConnection con = new OdbcConnection(ConnectionString);                    
                    con.Open();

                    string sql = $"SELECT * FROM {TableName} WHERE RECORD_NUMBER > {i} AND RECORD_NUMBER <= {i+100}";
                    OdbcDataAdapter da2 = new OdbcDataAdapter(sql, con);

                    da2.Fill(dtTemp);
                    da2.Fill(dt);
                    filasTemp = dtTemp.Rows.Count;
                    filas += filasTemp;

                    con.Close();
                    
                    i += 100;
                    salir = filasTemp == 0 || filasTemp < 100 || filas >= MaxRowCount;
                    if (filas % 100 == 0)
                    {
                        msj.Text = $"{filas} filas procesadas";
                        msj.Refresh();
                        Application.DoEvents();
                    }
                }
            }
            catch
            {

            }
            finally
            {

            }
            msj.Text = $"{filas} filas procesadas";
            msj.Refresh();
            Application.DoEvents();

            return dt;
        }
    }

    
}
