using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace littleworld.DAL
{
	/// <summary>
	/// 数据访问类:reportTb
	/// </summary>
	public partial class reportTb
	{
		public reportTb()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "reportTb"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from reportTb");
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
		public int Add(littleworld.Model.reportTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into reportTb(");
			strSql.Append("noveltyID,reporterID,reportTime,reportTypeID,state)");
			strSql.Append(" values (");
			strSql.Append("@noveltyID,@reporterID,@reportTime,@reportTypeID,@state)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@noveltyID", SqlDbType.Int,4),
					new SqlParameter("@reporterID", SqlDbType.Int,4),
					new SqlParameter("@reportTime", SqlDbType.DateTime),
					new SqlParameter("@reportTypeID", SqlDbType.Int,4),
					new SqlParameter("@state", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.noveltyID;
			parameters[1].Value = model.reporterID;
			parameters[2].Value = model.reportTime;
			parameters[3].Value = model.reportTypeID;
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
		public bool Update(littleworld.Model.reportTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update reportTb set ");
			strSql.Append("noveltyID=@noveltyID,");
			strSql.Append("reporterID=@reporterID,");
			strSql.Append("reportTime=@reportTime,");
			strSql.Append("reportTypeID=@reportTypeID,");
			strSql.Append("state=@state");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@noveltyID", SqlDbType.Int,4),
					new SqlParameter("@reporterID", SqlDbType.Int,4),
					new SqlParameter("@reportTime", SqlDbType.DateTime),
					new SqlParameter("@reportTypeID", SqlDbType.Int,4),
					new SqlParameter("@state", SqlDbType.NVarChar,50),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.noveltyID;
			parameters[1].Value = model.reporterID;
			parameters[2].Value = model.reportTime;
			parameters[3].Value = model.reportTypeID;
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
			strSql.Append("delete from reportTb ");
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
			strSql.Append("delete from reportTb ");
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
		public littleworld.Model.reportTb GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,noveltyID,reporterID,reportTime,reportTypeID,state from reportTb ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			littleworld.Model.reportTb model=new littleworld.Model.reportTb();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["noveltyID"]!=null && ds.Tables[0].Rows[0]["noveltyID"].ToString()!="")
				{
					model.noveltyID=int.Parse(ds.Tables[0].Rows[0]["noveltyID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["reporterID"]!=null && ds.Tables[0].Rows[0]["reporterID"].ToString()!="")
				{
					model.reporterID=int.Parse(ds.Tables[0].Rows[0]["reporterID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["reportTime"]!=null && ds.Tables[0].Rows[0]["reportTime"].ToString()!="")
				{
					model.reportTime=DateTime.Parse(ds.Tables[0].Rows[0]["reportTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["reportTypeID"]!=null && ds.Tables[0].Rows[0]["reportTypeID"].ToString()!="")
				{
					model.reportTypeID=int.Parse(ds.Tables[0].Rows[0]["reportTypeID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["state"]!=null && ds.Tables[0].Rows[0]["state"].ToString()!="")
				{
					model.state=ds.Tables[0].Rows[0]["state"].ToString();
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
			strSql.Append("select ID,noveltyID,reporterID,reportTime,reportTypeID,state ");
			strSql.Append(" FROM reportTb ");
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
			strSql.Append(" ID,noveltyID,reporterID,reportTime,reportTypeID,state ");
			strSql.Append(" FROM reportTb ");
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
			parameters[0].Value = "reportTb";
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

