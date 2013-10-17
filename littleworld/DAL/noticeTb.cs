using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace littleworld.DAL
{
	/// <summary>
	/// 数据访问类:noticeTb
	/// </summary>
	public partial class noticeTb
	{
		public noticeTb()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("noticeID", "noticeTb"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int noticeID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from noticeTb");
			strSql.Append(" where noticeID=@noticeID");
			SqlParameter[] parameters = {
					new SqlParameter("@noticeID", SqlDbType.Int,4)
};
			parameters[0].Value = noticeID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(littleworld.Model.noticeTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into noticeTb(");
			strSql.Append("adminID,title,contents,sentTime,state,receiveID)");
			strSql.Append(" values (");
			strSql.Append("@adminID,@title,@contents,@sentTime,@state,@receiveID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@adminID", SqlDbType.Int,4),
					new SqlParameter("@title", SqlDbType.NVarChar,50),
					new SqlParameter("@contents", SqlDbType.NVarChar,500),
					new SqlParameter("@sentTime", SqlDbType.DateTime),
					new SqlParameter("@state", SqlDbType.NVarChar,50),
					new SqlParameter("@receiveID", SqlDbType.Int,4)};
			parameters[0].Value = model.adminID;
			parameters[1].Value = model.title;
			parameters[2].Value = model.contents;
			parameters[3].Value = model.sentTime;
			parameters[4].Value = model.state;
			parameters[5].Value = model.receiveID;

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
		public bool Update(littleworld.Model.noticeTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update noticeTb set ");
			strSql.Append("adminID=@adminID,");
			strSql.Append("title=@title,");
			strSql.Append("contents=@contents,");
			strSql.Append("sentTime=@sentTime,");
			strSql.Append("state=@state,");
			strSql.Append("receiveID=@receiveID");
			strSql.Append(" where noticeID=@noticeID");
			SqlParameter[] parameters = {
					new SqlParameter("@adminID", SqlDbType.Int,4),
					new SqlParameter("@title", SqlDbType.NVarChar,50),
					new SqlParameter("@contents", SqlDbType.NVarChar,500),
					new SqlParameter("@sentTime", SqlDbType.DateTime),
					new SqlParameter("@state", SqlDbType.NVarChar,50),
					new SqlParameter("@receiveID", SqlDbType.Int,4),
					new SqlParameter("@noticeID", SqlDbType.Int,4)};
			parameters[0].Value = model.adminID;
			parameters[1].Value = model.title;
			parameters[2].Value = model.contents;
			parameters[3].Value = model.sentTime;
			parameters[4].Value = model.state;
			parameters[5].Value = model.receiveID;
			parameters[6].Value = model.noticeID;

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
		public bool Delete(int noticeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from noticeTb ");
			strSql.Append(" where noticeID=@noticeID");
			SqlParameter[] parameters = {
					new SqlParameter("@noticeID", SqlDbType.Int,4)
};
			parameters[0].Value = noticeID;

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
		public bool DeleteList(string noticeIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from noticeTb ");
			strSql.Append(" where noticeID in ("+noticeIDlist + ")  ");
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
		public littleworld.Model.noticeTb GetModel(int noticeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 noticeID,adminID,title,contents,sentTime,state,receiveID from noticeTb ");
			strSql.Append(" where noticeID=@noticeID");
			SqlParameter[] parameters = {
					new SqlParameter("@noticeID", SqlDbType.Int,4)
};
			parameters[0].Value = noticeID;

			littleworld.Model.noticeTb model=new littleworld.Model.noticeTb();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["noticeID"]!=null && ds.Tables[0].Rows[0]["noticeID"].ToString()!="")
				{
					model.noticeID=int.Parse(ds.Tables[0].Rows[0]["noticeID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["adminID"]!=null && ds.Tables[0].Rows[0]["adminID"].ToString()!="")
				{
					model.adminID=int.Parse(ds.Tables[0].Rows[0]["adminID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["title"]!=null && ds.Tables[0].Rows[0]["title"].ToString()!="")
				{
					model.title=ds.Tables[0].Rows[0]["title"].ToString();
				}
				if(ds.Tables[0].Rows[0]["contents"]!=null && ds.Tables[0].Rows[0]["contents"].ToString()!="")
				{
					model.contents=ds.Tables[0].Rows[0]["contents"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sentTime"]!=null && ds.Tables[0].Rows[0]["sentTime"].ToString()!="")
				{
					model.sentTime=DateTime.Parse(ds.Tables[0].Rows[0]["sentTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["state"]!=null && ds.Tables[0].Rows[0]["state"].ToString()!="")
				{
					model.state=ds.Tables[0].Rows[0]["state"].ToString();
				}
				if(ds.Tables[0].Rows[0]["receiveID"]!=null && ds.Tables[0].Rows[0]["receiveID"].ToString()!="")
				{
					model.receiveID=int.Parse(ds.Tables[0].Rows[0]["receiveID"].ToString());
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
			strSql.Append("select noticeID,adminID,title,contents,sentTime,state,receiveID ");
			strSql.Append(" FROM noticeTb ");
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
			strSql.Append(" noticeID,adminID,title,contents,sentTime,state,receiveID ");
			strSql.Append(" FROM noticeTb ");
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
			parameters[0].Value = "noticeTb";
			parameters[1].Value = "noticeID";
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

