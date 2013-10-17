using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace littleworld.DAL
{
	/// <summary>
	/// 数据访问类:noveltyGroupTb
	/// </summary>
	public partial class noveltyGroupTb
	{
		public noveltyGroupTb()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("noveltyGroupID", "noveltyGroupTb"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int noveltyGroupID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from noveltyGroupTb");
			strSql.Append(" where noveltyGroupID=@noveltyGroupID");
			SqlParameter[] parameters = {
					new SqlParameter("@noveltyGroupID", SqlDbType.Int,4)
};
			parameters[0].Value = noveltyGroupID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(littleworld.Model.noveltyGroupTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into noveltyGroupTb(");
			strSql.Append("noveltyGroupName)");
			strSql.Append(" values (");
			strSql.Append("@noveltyGroupName)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@noveltyGroupName", SqlDbType.NVarChar,500)};
			parameters[0].Value = model.noveltyGroupName;

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
		public bool Update(littleworld.Model.noveltyGroupTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update noveltyGroupTb set ");
			strSql.Append("noveltyGroupName=@noveltyGroupName");
			strSql.Append(" where noveltyGroupID=@noveltyGroupID");
			SqlParameter[] parameters = {
					new SqlParameter("@noveltyGroupName", SqlDbType.NVarChar,500),
					new SqlParameter("@noveltyGroupID", SqlDbType.Int,4)};
			parameters[0].Value = model.noveltyGroupName;
			parameters[1].Value = model.noveltyGroupID;

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
		public bool Delete(int noveltyGroupID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from noveltyGroupTb ");
			strSql.Append(" where noveltyGroupID=@noveltyGroupID");
			SqlParameter[] parameters = {
					new SqlParameter("@noveltyGroupID", SqlDbType.Int,4)
};
			parameters[0].Value = noveltyGroupID;

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
		public bool DeleteList(string noveltyGroupIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from noveltyGroupTb ");
			strSql.Append(" where noveltyGroupID in ("+noveltyGroupIDlist + ")  ");
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
		public littleworld.Model.noveltyGroupTb GetModel(int noveltyGroupID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 noveltyGroupID,noveltyGroupName from noveltyGroupTb ");
			strSql.Append(" where noveltyGroupID=@noveltyGroupID");
			SqlParameter[] parameters = {
					new SqlParameter("@noveltyGroupID", SqlDbType.Int,4)
};
			parameters[0].Value = noveltyGroupID;

			littleworld.Model.noveltyGroupTb model=new littleworld.Model.noveltyGroupTb();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["noveltyGroupID"]!=null && ds.Tables[0].Rows[0]["noveltyGroupID"].ToString()!="")
				{
					model.noveltyGroupID=int.Parse(ds.Tables[0].Rows[0]["noveltyGroupID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["noveltyGroupName"]!=null && ds.Tables[0].Rows[0]["noveltyGroupName"].ToString()!="")
				{
					model.noveltyGroupName=ds.Tables[0].Rows[0]["noveltyGroupName"].ToString();
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
			strSql.Append("select noveltyGroupID,noveltyGroupName ");
			strSql.Append(" FROM noveltyGroupTb ");
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
			strSql.Append(" noveltyGroupID,noveltyGroupName ");
			strSql.Append(" FROM noveltyGroupTb ");
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
			parameters[0].Value = "noveltyGroupTb";
			parameters[1].Value = "noveltyGroupID";
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

