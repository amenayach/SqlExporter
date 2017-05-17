using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql2K2.ObjectModel
{
    public static class SqlManager
    {

        /// <summary>
        /// Execute sql query and fill the result against the generic type T
        /// </summary>
        public static List<T> ExecuteQueryNoCon<T>(string s, string connectionString, params SqlParameter[] sqlParameters)
        {
            List<T> res = new List<T>();
            string er = "";
            SqlDataReader r = null;
            try
            {
                using (var condb = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(s, condb))
                {
                    if (sqlParameters.Length > 0)
                    {
                        cmd.Parameters.AddRange(sqlParameters);
                    }

                    if (cmd.Connection.State != ConnectionState.Open)
                    {
                        cmd.Connection.Open();
                    }

                    r = cmd.ExecuteReader();

                    var prps = typeof(T).GetProperties();

                    if (r.HasRows)
                    {
                        while (r.Read())
                        {
                            if (typeof(T).FullName.Contains("System."))
                            {
                                res.Add((T)r[0]);
                                // Classes
                            }
                            else
                            {
                                var c = (T)Activator.CreateInstance(typeof(T));
                                for (int j = 0; j <= r.FieldCount - 1; j++)
                                {
                                    var jj = j;
                                    //er = dt.Rows(jj)("ColumnName").ToLower
                                    var fname = r.GetName(j).ToString();
                                    er = fname;
                                    var fType = r.GetProviderSpecificFieldType(j).ToString().ToLower();
                                    var p = prps.Where(f => f.Name.Trim().ToLower() == fname.ToLower()).ToList();
                                    if (p.Count > 0)
                                    {
                                        //Date or DateTime
                                        if (fType.Contains("date"))
                                        {
                                            if (!p[0].PropertyType.FullName.ToLower().Contains("system.nullable") && (r[fname] == null || r[fname].Equals(System.DBNull.Value)))
                                            {
                                                p[0].SetValue(c, DateTime.Now, null);
                                            }
                                            else
                                            {
                                                if (!(p[0].PropertyType.FullName.ToLower().Contains("system.nullable") && (r[fname] == null || r[fname].Equals(System.DBNull.Value))))
                                                {
                                                    p[0].SetValue(c, r[fname], null);
                                                }
                                            }
                                            //String
                                        }
                                        else if (fType.Contains("string"))
                                        {
                                            if (r[fname] == null || r[fname].Equals(System.DBNull.Value))
                                            {
                                                p[0].SetValue(c, "", null);
                                            }
                                            else
                                            {
                                                p[0].SetValue(c, r[fname], null);
                                            }
                                        }
                                        else
                                        {
                                            if (!(p[0].PropertyType.FullName.ToLower().Contains("system.nullable") && (r[fname] == null || r[fname].Equals(System.DBNull.Value))))
                                            {
                                                p[0].SetValue(c, r[fname], null);
                                            }
                                        }
                                    }
                                }
                                res.Add(c);
                            }
                        }
                    }
                    r.Close();

                }

            }
            catch (Exception ex)
            {
                if (r != null && r.IsClosed == false)
                {
                    r.Close();
                }
                throw;
            }
            return res;
        }

        /// <summary>
        /// Execute sql query and fill the result in datatable
        /// </summary>
        public static DataTable ExecuteQuery(string s, string connectionString, params SqlParameter[] @params)
        {
            DataTable dt = null;

            using (var con = new SqlConnection(connectionString))
            using (var da = new SqlDataAdapter(s, con))
            {
                dt = new DataTable();
                if (@params.Length > 0)
                {
                    da.SelectCommand.Parameters.AddRange(@params);
                }
                if (da.SelectCommand.Connection.State != ConnectionState.Open)
                    da.SelectCommand.Connection.Open();
                da.Fill(dt);
                da.SelectCommand.Connection.Close();
                da.Dispose();
            }

            return dt;

        }

        /// <summary>
        /// Normalize SQL value to the equivalant string representation
        /// </summary>
        public static string ToSql(this object sqlValue, bool useSqlStringNotation)
        {

            if (sqlValue == null || DBNull.Value.Equals(sqlValue))
            {
                return "NULL";
            }
            else if (sqlValue is DateTime?)
            {
                return AddSqlStringNotation(((DateTime)sqlValue).ToString("yyyy-MM-dd HH:mm:ss"), useSqlStringNotation);
            }
            else if (sqlValue is DateTime)
            {
                return AddSqlStringNotation(((DateTime)sqlValue).ToString("yyyy-MM-dd HH:mm:ss"), useSqlStringNotation);
            }
            else if (sqlValue is bool)
            {
                return ((bool)sqlValue) ? "1" : "0";
            }
            else
            {
                return AddSqlStringNotation(sqlValue.ToString(), useSqlStringNotation);
            }

        }

        /// <summary>
        /// Adds N'' for string if "use sql string notation" is true
        /// </summary>
        private static string AddSqlStringNotation(string value, bool useSqlStringNotation)
        {

            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }
            else
            {
                return (useSqlStringNotation ? "N'" : "") + value + (useSqlStringNotation ? "'" : "");
            }

        }

    }
}
