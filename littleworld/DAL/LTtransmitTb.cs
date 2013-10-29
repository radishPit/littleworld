using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace littleworld.DAL
{
	/// <summary>
	/// 数据访问类:LTtransmitTb
	/// </summary>
	public partial class LTtransmitTb
	{
		public LTtransmitTb()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "LTtransmitTb"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from LTtransmitTb");
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
		public int Add(littleworld.Model.LTtransmitTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into LTtransmitTb(");
			strSql.Append("noteID,NtransmiterID,contents,NtransmitTime,state)");
			strSql.Append(" values (");
			strSql.Append("@noteID,@NtransmiterID,@contents,@NtransmitTime,@state)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@noteID", SqlDbType.Int,4),
					new SqlParameter("@NtransmiterID", SqlDbType.Int,4),
					new SqlParameter("@contents", SqlDbType.NVarChar,500),
					new SqlParameter("@NtransmitTime", SqlDbType.DateTime),
					new SqlParameter("@state", SqlDbType.Int,4)};
			parameters[0].Value = model.noteID;
			parameters[1].Value = model.NtransmiterID;
			parameters[2].Value = model.contents;
			parameters[3].Value = model.NtransmitTime;
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
		public bool Update(littleworld.Model.LTtransmitTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update LTtransmitTb set ");
			strSql.Append("noteID=@noteID,");
			strSql.Append("NtransmiterID=@NtransmiterID,");
			strSql.Append("contents=@contents,");
			strSql.Append("NtransmitTime=@NtransmitTime,");
			strSql.Append("state=@state");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@noteID", SqlDbType.Int,4),
					new SqlParameter("@NtransmiterID", SqlDbType.Int,4),
					new SqlParameter("@contents", SqlDbType.NVarChar,500),
					new SqlParameter("@NtransmitTime", SqlDbType.DateTime),
					new SqlParameter("@state", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.noteID;
			parameters[1].Value = model.NtransmiterID;
			parameters[2].Value = model.contents;
			parameters[3].Value = model.NtransmitTime;
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
			strSql.Append("delete from LTtransmitTb ");
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
			strSql.Append("delete from LTtransmitTb ");
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
		public littleworld.Model.LTtransmitTb GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,noteID,NtransmiterID,contents,NtransmitTime,state from LTtransmitTb ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			littleworld.Model.LTtransmitTb model=new littleworld.Model.LTtransmitTb();
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
				if(ds.Tables[0].Rows[0]["NtransmiterID"]!=null && ds.Tables[0].Rows[0]["NtransmiterID"].ToString()!="")
				{
					model.NtransmiterID=int.Parse(ds.Tables[0].Rows[0]["NtransmiterID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["contents"]!=null && ds.Tables[0].Rows[0]["contents"].ToString()!="")
				{
					model.contents=ds.Tables[0].Rows[0]["contents"].ToString();
				}
				if(ds.Tables[0].Rows[0]["NtransmitTime"]!=null && ds.Tables[0].Rows[0]["NtransmitTime"].ToString()!="")
				{
					model.NtransmitTime=DateTime.Parse(ds.Tables[0].Rows[0]["NtransmitTime"].ToString());
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
			strSql.Append("select ID,noteID,NtransmiterID,contents,NtransmitTime,state ");
			strSql.Append(" FROM LTtransmitTb ");
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
			strSql.Append(" ID,noteID,NtransmiterID,contents,NtransmitTime,state ");
			strSql.Append(" FROM LTtransmitTb ");
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
			parameters[0].Value = "LTtransmitTb";
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

