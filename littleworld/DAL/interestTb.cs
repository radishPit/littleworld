using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace littleworld.DAL
{
	/// <summary>
	/// 数据访问类:interestTb
	/// </summary>
	public partial class interestTb
	{
		public interestTb()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("interestID", "interestTb"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int interestID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from interestTb");
			strSql.Append(" where interestID=@interestID");
			SqlParameter[] parameters = {
					new SqlParameter("@interestID", SqlDbType.Int,4)
};
			parameters[0].Value = interestID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(littleworld.Model.interestTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into interestTb(");
			strSql.Append("interestName)");
			strSql.Append(" values (");
			strSql.Append("@interestName)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@interestName", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.interestName;

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
		public bool Update(littleworld.Model.interestTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update interestTb set ");
			strSql.Append("interestName=@interestName");
			strSql.Append(" where interestID=@interestID");
			SqlParameter[] parameters = {
					new SqlParameter("@interestName", SqlDbType.NVarChar,50),
					new SqlParameter("@interestID", SqlDbType.Int,4)};
			parameters[0].Value = model.interestName;
			parameters[1].Value = model.interestID;

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
		public bool Delete(int interestID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from interestTb ");
			strSql.Append(" where interestID=@interestID");
			SqlParameter[] parameters = {
					new SqlParameter("@interestID", SqlDbType.Int,4)
};
			parameters[0].Value = interestID;

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
		public bool DeleteList(string interestIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from interestTb ");
			strSql.Append(" where interestID in ("+interestIDlist + ")  ");
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
		public littleworld.Model.interestTb GetModel(int interestID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 interestID,interestName from interestTb ");
			strSql.Append(" where interestID=@interestID");
			SqlParameter[] parameters = {
					new SqlParameter("@interestID", SqlDbType.Int,4)
};
			parameters[0].Value = interestID;

			littleworld.Model.interestTb model=new littleworld.Model.interestTb();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["interestID"]!=null && ds.Tables[0].Rows[0]["interestID"].ToString()!="")
				{
					model.interestID=int.Parse(ds.Tables[0].Rows[0]["interestID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["interestName"]!=null && ds.Tables[0].Rows[0]["interestName"].ToString()!="")
				{
					model.interestName=ds.Tables[0].Rows[0]["interestName"].ToString();
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
			strSql.Append("select interestID,interestName ");
			strSql.Append(" FROM interestTb ");
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
			strSql.Append(" interestID,interestName ");
			strSql.Append(" FROM interestTb ");
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
			parameters[0].Value = "interestTb";
			parameters[1].Value = "interestID";
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

