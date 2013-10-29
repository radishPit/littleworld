using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace littleworld.DAL
{
	/// <summary>
	/// 数据访问类:LTsectionTb
	/// </summary>
	public partial class LTsectionTb
	{
		public LTsectionTb()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("sectionId", "LTsectionTb"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int sectionId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from LTsectionTb");
			strSql.Append(" where sectionId=@sectionId");
			SqlParameter[] parameters = {
					new SqlParameter("@sectionId", SqlDbType.Int,4)
};
			parameters[0].Value = sectionId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(littleworld.Model.LTsectionTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into LTsectionTb(");
			strSql.Append("sectionName,sectionImg,sectionIntro,adminID,state)");
			strSql.Append(" values (");
			strSql.Append("@sectionName,@sectionImg,@sectionIntro,@adminID,@state)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@sectionName", SqlDbType.NVarChar,50),
					new SqlParameter("@sectionImg", SqlDbType.VarChar,500),
					new SqlParameter("@sectionIntro", SqlDbType.NVarChar,500),
					new SqlParameter("@adminID", SqlDbType.Int,4),
					new SqlParameter("@state", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.sectionName;
			parameters[1].Value = model.sectionImg;
			parameters[2].Value = model.sectionIntro;
			parameters[3].Value = model.adminID;
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
		public bool Update(littleworld.Model.LTsectionTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update LTsectionTb set ");
			strSql.Append("sectionName=@sectionName,");
			strSql.Append("sectionImg=@sectionImg,");
			strSql.Append("sectionIntro=@sectionIntro,");
			strSql.Append("adminID=@adminID,");
			strSql.Append("state=@state");
			strSql.Append(" where sectionId=@sectionId");
			SqlParameter[] parameters = {
					new SqlParameter("@sectionName", SqlDbType.NVarChar,50),
					new SqlParameter("@sectionImg", SqlDbType.VarChar,500),
					new SqlParameter("@sectionIntro", SqlDbType.NVarChar,500),
					new SqlParameter("@adminID", SqlDbType.Int,4),
					new SqlParameter("@state", SqlDbType.NVarChar,50),
					new SqlParameter("@sectionId", SqlDbType.Int,4)};
			parameters[0].Value = model.sectionName;
			parameters[1].Value = model.sectionImg;
			parameters[2].Value = model.sectionIntro;
			parameters[3].Value = model.adminID;
			parameters[4].Value = model.state;
			parameters[5].Value = model.sectionId;

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
		public bool Delete(int sectionId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from LTsectionTb ");
			strSql.Append(" where sectionId=@sectionId");
			SqlParameter[] parameters = {
					new SqlParameter("@sectionId", SqlDbType.Int,4)
};
			parameters[0].Value = sectionId;

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
		public bool DeleteList(string sectionIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from LTsectionTb ");
			strSql.Append(" where sectionId in ("+sectionIdlist + ")  ");
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
		public littleworld.Model.LTsectionTb GetModel(int sectionId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 sectionId,sectionName,sectionImg,sectionIntro,adminID,state from LTsectionTb ");
			strSql.Append(" where sectionId=@sectionId");
			SqlParameter[] parameters = {
					new SqlParameter("@sectionId", SqlDbType.Int,4)
};
			parameters[0].Value = sectionId;

			littleworld.Model.LTsectionTb model=new littleworld.Model.LTsectionTb();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["sectionId"]!=null && ds.Tables[0].Rows[0]["sectionId"].ToString()!="")
				{
					model.sectionId=int.Parse(ds.Tables[0].Rows[0]["sectionId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["sectionName"]!=null && ds.Tables[0].Rows[0]["sectionName"].ToString()!="")
				{
					model.sectionName=ds.Tables[0].Rows[0]["sectionName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sectionImg"]!=null && ds.Tables[0].Rows[0]["sectionImg"].ToString()!="")
				{
					model.sectionImg=ds.Tables[0].Rows[0]["sectionImg"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sectionIntro"]!=null && ds.Tables[0].Rows[0]["sectionIntro"].ToString()!="")
				{
					model.sectionIntro=ds.Tables[0].Rows[0]["sectionIntro"].ToString();
				}
				if(ds.Tables[0].Rows[0]["adminID"]!=null && ds.Tables[0].Rows[0]["adminID"].ToString()!="")
				{
					model.adminID=int.Parse(ds.Tables[0].Rows[0]["adminID"].ToString());
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
			strSql.Append("select sectionId,sectionName,sectionImg,sectionIntro,adminID,state ");
			strSql.Append(" FROM LTsectionTb ");
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
			strSql.Append(" sectionId,sectionName,sectionImg,sectionIntro,adminID,state ");
			strSql.Append(" FROM LTsectionTb ");
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
			parameters[0].Value = "LTsectionTb";
			parameters[1].Value = "sectionId";
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

