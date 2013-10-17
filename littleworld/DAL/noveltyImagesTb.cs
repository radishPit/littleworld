using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace littleworld.DAL
{
	/// <summary>
	/// 数据访问类:noveltyImagesTb
	/// </summary>
	public partial class noveltyImagesTb
	{
		public noveltyImagesTb()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "noveltyImagesTb"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from noveltyImagesTb");
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
		public int Add(littleworld.Model.noveltyImagesTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into noveltyImagesTb(");
			strSql.Append("noveltyID,imgUrl,smallImgUrl)");
			strSql.Append(" values (");
			strSql.Append("@noveltyID,@imgUrl,@smallImgUrl)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@noveltyID", SqlDbType.Int,4),
					new SqlParameter("@imgUrl", SqlDbType.NVarChar,100),
					new SqlParameter("@smallImgUrl", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.noveltyID;
			parameters[1].Value = model.imgUrl;
			parameters[2].Value = model.smallImgUrl;

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
		public bool Update(littleworld.Model.noveltyImagesTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update noveltyImagesTb set ");
			strSql.Append("noveltyID=@noveltyID,");
			strSql.Append("imgUrl=@imgUrl,");
			strSql.Append("smallImgUrl=@smallImgUrl");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@noveltyID", SqlDbType.Int,4),
					new SqlParameter("@imgUrl", SqlDbType.NVarChar,100),
					new SqlParameter("@smallImgUrl", SqlDbType.NVarChar,50),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.noveltyID;
			parameters[1].Value = model.imgUrl;
			parameters[2].Value = model.smallImgUrl;
			parameters[3].Value = model.ID;

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
			strSql.Append("delete from noveltyImagesTb ");
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
			strSql.Append("delete from noveltyImagesTb ");
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
		public littleworld.Model.noveltyImagesTb GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,noveltyID,imgUrl,smallImgUrl from noveltyImagesTb ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			littleworld.Model.noveltyImagesTb model=new littleworld.Model.noveltyImagesTb();
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
				if(ds.Tables[0].Rows[0]["imgUrl"]!=null && ds.Tables[0].Rows[0]["imgUrl"].ToString()!="")
				{
					model.imgUrl=ds.Tables[0].Rows[0]["imgUrl"].ToString();
				}
				if(ds.Tables[0].Rows[0]["smallImgUrl"]!=null && ds.Tables[0].Rows[0]["smallImgUrl"].ToString()!="")
				{
					model.smallImgUrl=ds.Tables[0].Rows[0]["smallImgUrl"].ToString();
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
			strSql.Append("select ID,noveltyID,imgUrl,smallImgUrl ");
			strSql.Append(" FROM noveltyImagesTb ");
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
			strSql.Append(" ID,noveltyID,imgUrl,smallImgUrl ");
			strSql.Append(" FROM noveltyImagesTb ");
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
			parameters[0].Value = "noveltyImagesTb";
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

