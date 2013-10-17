using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace littleworld.DAL
{
	/// <summary>
	/// 数据访问类:reportTypeTb
	/// </summary>
	public partial class reportTypeTb
	{
		public reportTypeTb()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("reportTypeID", "reportTypeTb"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int reportTypeID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from reportTypeTb");
			strSql.Append(" where reportTypeID=@reportTypeID");
			SqlParameter[] parameters = {
					new SqlParameter("@reportTypeID", SqlDbType.Int,4)
};
			parameters[0].Value = reportTypeID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(littleworld.Model.reportTypeTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into reportTypeTb(");
			strSql.Append("reportTypeName)");
			strSql.Append(" values (");
			strSql.Append("@reportTypeName)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@reportTypeName", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.reportTypeName;

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
		public bool Update(littleworld.Model.reportTypeTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update reportTypeTb set ");
			strSql.Append("reportTypeName=@reportTypeName");
			strSql.Append(" where reportTypeID=@reportTypeID");
			SqlParameter[] parameters = {
					new SqlParameter("@reportTypeName", SqlDbType.NVarChar,50),
					new SqlParameter("@reportTypeID", SqlDbType.Int,4)};
			parameters[0].Value = model.reportTypeName;
			parameters[1].Value = model.reportTypeID;

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
		public bool Delete(int reportTypeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from reportTypeTb ");
			strSql.Append(" where reportTypeID=@reportTypeID");
			SqlParameter[] parameters = {
					new SqlParameter("@reportTypeID", SqlDbType.Int,4)
};
			parameters[0].Value = reportTypeID;

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
		public bool DeleteList(string reportTypeIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from reportTypeTb ");
			strSql.Append(" where reportTypeID in ("+reportTypeIDlist + ")  ");
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
		public littleworld.Model.reportTypeTb GetModel(int reportTypeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 reportTypeID,reportTypeName from reportTypeTb ");
			strSql.Append(" where reportTypeID=@reportTypeID");
			SqlParameter[] parameters = {
					new SqlParameter("@reportTypeID", SqlDbType.Int,4)
};
			parameters[0].Value = reportTypeID;

			littleworld.Model.reportTypeTb model=new littleworld.Model.reportTypeTb();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["reportTypeID"]!=null && ds.Tables[0].Rows[0]["reportTypeID"].ToString()!="")
				{
					model.reportTypeID=int.Parse(ds.Tables[0].Rows[0]["reportTypeID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["reportTypeName"]!=null && ds.Tables[0].Rows[0]["reportTypeName"].ToString()!="")
				{
					model.reportTypeName=ds.Tables[0].Rows[0]["reportTypeName"].ToString();
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
			strSql.Append("select reportTypeID,reportTypeName ");
			strSql.Append(" FROM reportTypeTb ");
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
			strSql.Append(" reportTypeID,reportTypeName ");
			strSql.Append(" FROM reportTypeTb ");
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
			parameters[0].Value = "reportTypeTb";
			parameters[1].Value = "reportTypeID";
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

