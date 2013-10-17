using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace littleworld.DAL
{
	/// <summary>
	/// 数据访问类:adminTb
	/// </summary>
	public partial class adminTb
	{
		public adminTb()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("adminID", "adminTb"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int adminID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from adminTb");
			strSql.Append(" where adminID=@adminID");
			SqlParameter[] parameters = {
					new SqlParameter("@adminID", SqlDbType.Int,4)
};
			parameters[0].Value = adminID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(littleworld.Model.adminTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into adminTb(");
			strSql.Append("adminName,adminPwd,adminEmail,adminLevel)");
			strSql.Append(" values (");
			strSql.Append("@adminName,@adminPwd,@adminEmail,@adminLevel)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@adminName", SqlDbType.NVarChar,50),
					new SqlParameter("@adminPwd", SqlDbType.VarChar,50),
					new SqlParameter("@adminEmail", SqlDbType.NVarChar,50),
					new SqlParameter("@adminLevel", SqlDbType.Int,4)};
			parameters[0].Value = model.adminName;
			parameters[1].Value = model.adminPwd;
			parameters[2].Value = model.adminEmail;
			parameters[3].Value = model.adminLevel;

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
		public bool Update(littleworld.Model.adminTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update adminTb set ");
			strSql.Append("adminName=@adminName,");
			strSql.Append("adminPwd=@adminPwd,");
			strSql.Append("adminEmail=@adminEmail,");
			strSql.Append("adminLevel=@adminLevel");
			strSql.Append(" where adminID=@adminID");
			SqlParameter[] parameters = {
					new SqlParameter("@adminName", SqlDbType.NVarChar,50),
					new SqlParameter("@adminPwd", SqlDbType.VarChar,50),
					new SqlParameter("@adminEmail", SqlDbType.NVarChar,50),
					new SqlParameter("@adminLevel", SqlDbType.Int,4),
					new SqlParameter("@adminID", SqlDbType.Int,4)};
			parameters[0].Value = model.adminName;
			parameters[1].Value = model.adminPwd;
			parameters[2].Value = model.adminEmail;
			parameters[3].Value = model.adminLevel;
			parameters[4].Value = model.adminID;

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
		public bool Delete(int adminID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from adminTb ");
			strSql.Append(" where adminID=@adminID");
			SqlParameter[] parameters = {
					new SqlParameter("@adminID", SqlDbType.Int,4)
};
			parameters[0].Value = adminID;

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
		public bool DeleteList(string adminIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from adminTb ");
			strSql.Append(" where adminID in ("+adminIDlist + ")  ");
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
		public littleworld.Model.adminTb GetModel(int adminID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 adminID,adminName,adminPwd,adminEmail,adminLevel from adminTb ");
			strSql.Append(" where adminID=@adminID");
			SqlParameter[] parameters = {
					new SqlParameter("@adminID", SqlDbType.Int,4)
};
			parameters[0].Value = adminID;

			littleworld.Model.adminTb model=new littleworld.Model.adminTb();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["adminID"]!=null && ds.Tables[0].Rows[0]["adminID"].ToString()!="")
				{
					model.adminID=int.Parse(ds.Tables[0].Rows[0]["adminID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["adminName"]!=null && ds.Tables[0].Rows[0]["adminName"].ToString()!="")
				{
					model.adminName=ds.Tables[0].Rows[0]["adminName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["adminPwd"]!=null && ds.Tables[0].Rows[0]["adminPwd"].ToString()!="")
				{
					model.adminPwd=ds.Tables[0].Rows[0]["adminPwd"].ToString();
				}
				if(ds.Tables[0].Rows[0]["adminEmail"]!=null && ds.Tables[0].Rows[0]["adminEmail"].ToString()!="")
				{
					model.adminEmail=ds.Tables[0].Rows[0]["adminEmail"].ToString();
				}
				if(ds.Tables[0].Rows[0]["adminLevel"]!=null && ds.Tables[0].Rows[0]["adminLevel"].ToString()!="")
				{
					model.adminLevel=int.Parse(ds.Tables[0].Rows[0]["adminLevel"].ToString());
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
			strSql.Append("select adminID,adminName,adminPwd,adminEmail,adminLevel ");
			strSql.Append(" FROM adminTb ");
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
			strSql.Append(" adminID,adminName,adminPwd,adminEmail,adminLevel ");
			strSql.Append(" FROM adminTb ");
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
			parameters[0].Value = "adminTb";
			parameters[1].Value = "adminID";
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

