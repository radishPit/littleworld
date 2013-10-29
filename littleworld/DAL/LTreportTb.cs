using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace littleworld.DAL
{
	/// <summary>
	/// 数据访问类:LTreportTb
	/// </summary>
	public partial class LTreportTb
	{
		public LTreportTb()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "LTreportTb"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from LTreportTb");
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
		public int Add(littleworld.Model.LTreportTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into LTreportTb(");
			strSql.Append("noteId,NreporterID,NreportTime,NreportTypeID,state)");
			strSql.Append(" values (");
			strSql.Append("@noteId,@NreporterID,@NreportTime,@NreportTypeID,@state)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@noteId", SqlDbType.Int,4),
					new SqlParameter("@NreporterID", SqlDbType.Int,4),
					new SqlParameter("@NreportTime", SqlDbType.DateTime),
					new SqlParameter("@NreportTypeID", SqlDbType.Int,4),
					new SqlParameter("@state", SqlDbType.Int,4)};
			parameters[0].Value = model.noteId;
			parameters[1].Value = model.NreporterID;
			parameters[2].Value = model.NreportTime;
			parameters[3].Value = model.NreportTypeID;
			parameters[4].Value = model.state;

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
		public bool Update(littleworld.Model.LTreportTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update LTreportTb set ");
			strSql.Append("noteId=@noteId,");
			strSql.Append("NreporterID=@NreporterID,");
			strSql.Append("NreportTime=@NreportTime,");
			strSql.Append("NreportTypeID=@NreportTypeID,");
			strSql.Append("state=@state");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@noteId", SqlDbType.Int,4),
					new SqlParameter("@NreporterID", SqlDbType.Int,4),
					new SqlParameter("@NreportTime", SqlDbType.DateTime),
					new SqlParameter("@NreportTypeID", SqlDbType.Int,4),
					new SqlParameter("@state", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.noteId;
			parameters[1].Value = model.NreporterID;
			parameters[2].Value = model.NreportTime;
			parameters[3].Value = model.NreportTypeID;
			parameters[4].Value = model.state;
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
			strSql.Append("delete from LTreportTb ");
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
			strSql.Append("delete from LTreportTb ");
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
		public littleworld.Model.LTreportTb GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,noteId,NreporterID,NreportTime,NreportTypeID,state from LTreportTb ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			littleworld.Model.LTreportTb model=new littleworld.Model.LTreportTb();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["noteId"]!=null && ds.Tables[0].Rows[0]["noteId"].ToString()!="")
				{
					model.noteId=int.Parse(ds.Tables[0].Rows[0]["noteId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["NreporterID"]!=null && ds.Tables[0].Rows[0]["NreporterID"].ToString()!="")
				{
					model.NreporterID=int.Parse(ds.Tables[0].Rows[0]["NreporterID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["NreportTime"]!=null && ds.Tables[0].Rows[0]["NreportTime"].ToString()!="")
				{
					model.NreportTime=DateTime.Parse(ds.Tables[0].Rows[0]["NreportTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["NreportTypeID"]!=null && ds.Tables[0].Rows[0]["NreportTypeID"].ToString()!="")
				{
					model.NreportTypeID=int.Parse(ds.Tables[0].Rows[0]["NreportTypeID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["state"]!=null && ds.Tables[0].Rows[0]["state"].ToString()!="")
				{
					model.state=int.Parse(ds.Tables[0].Rows[0]["state"].ToString());
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
			strSql.Append("select ID,noteId,NreporterID,NreportTime,NreportTypeID,state ");
			strSql.Append(" FROM LTreportTb ");
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
			strSql.Append(" ID,noteId,NreporterID,NreportTime,NreportTypeID,state ");
			strSql.Append(" FROM LTreportTb ");
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
			parameters[0].Value = "LTreportTb";
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

