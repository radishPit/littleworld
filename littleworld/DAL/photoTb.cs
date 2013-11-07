using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace littleworld.DAL
{
	/// <summary>
	/// 数据访问类:photoTb
	/// </summary>
	public partial class photoTb
	{
		public photoTb()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("photoID", "photoTb"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int photoID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from photoTb");
			strSql.Append(" where photoID=@photoID ");
			SqlParameter[] parameters = {
					new SqlParameter("@photoID", SqlDbType.Int,4)};
			parameters[0].Value = photoID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(littleworld.Model.photoTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into photoTb(");
			strSql.Append("photoID,ownID,description,imgUrl,photoGroupID,creatTime,littleImgUrl)");
			strSql.Append(" values (");
			strSql.Append("@photoID,@ownID,@description,@imgUrl,@photoGroupID,@creatTime,@littleImgUrl)");
			SqlParameter[] parameters = {
					new SqlParameter("@photoID", SqlDbType.Int,4),
					new SqlParameter("@ownID", SqlDbType.Int,4),
					new SqlParameter("@description", SqlDbType.NVarChar,50),
					new SqlParameter("@imgUrl", SqlDbType.NVarChar,50),
					new SqlParameter("@photoGroupID", SqlDbType.Int,4),
					new SqlParameter("@creatTime", SqlDbType.DateTime),
					new SqlParameter("@littleImgUrl", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.photoID;
			parameters[1].Value = model.ownID;
			parameters[2].Value = model.description;
			parameters[3].Value = model.imgUrl;
			parameters[4].Value = model.photoGroupID;
			parameters[5].Value = model.creatTime;
			parameters[6].Value = model.littleImgUrl;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(littleworld.Model.photoTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update photoTb set ");
			strSql.Append("ownID=@ownID,");
			strSql.Append("description=@description,");
			strSql.Append("imgUrl=@imgUrl,");
			strSql.Append("photoGroupID=@photoGroupID,");
			strSql.Append("creatTime=@creatTime,");
			strSql.Append("littleImgUrl=@littleImgUrl");
			strSql.Append(" where photoID=@photoID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ownID", SqlDbType.Int,4),
					new SqlParameter("@description", SqlDbType.NVarChar,50),
					new SqlParameter("@imgUrl", SqlDbType.NVarChar,50),
					new SqlParameter("@photoGroupID", SqlDbType.Int,4),
					new SqlParameter("@creatTime", SqlDbType.DateTime),
					new SqlParameter("@littleImgUrl", SqlDbType.NVarChar,50),
					new SqlParameter("@photoID", SqlDbType.Int,4)};
			parameters[0].Value = model.ownID;
			parameters[1].Value = model.description;
			parameters[2].Value = model.imgUrl;
			parameters[3].Value = model.photoGroupID;
			parameters[4].Value = model.creatTime;
			parameters[5].Value = model.littleImgUrl;
			parameters[6].Value = model.photoID;

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
		public bool Delete(int photoID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from photoTb ");
			strSql.Append(" where photoID=@photoID ");
			SqlParameter[] parameters = {
					new SqlParameter("@photoID", SqlDbType.Int,4)};
			parameters[0].Value = photoID;

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
		public bool DeleteList(string photoIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from photoTb ");
			strSql.Append(" where photoID in ("+photoIDlist + ")  ");
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
		public littleworld.Model.photoTb GetModel(int photoID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 photoID,ownID,description,imgUrl,photoGroupID,creatTime,littleImgUrl from photoTb ");
			strSql.Append(" where photoID=@photoID ");
			SqlParameter[] parameters = {
					new SqlParameter("@photoID", SqlDbType.Int,4)};
			parameters[0].Value = photoID;

			littleworld.Model.photoTb model=new littleworld.Model.photoTb();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["photoID"]!=null && ds.Tables[0].Rows[0]["photoID"].ToString()!="")
				{
					model.photoID=int.Parse(ds.Tables[0].Rows[0]["photoID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ownID"]!=null && ds.Tables[0].Rows[0]["ownID"].ToString()!="")
				{
					model.ownID=int.Parse(ds.Tables[0].Rows[0]["ownID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["description"]!=null && ds.Tables[0].Rows[0]["description"].ToString()!="")
				{
					model.description=ds.Tables[0].Rows[0]["description"].ToString();
				}
				if(ds.Tables[0].Rows[0]["imgUrl"]!=null && ds.Tables[0].Rows[0]["imgUrl"].ToString()!="")
				{
					model.imgUrl=ds.Tables[0].Rows[0]["imgUrl"].ToString();
				}
				if(ds.Tables[0].Rows[0]["photoGroupID"]!=null && ds.Tables[0].Rows[0]["photoGroupID"].ToString()!="")
				{
					model.photoGroupID=int.Parse(ds.Tables[0].Rows[0]["photoGroupID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["creatTime"]!=null && ds.Tables[0].Rows[0]["creatTime"].ToString()!="")
				{
					model.creatTime=DateTime.Parse(ds.Tables[0].Rows[0]["creatTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["littleImgUrl"]!=null && ds.Tables[0].Rows[0]["littleImgUrl"].ToString()!="")
				{
					model.littleImgUrl=ds.Tables[0].Rows[0]["littleImgUrl"].ToString();
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
			strSql.Append("select photoID,ownID,description,imgUrl,photoGroupID,creatTime,littleImgUrl ");
			strSql.Append(" FROM photoTb ");
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
			strSql.Append(" photoID,ownID,description,imgUrl,photoGroupID,creatTime,littleImgUrl ");
			strSql.Append(" FROM photoTb ");
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
			parameters[0].Value = "photoTb";
			parameters[1].Value = "photoID";
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

