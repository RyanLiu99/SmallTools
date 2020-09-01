using System.Data;
using MySQLDriverCS;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.Remoting;
using System.Reflection;
using System.Diagnostics;
using System.IO;
using System.Text;
using MySql.Data;


namespace Org.RyanLiu.SmallTools
{
	/// <summary>
	/// Summary description for DbUtil2.
	/// </summary>
	public class DbUtil
	{
		public DbUtil()
		{
			//
			// TODO: Add constructor logic here
			//
		}


		public static int ExecNoQuery(string sqlStr, IDbConnection dbCon) 
		{
			return ExecNoQuery( sqlStr,  dbCon,  null) ;
		}

		/// <summary>
		/// exec a sql statement which has no reutnr query, e.g. for update or delte
		/// It is similar to NoQuerySqlCmd(..)
		/// </summary>
		/// <param name="sqlStr"></param>
		/// <param name="dbCon"></param>
		/// <returns></returns>
		public static int ExecNoQuery(string sqlStr, IDbConnection dbCon, IDbTransaction myTrans) 
		{	
			
			IDbCommand cmd=null;

			Debug.WriteLine (sqlStr);

			try
			{
				
				cmd = dbCon.CreateCommand();
				cmd.CommandText = sqlStr;
				if( myTrans != null ) cmd.Transaction = myTrans; 
				return cmd.ExecuteNonQuery();
			
			}
			finally 
			{
				if(cmd !=null) cmd.Dispose();
				
			}
		}

		/// <summary>
		/// get values in the first column, and concatnate it as "v1,v2", if the value is null, it is skipped
		/// </summary>
		/// <param name="sqlStr">Note, it must have one field in select cause</param>
		/// <returns>concatnated string of first column, or empty string</returns>
		public static string GetOneColumnValues(string sqlStr, IDbConnection dbCon)
		{
			
			IDbCommand cmd=null;

			StringBuilder sb = new StringBuilder();

			
			cmd = dbCon.CreateCommand();
			cmd.CommandText = sqlStr;
			IDataReader dataReader= cmd.ExecuteReader();

			while(dataReader.Read())
			{
				//sb.Append(dataReader.GetInt32(0) + ",");
				if( !dataReader.IsDBNull(0)) sb.Append( dataReader.GetString(0) + ",");
			}
			dataReader.Close();

			if(sb.Length >1) sb.Length = sb.Length -1; //take last ","  out
			
		
			return sb.ToString();

		}
	}
}
