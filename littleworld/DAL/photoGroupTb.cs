using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace littleworld.DAL
{
	/// <summary>
	/// 数据访问类:photoGroupTb
	/// </summary>
	public partial class photoGroupTb
	{
		public photoGroupTb()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("photoGroupID", "photoGroupTb"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int photoGroupID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from photoGroupTb");
			strSql.Append(" where photoGroupID=@photoGroupID");
			SqlParameter[] parameters = {
					new SqlParameter("@photoGroupID", SqlDbType.Int,4)
};
			parameters[0].Value = photoGroupID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(littleworld.Model.photoGroupTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into photoGroupTb(");
			strSql.Append("groupName,ownID)");
			strSql.Append(" values (");
			strSql.Append("@groupName,@ownID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@groupName", SqlDbType.NVarChar,50),
					new SqlParameter("@ownID", SqlDbType.Int,4)};
			parameters[0].Value = model.groupName;
			parameters[1].Value = model.ownID;

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
		public bool Update(littleworld.Model.photoGroupTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update photoGroupTb set ");
			strSql.Append("groupName=@groupName,");
			strSql.Append("ownID=@ownID");
			strSql.Append(" where photoGroupID=@photoGroupID");
			SqlParameter[] parameters = {
					new SqlParameter("@groupName", SqlDbType.NVarChar,50),
					new SqlParameter("@ownID", SqlDbType.Int,4),
					new SqlParameter("@photoGroupID", SqlDbType.Int,4)};
			parameters[0].Value = model.groupName;
			parameters[1].Value = model.ownID;
			parameters[2].Value = model.photoGroupID;

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
		public bool Delete(int photoGroupID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from photoGroupTb ");
			strSql.Append(" where photoGroupID=@photoGroupID");
			SqlParameter[] parameters = {
					new SqlParameter("@photoGroupID", SqlDbType.Int,4)
};
			parameters[0].Value = photoGroupID;

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
		public bool DeleteList(string photoGroupIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from photoGroupTb ");
			strSql.Append(" where photoGroupID in ("+photoGroupIDlist + ")  ");
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
		public littleworld.Model.photoGroupTb GetModel(int photoGroupID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 photoGroupID,groupName,ownID from photoGroupTb ");
			strSql.Append(" where photoGroupID=@photoGroupID");
			SqlParameter[] parameters = {
					new SqlParameter("@photoGroupID", SqlDbType.Int,4)
};
			parameters[0].Value = photoGroupID;

			littleworld.Model.photoGroupTb model=new littleworld.Model.photoGroupTb();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["photoGroupID"]!=null && ds.Tables[0].Rows[0]["photoGroupID"].ToString()!="")
				{
					model.photoGroupID=int.Parse(ds.Tables[0].Rows[0]["photoGroupID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["groupName"]!=null && ds.Tables[0].Rows[0]["groupName"].ToString()!="")
				{
					model.groupName=ds.Tables[0].Rows[0]["groupName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ownID"]!=null && ds.Tables[0].Rows[0]["ownID"].ToString()!="")
				{
					model.ownID=int.Parse(ds.Tables[0].Rows[0]["ownID"].ToString());
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
			strSql.Append("select photoGroupID,groupName,ownID ");
			strSql.Append(" FROM photoGroupTb ");
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
			strSql.Append(" photoGroupID,groupName,ownID ");
			strSql.Append(" FROM photoGroupTb ");
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
			parameters[0].Value = "photoGroupTb";
			parameters[1].Value = "photoGroupID";
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

