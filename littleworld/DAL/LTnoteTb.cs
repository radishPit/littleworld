using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace littleworld.DAL
{
	/// <summary>
	/// 数据访问类:LTnoteTb
	/// </summary>
	public partial class LTnoteTb
	{
		public LTnoteTb()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("noteID", "LTnoteTb"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int noteID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from LTnoteTb");
			strSql.Append(" where noteID=@noteID");
			SqlParameter[] parameters = {
					new SqlParameter("@noteID", SqlDbType.Int,4)
};
			parameters[0].Value = noteID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(littleworld.Model.LTnoteTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into LTnoteTb(");
			strSql.Append("sectionID,senderID,NContent,NCommentNum,NSupportNum,NReportNum,NTransmitNum,NPublishtime,NState,parentNoteID)");
			strSql.Append(" values (");
			strSql.Append("@sectionID,@senderID,@NContent,@NCommentNum,@NSupportNum,@NReportNum,@NTransmitNum,@NPublishtime,@NState,@parentNoteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@sectionID", SqlDbType.Int,4),
					new SqlParameter("@senderID", SqlDbType.Int,4),
					new SqlParameter("@NContent", SqlDbType.NVarChar,3000),
					new SqlParameter("@NCommentNum", SqlDbType.Int,4),
					new SqlParameter("@NSupportNum", SqlDbType.Int,4),
					new SqlParameter("@NReportNum", SqlDbType.Int,4),
					new SqlParameter("@NTransmitNum", SqlDbType.Int,4),
					new SqlParameter("@NPublishtime", SqlDbType.DateTime),
					new SqlParameter("@NState", SqlDbType.NVarChar,50),
					new SqlParameter("@parentNoteID", SqlDbType.Int,4)};
			parameters[0].Value = model.sectionID;
			parameters[1].Value = model.senderID;
			parameters[2].Value = model.NContent;
			parameters[3].Value = model.NCommentNum;
			parameters[4].Value = model.NSupportNum;
			parameters[5].Value = model.NReportNum;
			parameters[6].Value = model.NTransmitNum;
			parameters[7].Value = model.NPublishtime;
			parameters[8].Value = model.NState;
			parameters[9].Value = model.parentNoteID;

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
		public bool Update(littleworld.Model.LTnoteTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update LTnoteTb set ");
			strSql.Append("sectionID=@sectionID,");
			strSql.Append("senderID=@senderID,");
			strSql.Append("NContent=@NContent,");
			strSql.Append("NCommentNum=@NCommentNum,");
			strSql.Append("NSupportNum=@NSupportNum,");
			strSql.Append("NReportNum=@NReportNum,");
			strSql.Append("NTransmitNum=@NTransmitNum,");
			strSql.Append("NPublishtime=@NPublishtime,");
			strSql.Append("NState=@NState,");
			strSql.Append("parentNoteID=@parentNoteID");
			strSql.Append(" where noteID=@noteID");
			SqlParameter[] parameters = {
					new SqlParameter("@sectionID", SqlDbType.Int,4),
					new SqlParameter("@senderID", SqlDbType.Int,4),
					new SqlParameter("@NContent", SqlDbType.NVarChar,3000),
					new SqlParameter("@NCommentNum", SqlDbType.Int,4),
					new SqlParameter("@NSupportNum", SqlDbType.Int,4),
					new SqlParameter("@NReportNum", SqlDbType.Int,4),
					new SqlParameter("@NTransmitNum", SqlDbType.Int,4),
					new SqlParameter("@NPublishtime", SqlDbType.DateTime),
					new SqlParameter("@NState", SqlDbType.NVarChar,50),
					new SqlParameter("@parentNoteID", SqlDbType.Int,4),
					new SqlParameter("@noteID", SqlDbType.Int,4)};
			parameters[0].Value = model.sectionID;
			parameters[1].Value = model.senderID;
			parameters[2].Value = model.NContent;
			parameters[3].Value = model.NCommentNum;
			parameters[4].Value = model.NSupportNum;
			parameters[5].Value = model.NReportNum;
			parameters[6].Value = model.NTransmitNum;
			parameters[7].Value = model.NPublishtime;
			parameters[8].Value = model.NState;
			parameters[9].Value = model.parentNoteID;
			parameters[10].Value = model.noteID;

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
		public bool Delete(int noteID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from LTnoteTb ");
			strSql.Append(" where noteID=@noteID");
			SqlParameter[] parameters = {
					new SqlParameter("@noteID", SqlDbType.Int,4)
};
			parameters[0].Value = noteID;

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
		public bool DeleteList(string noteIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from LTnoteTb ");
			strSql.Append(" where noteID in ("+noteIDlist + ")  ");
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
		public littleworld.Model.LTnoteTb GetModel(int noteID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 noteID,sectionID,senderID,NContent,NCommentNum,NSupportNum,NReportNum,NTransmitNum,NPublishtime,NState,parentNoteID from LTnoteTb ");
			strSql.Append(" where noteID=@noteID");
			SqlParameter[] parameters = {
					new SqlParameter("@noteID", SqlDbType.Int,4)
};
			parameters[0].Value = noteID;

			littleworld.Model.LTnoteTb model=new littleworld.Model.LTnoteTb();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["noteID"]!=null && ds.Tables[0].Rows[0]["noteID"].ToString()!="")
				{
					model.noteID=int.Parse(ds.Tables[0].Rows[0]["noteID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["sectionID"]!=null && ds.Tables[0].Rows[0]["sectionID"].ToString()!="")
				{
					model.sectionID=int.Parse(ds.Tables[0].Rows[0]["sectionID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["senderID"]!=null && ds.Tables[0].Rows[0]["senderID"].ToString()!="")
				{
					model.senderID=int.Parse(ds.Tables[0].Rows[0]["senderID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["NContent"]!=null && ds.Tables[0].Rows[0]["NContent"].ToString()!="")
				{
					model.NContent=ds.Tables[0].Rows[0]["NContent"].ToString();
				}
				if(ds.Tables[0].Rows[0]["NCommentNum"]!=null && ds.Tables[0].Rows[0]["NCommentNum"].ToString()!="")
				{
					model.NCommentNum=int.Parse(ds.Tables[0].Rows[0]["NCommentNum"].ToString());
				}
				if(ds.Tables[0].Rows[0]["NSupportNum"]!=null && ds.Tables[0].Rows[0]["NSupportNum"].ToString()!="")
				{
					model.NSupportNum=int.Parse(ds.Tables[0].Rows[0]["NSupportNum"].ToString());
				}
				if(ds.Tables[0].Rows[0]["NReportNum"]!=null && ds.Tables[0].Rows[0]["NReportNum"].ToString()!="")
				{
					model.NReportNum=int.Parse(ds.Tables[0].Rows[0]["NReportNum"].ToString());
				}
				if(ds.Tables[0].Rows[0]["NTransmitNum"]!=null && ds.Tables[0].Rows[0]["NTransmitNum"].ToString()!="")
				{
					model.NTransmitNum=int.Parse(ds.Tables[0].Rows[0]["NTransmitNum"].ToString());
				}
				if(ds.Tables[0].Rows[0]["NPublishtime"]!=null && ds.Tables[0].Rows[0]["NPublishtime"].ToString()!="")
				{
					model.NPublishtime=DateTime.Parse(ds.Tables[0].Rows[0]["NPublishtime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["NState"]!=null && ds.Tables[0].Rows[0]["NState"].ToString()!="")
				{
					model.NState=ds.Tables[0].Rows[0]["NState"].ToString();
				}
				if(ds.Tables[0].Rows[0]["parentNoteID"]!=null && ds.Tables[0].Rows[0]["parentNoteID"].ToString()!="")
				{
					model.parentNoteID=int.Parse(ds.Tables[0].Rows[0]["parentNoteID"].ToString());
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
			strSql.Append("select noteID,sectionID,senderID,NContent,NCommentNum,NSupportNum,NReportNum,NTransmitNum,NPublishtime,NState,parentNoteID ");
			strSql.Append(" FROM LTnoteTb ");
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
			strSql.Append(" noteID,sectionID,senderID,NContent,NCommentNum,NSupportNum,NReportNum,NTransmitNum,NPublishtime,NState,parentNoteID ");
			strSql.Append(" FROM LTnoteTb ");
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
			parameters[0].Value = "LTnoteTb";
			parameters[1].Value = "noteID";
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

