using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Import_System.Data
{


    
        public class DbConnect
        {
            public SqlConnection conETEL_DEST;
            public SqlConnection conERP;

            public void ReadyConnectionconETEL_DEST()
            {
                try
                {
                    conETEL_DEST = new SqlConnection();
                    conETEL_DEST.ConnectionString = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
                    if (conETEL_DEST.State != ConnectionState.Open)
                        conETEL_DEST.Open();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }

            public void CloseConnectionETEL_DEST()
            {
                try
                {
                    if (conETEL_DEST.State == ConnectionState.Open)
                        conETEL_DEST.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public SqlConnection ReadyConnectionETEL_DESTTran()
            {
                try
                {
                    conETEL_DEST = new SqlConnection();
                    conETEL_DEST.ConnectionString = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
                    if (conETEL_DEST.State != ConnectionState.Open)
                        conETEL_DEST.Open();
                    return conETEL_DEST;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }

            public void ReadyConnectionERP()
            {
                try
                {
                    conERP = new SqlConnection();
                    conERP.ConnectionString = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
                    if (conERP.State != ConnectionState.Open)
                        conERP.Open();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }

            public SqlConnection ReadyConnectionconERP()
            {
                try
                {
                    conERP = new SqlConnection();
                    conERP.ConnectionString = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
                    if (conERP.State != ConnectionState.Open)
                        conERP.Open();
                    return conERP;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }

            public SqlConnection ReadyConnectionERPTran()
            {
                try
                {
                    conERP = new SqlConnection();
                    conERP.ConnectionString = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
                    if (conERP.State != ConnectionState.Open)
                        conERP.Open();
                    return conERP;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void CloseConnectionERP()
            {
                try
                {
                    if (conERP.State == ConnectionState.Open)
                        conERP.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


            public DataTable GetDataTableFromSQLETEL_DEST(string sSQL)
            {
                DataTable dataTable = new DataTable();
                try
                {
                    ReadyConnectionconETEL_DEST();
                    SqlCommand cmd = new SqlCommand(sSQL, conETEL_DEST);
                    cmd.CommandTimeout = 0;
                    dataTable.Load(cmd.ExecuteReader());
                    return dataTable;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    CloseConnectionETEL_DEST();
                }
            }

            public bool ExecuteNonQueryFromSpETEL_DEST(string spName, SqlCommand cmd)
            {
                try
                {
                    ReadyConnectionconETEL_DEST();
                    cmd.CommandText = spName;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conETEL_DEST;
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                        return true;
                    else
                        return false;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    CloseConnectionETEL_DEST();
                }
            }

            public bool ExecuteNonQueryFromSpETEL_DESTReturnStatus(string spName, SqlCommand cmd)
            {
                try
                {
                    ReadyConnectionconETEL_DEST();
                    cmd.CommandText = spName;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conETEL_DEST;
                    cmd.CommandTimeout = 0;
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                        return true;
                    else
                        return false;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    CloseConnectionETEL_DEST();
                }
            }


            public string GetStringFromSQLETEL_DEST(string sSQL, string coulmnName)
            {
                try
                {
                    string result = String.Empty;
                    ReadyConnectionconETEL_DEST();
                    SqlCommand cmd = new SqlCommand(sSQL, conETEL_DEST);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        result = reader["" + coulmnName + ""].ToString();
                    }
                    return result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    CloseConnectionETEL_DEST();
                }
            }

            public bool ExecuteNonQueryFromSQLETEL_DEST(string sSQL)
            {
                try
                {
                    ReadyConnectionconETEL_DEST();
                    SqlCommand cmd = new SqlCommand(sSQL, conETEL_DEST);
                    cmd.CommandTimeout = 0;
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    CloseConnectionETEL_DEST();
                }

            }

            public bool ExecuteNonQueryFromSQLETEL_DESTReturnStatus(string sSQL)
            {
                try
                {
                    ReadyConnectionconETEL_DEST();
                    SqlCommand cmd = new SqlCommand(sSQL, conETEL_DEST);
                    cmd.CommandTimeout = 0;
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    CloseConnectionETEL_DEST();
                }

            }

            public DataTable GetDataTableFromSQLERP(string sSQL)
            {
                DataTable dataTable = new DataTable();
                try
                {
                    ReadyConnectionERP();

                    SqlCommand cmd = new SqlCommand(sSQL, conERP);
                    cmd.CommandTimeout = 0;
                    dataTable.Load(cmd.ExecuteReader());
                    return dataTable;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    CloseConnectionERP();
                }
            }

            //public DataTable GetDataTableFromSQLPay(string sSQL)
            //{
            //    DataTable dataTable = new DataTable();
            //    try
            //    {
            //        ReadyConnectionPay();
            //        SqlCommand cmd = new SqlCommand(sSQL, conPay);
            //        dataTable.Load(cmd.ExecuteReader());
            //        return dataTable;

            //    }
            //    catch (Exception ex)
            //    {
            //        throw ex;
            //    }
            //    finally
            //    {
            //        CloseConnectionPay();
            //    }
            //}

            public DataTable GetDataTableFromSpETEL_DEST(string spName, SqlCommand cmd)
            {
                try
                {
                    DataTable dt = new DataTable();
                    ReadyConnectionconETEL_DEST();
                    cmd.CommandText = spName;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conETEL_DEST;
                    cmd.CommandTimeout = 0;
                    dt.Load(cmd.ExecuteReader());
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    CloseConnectionETEL_DEST();
                }
            }

            public DataTable GetDataTableFromSQLETEL_DESTTran(string sSQL, SqlConnection con, SqlTransaction tran)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(sSQL, con, tran);
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public DataTable GetDataTableFromSQLERPTran(string sSQL, SqlConnection con, SqlTransaction tran)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(sSQL, con, tran);
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public bool ExecuteNonQueryFromSpETEL_DESTReturnStatus(string spName, SqlCommand cmd, SqlConnection con, SqlTransaction tran)
            {
                try
                {

                    cmd.CommandText = spName;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    cmd.Transaction = tran;
                    cmd.CommandTimeout = 0;
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                        return true;
                    else
                        return false;

                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }

            public void ExecuteNonQueryFromSpETEL_DEST(string spName, SqlCommand cmd, SqlConnection con, SqlTransaction tran)
            {
                try
                {
                    ReadyConnectionconETEL_DEST();
                    cmd.CommandText = spName;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    cmd.Transaction = tran;
                    cmd.CommandTimeout = 0;
                    int count = cmd.ExecuteNonQuery();
                    //if (count > 0)
                    //    return true;
                    //else
                    //    return false;

                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }

            public bool ExecuteNonQueryFromSpERP(string spName, SqlCommand cmd, SqlConnection cn, SqlTransaction tran)
            {
                try
                {
                    //ReadyConnectionconERP();
                    cmd.CommandText = spName;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.Transaction = tran;
                    cmd.CommandTimeout = 0;
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                        return true;
                    else
                        return false;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                //finally
                //{
                //    CloseConnectionERP();
                //}
            }

            public bool ExecuteNonQueryFromSpERPTran(string spName, SqlCommand cmd, SqlConnection cn, SqlTransaction tran)
            {
                try
                {
                    cmd.CommandText = spName;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.Transaction = tran;
                    cmd.CommandTimeout = 0;
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public bool ExecuteNonQueryFromSQLERPReturnStatus(string sSQL, SqlConnection cn, SqlTransaction tran)
            {
                try
                {
                    // ReadyConnectionconETEL_DEST();
                    SqlCommand cmd = new SqlCommand(sSQL, cn, tran);
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                //finally
                //{
                //    CloseConnectionETEL_DEST();
                //}

            }

            public bool ExecuteNonQueryFromSQLETEL_DESTReturnStatus(string sSQL, SqlConnection cn, SqlTransaction tran)
            {
                try
                {
                    ReadyConnectionconETEL_DEST();
                    SqlCommand cmd = new SqlCommand(sSQL, cn, tran);
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    //CloseConnectionETEL_DEST();
                }

            }


            public void ExecuteNonQueryFromSQLERP(string sSQL)
            {
                try
                {
                    ReadyConnectionconERP();
                    SqlCommand cmd = new SqlCommand(sSQL, conERP);
                    int count = cmd.ExecuteNonQuery();
                    //if (count > 0)
                    //    return true;
                    //else
                    //    return false;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    CloseConnectionERP();
                }

            }
        }
    }
