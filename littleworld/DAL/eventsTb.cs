using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace littleworld.DAL
{
	/// <summary>
	/// 数据访问类:eventsTb
	/// </summary>
	public partial class eventsTb
	{
		public eventsTb()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "eventsTb"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from eventsTb");
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
		public int Add(littleworld.Model.eventsTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into eventsTb(");
			strSql.Append("operatorID,operateAction,operateContent,operateTime)");
			strSql.Append(" values (");
			strSql.Append("@operatorID,@operateAction,@operateContent,@operateTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@operatorID", SqlDbType.Int,4),
					new SqlParameter("@operateAction", SqlDbType.NVarChar,50),
					new SqlParameter("@operateContent", SqlDbType.NVarChar,500),
					new SqlParameter("@operateTime", SqlDbType.DateTime)};
			parameters[0].Value = model.operatorID;
			parameters[1].Value = model.operateAction;
			parameters[2].Value = model.operateContent;
			parameters[3].Value = model.operateTime;

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
		public bool Update(littleworld.Model.eventsTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update eventsTb set ");
			strSql.Append("operatorID=@operatorID,");
			strSql.Append("operateAction=@operateAction,");
			strSql.Append("operateContent=@operateContent,");
			strSql.Append("operateTime=@operateTime");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@operatorID", SqlDbType.Int,4),
					new SqlParameter("@operateAction", SqlDbType.NVarChar,50),
					new SqlParameter("@operateContent", SqlDbType.NVarChar,500),
					new SqlParameter("@operateTime", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.operatorID;
			parameters[1].Value = model.operateAction;
			parameters[2].Value = model.operateContent;
			parameters[3].Value = model.operateTime;
			parameters[4].Value = model.ID;

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
			strSql.Append("delete from eventsTb ");
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
			strSql.Append("delete from eventsTb ");
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
		public littleworld.Model.eventsTb GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,operatorID,operateAction,operateContent,operateTime from eventsTb ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			littleworld.Model.eventsTb model=new littleworld.Model.eventsTb();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["operatorID"]!=null && ds.Tables[0].Rows[0]["operatorID"].ToString()!="")
				{
					model.operatorID=int.Parse(ds.Tables[0].Rows[0]["operatorID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["operateAction"]!=null && ds.Tables[0].Rows[0]["operateAction"].ToString()!="")
				{
					model.operateAction=ds.Tables[0].Rows[0]["operateAction"].ToString();
				}
				if(ds.Tables[0].Rows[0]["operateContent"]!=null && ds.Tables[0].Rows[0]["operateContent"].ToString()!="")
				{
					model.operateContent=ds.Tables[0].Rows[0]["operateContent"].ToString();
				}
				if(ds.Tables[0].Rows[0]["operateTime"]!=null && ds.Tables[0].Rows[0]["operateTime"].ToString()!="")
				{
					model.operateTime=DateTime.Parse(ds.Tables[0].Rows[0]["operateTime"].ToString());
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
			strSql.Append("select ID,operatorID,operateAction,operateContent,operateTime ");
			strSql.Append(" FROM eventsTb ");
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
			strSql.Append(" ID,operatorID,operateAction,operateContent,operateTime ");
			strSql.Append(" FROM eventsTb ");
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
			parameters[0].Value = "eventsTb";
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

