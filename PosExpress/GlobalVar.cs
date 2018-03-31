using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosExpress
{
    public static class GlobalVar
    {
        public static string dbConnection
        {
            get
            {
                return "Data Source=" + PosExpress.Properties.Settings.Default.dbConnection + ";Version=3;";
            }
        }

        public static SQLiteConnection sqlConnection = new SQLiteConnection(GlobalVar.dbConnection);

        public static DataTable GetData(string sql)
        {
            sqlConnection.Open();
            SQLiteDataAdapter daReader = new SQLiteDataAdapter(sql, dbConnection);
            DataSet dsReturn = new DataSet();
            daReader.Fill(dsReturn);
            sqlConnection.Close();
            if (dsReturn.Tables.Count > 0)
            {
                return dsReturn.Tables[0];
            }
            return null;
        }

        public static ReturnTrans InserData(List<string> listSql)
        {
            var ret = new ReturnTrans { ok = true  };
            using ( var con = sqlConnection)
            {
                con.Open();
                var tr = con.BeginTransaction();
                try
                {
                    foreach (var item in listSql)
                    {
                        SQLiteCommand cmd = con.CreateCommand();
                        cmd.Transaction = tr;
                        cmd.CommandText = item;
                        cmd.ExecuteNonQuery();
                    }
                    tr.Commit();
                }
                catch (SQLiteException ex)
                {
                    tr.Rollback();
                    ret.err = ex.Message;
                    ret.ok = false;
                }
                con.Close();
            }
            return ret;
        }

        public static ReturnTrans InserDataWithParam(List<SQLiteCommand> listCommand)
        {
            var ret = new ReturnTrans { ok = true };
            using (var con = sqlConnection)
            {
                con.Open();
                var tr = con.BeginTransaction();
                try
                {
                    foreach (var item in listCommand)
                    {
                        item.Transaction = tr;
                        item.ExecuteNonQuery();
                    }
                    tr.Commit();
                }
                catch (SQLiteException ex)
                {
                    tr.Rollback();
                    ret.err = ex.Message;
                    ret.ok = false;
                }
                con.Close();
            }
            return ret;
        }
    }

    public class ReturnTrans
    {
        public bool ok { get; set; }
        public string err { get; set; }
    }
}
