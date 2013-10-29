using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace littleworld.DAL
{
	/// <summary>
	/// 数据访问类:LTreportTypeTb
	/// </summary>
	public partial class LTreportTypeTb
	{
		public LTreportTypeTb()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("NreporterID", "LTreportTypeTb"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int NreporterID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from LTreportTypeTb");
			strSql.Append(" where NreporterID=@NreporterID");
			SqlParameter[] parameters = {
					new SqlParameter("@NreporterID", SqlDbType.Int,4)
};
			parameters[0].Value = NreporterID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(littleworld.Model.LTreportTypeTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into LTreportTypeTb(");
			strSql.Append("NreporterName)");
			strSql.Append(" values (");
			strSql.Append("@NreporterName)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@NreporterName", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.NreporterName;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(littleworld.Model.LTreportTypeTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update LTreportTypeTb set ");
			strSql.Append("NreporterName=@NreporterName");
			strSql.Append(" where NreporterID=@NreporterID");
			SqlParameter[] parameters = {
					new SqlParameter("@NreporterName", SqlDbType.NVarChar,50),
					new SqlParameter("@NreporterID", SqlDbType.Int,4)};
			parameters[0].Value = model.NreporterName;
			parameters[1].Value = model.NreporterID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int NreporterID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from LTreportTypeTb ");
			strSql.Append(" where NreporterID=@NreporterID");
			SqlParameter[] parameters = {
					new SqlParameter("@NreporterID", SqlDbType.Int,4)
};
			parameters[0].Value = NreporterID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string NreporterIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from LTreportTypeTb ");
			strSql.Append(" where NreporterID in ("+NreporterIDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public littleworld.Model.LTreportTypeTb GetModel(int NreporterID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 NreporterID,NreporterName from LTreportTypeTb ");
			strSql.Append(" where NreporterID=@NreporterID");
			SqlParameter[] parameters = {
					new SqlParameter("@NreporterID", SqlDbType.Int,4)
};
			parameters[0].Value = NreporterID;

			littleworld.Model.LTreportTypeTb model=new littleworld.Model.LTreportTypeTb();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["NreporterID"]!=null && ds.Tables[0].Rows[0]["NreporterID"].ToString()!="")
				{
					model.NreporterID=int.Parse(ds.Tables[0].Rows[0]["NreporterID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["NreporterName"]!=null && ds.Tables[0].Rows[0]["NreporterName"].ToString()!="")
				{
					model.NreporterName=ds.Tables[0].Rows[0]["NreporterName"].ToString();
				}
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select NreporterID,NreporterName ");
			strSql.Append(" FROM LTreportTypeTb ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" NreporterID,NreporterName ");
			strSql.Append(" FROM LTreportTypeTb ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "LTreportTypeTb";
			parameters[1].Value = "NreporterID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}

