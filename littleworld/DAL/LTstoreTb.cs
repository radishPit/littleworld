using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace littleworld.DAL
{
	/// <summary>
	/// 数据访问类:LTstoreTb
	/// </summary>
	public partial class LTstoreTb
	{
		public LTstoreTb()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "LTstoreTb"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from LTstoreTb");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(littleworld.Model.LTstoreTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into LTstoreTb(");
			strSql.Append("noteID,storerID,storeTime,state,cause)");
			strSql.Append(" values (");
			strSql.Append("@noteID,@storerID,@storeTime,@state,@cause)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@noteID", SqlDbType.Int,4),
					new SqlParameter("@storerID", SqlDbType.Int,4),
					new SqlParameter("@storeTime", SqlDbType.DateTime),
					new SqlParameter("@state", SqlDbType.Int,4),
					new SqlParameter("@cause", SqlDbType.NVarChar,300)};
			parameters[0].Value = model.noteID;
			parameters[1].Value = model.storerID;
			parameters[2].Value = model.storeTime;
			parameters[3].Value = model.state;
			parameters[4].Value = model.cause;

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
		public bool Update(littleworld.Model.LTstoreTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update LTstoreTb set ");
			strSql.Append("noteID=@noteID,");
			strSql.Append("storerID=@storerID,");
			strSql.Append("storeTime=@storeTime,");
			strSql.Append("state=@state,");
			strSql.Append("cause=@cause");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@noteID", SqlDbType.Int,4),
					new SqlParameter("@storerID", SqlDbType.Int,4),
					new SqlParameter("@storeTime", SqlDbType.DateTime),
					new SqlParameter("@state", SqlDbType.Int,4),
					new SqlParameter("@cause", SqlDbType.NVarChar,300),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.noteID;
			parameters[1].Value = model.storerID;
			parameters[2].Value = model.storeTime;
			parameters[3].Value = model.state;
			parameters[4].Value = model.cause;
			parameters[5].Value = model.ID;

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
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from LTstoreTb ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from LTstoreTb ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
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
		public littleworld.Model.LTstoreTb GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,noteID,storerID,storeTime,state,cause from LTstoreTb ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			littleworld.Model.LTstoreTb model=new littleworld.Model.LTstoreTb();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["noteID"]!=null && ds.Tables[0].Rows[0]["noteID"].ToString()!="")
				{
					model.noteID=int.Parse(ds.Tables[0].Rows[0]["noteID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["storerID"]!=null && ds.Tables[0].Rows[0]["storerID"].ToString()!="")
				{
					model.storerID=int.Parse(ds.Tables[0].Rows[0]["storerID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["storeTime"]!=null && ds.Tables[0].Rows[0]["storeTime"].ToString()!="")
				{
					model.storeTime=DateTime.Parse(ds.Tables[0].Rows[0]["storeTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["state"]!=null && ds.Tables[0].Rows[0]["state"].ToString()!="")
				{
					model.state=int.Parse(ds.Tables[0].Rows[0]["state"].ToString());
				}
				if(ds.Tables[0].Rows[0]["cause"]!=null && ds.Tables[0].Rows[0]["cause"].ToString()!="")
				{
					model.cause=ds.Tables[0].Rows[0]["cause"].ToString();
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
			strSql.Append("select ID,noteID,storerID,storeTime,state,cause ");
			strSql.Append(" FROM LTstoreTb ");
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
			strSql.Append(" ID,noteID,storerID,storeTime,state,cause ");
			strSql.Append(" FROM LTstoreTb ");
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
			parameters[0].Value = "LTstoreTb";
			parameters[1].Value = "ID";
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

