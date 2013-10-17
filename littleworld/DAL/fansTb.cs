using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace littleworld.DAL
{
	/// <summary>
	/// 数据访问类:fansTb
	/// </summary>
	public partial class fansTb
	{
		public fansTb()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "fansTb"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from fansTb");
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
		public int Add(littleworld.Model.fansTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into fansTb(");
			strSql.Append("ownID,ownedID,ownedName,groupID)");
			strSql.Append(" values (");
			strSql.Append("@ownID,@ownedID,@ownedName,@groupID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ownID", SqlDbType.Int,4),
					new SqlParameter("@ownedID", SqlDbType.Int,4),
					new SqlParameter("@ownedName", SqlDbType.NVarChar,50),
					new SqlParameter("@groupID", SqlDbType.Int,4)};
			parameters[0].Value = model.ownID;
			parameters[1].Value = model.ownedID;
			parameters[2].Value = model.ownedName;
			parameters[3].Value = model.groupID;

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
		public bool Update(littleworld.Model.fansTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update fansTb set ");
			strSql.Append("ownID=@ownID,");
			strSql.Append("ownedID=@ownedID,");
			strSql.Append("ownedName=@ownedName,");
			strSql.Append("groupID=@groupID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ownID", SqlDbType.Int,4),
					new SqlParameter("@ownedID", SqlDbType.Int,4),
					new SqlParameter("@ownedName", SqlDbType.NVarChar,50),
					new SqlParameter("@groupID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.ownID;
			parameters[1].Value = model.ownedID;
			parameters[2].Value = model.ownedName;
			parameters[3].Value = model.groupID;
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
			strSql.Append("delete from fansTb ");
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
			strSql.Append("delete from fansTb ");
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
		public littleworld.Model.fansTb GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,ownID,ownedID,ownedName,groupID from fansTb ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			littleworld.Model.fansTb model=new littleworld.Model.fansTb();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ownID"]!=null && ds.Tables[0].Rows[0]["ownID"].ToString()!="")
				{
					model.ownID=int.Parse(ds.Tables[0].Rows[0]["ownID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ownedID"]!=null && ds.Tables[0].Rows[0]["ownedID"].ToString()!="")
				{
					model.ownedID=int.Parse(ds.Tables[0].Rows[0]["ownedID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ownedName"]!=null && ds.Tables[0].Rows[0]["ownedName"].ToString()!="")
				{
					model.ownedName=ds.Tables[0].Rows[0]["ownedName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["groupID"]!=null && ds.Tables[0].Rows[0]["groupID"].ToString()!="")
				{
					model.groupID=int.Parse(ds.Tables[0].Rows[0]["groupID"].ToString());
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
			strSql.Append("select ID,ownID,ownedID,ownedName,groupID ");
			strSql.Append(" FROM fansTb ");
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
			strSql.Append(" ID,ownID,ownedID,ownedName,groupID ");
			strSql.Append(" FROM fansTb ");
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
			parameters[0].Value = "fansTb";
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

