using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace littleworld.DAL
{
	/// <summary>
	/// 数据访问类:LTsuppoterTb
	/// </summary>
	public partial class LTsuppoterTb
	{
		public LTsuppoterTb()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "LTsuppoterTb"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from LTsuppoterTb");
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
		public int Add(littleworld.Model.LTsuppoterTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into LTsuppoterTb(");
			strSql.Append("noteID,NsuppoterID,NsuppotTime,state)");
			strSql.Append(" values (");
			strSql.Append("@noteID,@NsuppoterID,@NsuppotTime,@state)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@noteID", SqlDbType.Int,4),
					new SqlParameter("@NsuppoterID", SqlDbType.Int,4),
					new SqlParameter("@NsuppotTime", SqlDbType.DateTime),
					new SqlParameter("@state", SqlDbType.Int,4)};
			parameters[0].Value = model.noteID;
			parameters[1].Value = model.NsuppoterID;
			parameters[2].Value = model.NsuppotTime;
			parameters[3].Value = model.state;

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
		public bool Update(littleworld.Model.LTsuppoterTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update LTsuppoterTb set ");
			strSql.Append("noteID=@noteID,");
			strSql.Append("NsuppoterID=@NsuppoterID,");
			strSql.Append("NsuppotTime=@NsuppotTime,");
			strSql.Append("state=@state");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@noteID", SqlDbType.Int,4),
					new SqlParameter("@NsuppoterID", SqlDbType.Int,4),
					new SqlParameter("@NsuppotTime", SqlDbType.DateTime),
					new SqlParameter("@state", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.noteID;
			parameters[1].Value = model.NsuppoterID;
			parameters[2].Value = model.NsuppotTime;
			parameters[3].Value = model.state;
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
			strSql.Append("delete from LTsuppoterTb ");
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
			strSql.Append("delete from LTsuppoterTb ");
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
		public littleworld.Model.LTsuppoterTb GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,noteID,NsuppoterID,NsuppotTime,state from LTsuppoterTb ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			littleworld.Model.LTsuppoterTb model=new littleworld.Model.LTsuppoterTb();
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
				if(ds.Tables[0].Rows[0]["NsuppoterID"]!=null && ds.Tables[0].Rows[0]["NsuppoterID"].ToString()!="")
				{
					model.NsuppoterID=int.Parse(ds.Tables[0].Rows[0]["NsuppoterID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["NsuppotTime"]!=null && ds.Tables[0].Rows[0]["NsuppotTime"].ToString()!="")
				{
					model.NsuppotTime=DateTime.Parse(ds.Tables[0].Rows[0]["NsuppotTime"].ToString());
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
			strSql.Append("select ID,noteID,NsuppoterID,NsuppotTime,state ");
			strSql.Append(" FROM LTsuppoterTb ");
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
			strSql.Append(" ID,noteID,NsuppoterID,NsuppotTime,state ");
			strSql.Append(" FROM LTsuppoterTb ");
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
			parameters[0].Value = "LTsuppoterTb";
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

