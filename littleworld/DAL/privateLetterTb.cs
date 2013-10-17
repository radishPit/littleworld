﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace littleworld.DAL
{
	/// <summary>
	/// 数据访问类:privateLetterTb
	/// </summary>
	public partial class privateLetterTb
	{
		public privateLetterTb()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "privateLetterTb"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from privateLetterTb");
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
		public int Add(littleworld.Model.privateLetterTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into privateLetterTb(");
			strSql.Append("senderID,receiveID,contents,sendTime,state)");
			strSql.Append(" values (");
			strSql.Append("@senderID,@receiveID,@contents,@sendTime,@state)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@senderID", SqlDbType.Int,4),
					new SqlParameter("@receiveID", SqlDbType.Int,4),
					new SqlParameter("@contents", SqlDbType.NVarChar,50),
					new SqlParameter("@sendTime", SqlDbType.DateTime),
					new SqlParameter("@state", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.senderID;
			parameters[1].Value = model.receiveID;
			parameters[2].Value = model.contents;
			parameters[3].Value = model.sendTime;
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
		public bool Update(littleworld.Model.privateLetterTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update privateLetterTb set ");
			strSql.Append("senderID=@senderID,");
			strSql.Append("receiveID=@receiveID,");
			strSql.Append("contents=@contents,");
			strSql.Append("sendTime=@sendTime,");
			strSql.Append("state=@state");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@senderID", SqlDbType.Int,4),
					new SqlParameter("@receiveID", SqlDbType.Int,4),
					new SqlParameter("@contents", SqlDbType.NVarChar,50),
					new SqlParameter("@sendTime", SqlDbType.DateTime),
					new SqlParameter("@state", SqlDbType.NVarChar,50),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.senderID;
			parameters[1].Value = model.receiveID;
			parameters[2].Value = model.contents;
			parameters[3].Value = model.sendTime;
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
			strSql.Append("delete from privateLetterTb ");
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
			strSql.Append("delete from privateLetterTb ");
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
		public littleworld.Model.privateLetterTb GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,senderID,receiveID,contents,sendTime,state from privateLetterTb ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			littleworld.Model.privateLetterTb model=new littleworld.Model.privateLetterTb();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["senderID"]!=null && ds.Tables[0].Rows[0]["senderID"].ToString()!="")
				{
					model.senderID=int.Parse(ds.Tables[0].Rows[0]["senderID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["receiveID"]!=null && ds.Tables[0].Rows[0]["receiveID"].ToString()!="")
				{
					model.receiveID=int.Parse(ds.Tables[0].Rows[0]["receiveID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["contents"]!=null && ds.Tables[0].Rows[0]["contents"].ToString()!="")
				{
					model.contents=ds.Tables[0].Rows[0]["contents"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sendTime"]!=null && ds.Tables[0].Rows[0]["sendTime"].ToString()!="")
				{
					model.sendTime=DateTime.Parse(ds.Tables[0].Rows[0]["sendTime"].ToString());
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
			strSql.Append("select ID,senderID,receiveID,contents,sendTime,state ");
			strSql.Append(" FROM privateLetterTb ");
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
			strSql.Append(" ID,senderID,receiveID,contents,sendTime,state ");
			strSql.Append(" FROM privateLetterTb ");
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
			parameters[0].Value = "privateLetterTb";
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

