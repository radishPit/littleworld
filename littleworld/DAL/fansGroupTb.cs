using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace littleworld.DAL
{
	/// <summary>
	/// 数据访问类:fansGroupTb
	/// </summary>
	public partial class fansGroupTb
	{
		public fansGroupTb()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("fansGroupID", "fansGroupTb"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int fansGroupID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from fansGroupTb");
			strSql.Append(" where fansGroupID=@fansGroupID");
			SqlParameter[] parameters = {
					new SqlParameter("@fansGroupID", SqlDbType.Int,4)
};
			parameters[0].Value = fansGroupID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(littleworld.Model.fansGroupTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into fansGroupTb(");
			strSql.Append("groupName,createTime)");
			strSql.Append(" values (");
			strSql.Append("@groupName,@createTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@groupName", SqlDbType.NVarChar,50),
					new SqlParameter("@createTime", SqlDbType.DateTime)};
			parameters[0].Value = model.groupName;
			parameters[1].Value = model.createTime;

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
		public bool Update(littleworld.Model.fansGroupTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update fansGroupTb set ");
			strSql.Append("groupName=@groupName,");
			strSql.Append("createTime=@createTime");
			strSql.Append(" where fansGroupID=@fansGroupID");
			SqlParameter[] parameters = {
					new SqlParameter("@groupName", SqlDbType.NVarChar,50),
					new SqlParameter("@createTime", SqlDbType.DateTime),
					new SqlParameter("@fansGroupID", SqlDbType.Int,4)};
			parameters[0].Value = model.groupName;
			parameters[1].Value = model.createTime;
			parameters[2].Value = model.fansGroupID;

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
		public bool Delete(int fansGroupID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from fansGroupTb ");
			strSql.Append(" where fansGroupID=@fansGroupID");
			SqlParameter[] parameters = {
					new SqlParameter("@fansGroupID", SqlDbType.Int,4)
};
			parameters[0].Value = fansGroupID;

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
		public bool DeleteList(string fansGroupIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from fansGroupTb ");
			strSql.Append(" where fansGroupID in ("+fansGroupIDlist + ")  ");
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
		public littleworld.Model.fansGroupTb GetModel(int fansGroupID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 fansGroupID,groupName,createTime from fansGroupTb ");
			strSql.Append(" where fansGroupID=@fansGroupID");
			SqlParameter[] parameters = {
					new SqlParameter("@fansGroupID", SqlDbType.Int,4)
};
			parameters[0].Value = fansGroupID;

			littleworld.Model.fansGroupTb model=new littleworld.Model.fansGroupTb();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["fansGroupID"]!=null && ds.Tables[0].Rows[0]["fansGroupID"].ToString()!="")
				{
					model.fansGroupID=int.Parse(ds.Tables[0].Rows[0]["fansGroupID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["groupName"]!=null && ds.Tables[0].Rows[0]["groupName"].ToString()!="")
				{
					model.groupName=ds.Tables[0].Rows[0]["groupName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["createTime"]!=null && ds.Tables[0].Rows[0]["createTime"].ToString()!="")
				{
					model.createTime=DateTime.Parse(ds.Tables[0].Rows[0]["createTime"].ToString());
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
			strSql.Append("select fansGroupID,groupName,createTime ");
			strSql.Append(" FROM fansGroupTb ");
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
			strSql.Append(" fansGroupID,groupName,createTime ");
			strSql.Append(" FROM fansGroupTb ");
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
			parameters[0].Value = "fansGroupTb";
			parameters[1].Value = "fansGroupID";
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

