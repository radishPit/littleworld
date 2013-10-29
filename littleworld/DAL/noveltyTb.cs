using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace littleworld.DAL
{
	/// <summary>
	/// 数据访问类:noveltyTb
	/// </summary>
	public partial class noveltyTb
	{
		public noveltyTb()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("noveltyID", "noveltyTb"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int noveltyID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from noveltyTb");
			strSql.Append(" where noveltyID=@noveltyID");
			SqlParameter[] parameters = {
					new SqlParameter("@noveltyID", SqlDbType.Int,4)
};
			parameters[0].Value = noveltyID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(littleworld.Model.noveltyTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into noveltyTb(");
			strSql.Append("senderID,contents,state,hasImgs,typeID,commentNum,supportNum,reportNum,transmitNum,publishtime)");
			strSql.Append(" values (");
			strSql.Append("@senderID,@contents,@state,@hasImgs,@typeID,@commentNum,@supportNum,@reportNum,@transmitNum,@publishtime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@senderID", SqlDbType.Int,4),
					new SqlParameter("@contents", SqlDbType.NVarChar,500),
					new SqlParameter("@state", SqlDbType.NVarChar,50),
					new SqlParameter("@hasImgs", SqlDbType.Int,4),
					new SqlParameter("@typeID", SqlDbType.Int,4),
					new SqlParameter("@commentNum", SqlDbType.Int,4),
					new SqlParameter("@supportNum", SqlDbType.Int,4),
					new SqlParameter("@reportNum", SqlDbType.Int,4),
					new SqlParameter("@transmitNum", SqlDbType.Int,4),
					new SqlParameter("@publishtime", SqlDbType.DateTime)};
			parameters[0].Value = model.senderID;
			parameters[1].Value = model.contents;
			parameters[2].Value = model.state;
			parameters[3].Value = model.hasImgs;
			parameters[4].Value = model.typeID;
			parameters[5].Value = model.commentNum;
			parameters[6].Value = model.supportNum;
			parameters[7].Value = model.reportNum;
			parameters[8].Value = model.transmitNum;
			parameters[9].Value = model.publishtime;

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
		public bool Update(littleworld.Model.noveltyTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update noveltyTb set ");
			strSql.Append("senderID=@senderID,");
			strSql.Append("contents=@contents,");
			strSql.Append("state=@state,");
			strSql.Append("hasImgs=@hasImgs,");
			strSql.Append("typeID=@typeID,");
			strSql.Append("commentNum=@commentNum,");
			strSql.Append("supportNum=@supportNum,");
			strSql.Append("reportNum=@reportNum,");
			strSql.Append("transmitNum=@transmitNum,");
			strSql.Append("publishtime=@publishtime");
			strSql.Append(" where noveltyID=@noveltyID");
			SqlParameter[] parameters = {
					new SqlParameter("@senderID", SqlDbType.Int,4),
					new SqlParameter("@contents", SqlDbType.NVarChar,500),
					new SqlParameter("@state", SqlDbType.NVarChar,50),
					new SqlParameter("@hasImgs", SqlDbType.Int,4),
					new SqlParameter("@typeID", SqlDbType.Int,4),
					new SqlParameter("@commentNum", SqlDbType.Int,4),
					new SqlParameter("@supportNum", SqlDbType.Int,4),
					new SqlParameter("@reportNum", SqlDbType.Int,4),
					new SqlParameter("@transmitNum", SqlDbType.Int,4),
					new SqlParameter("@publishtime", SqlDbType.DateTime),
					new SqlParameter("@noveltyID", SqlDbType.Int,4)};
			parameters[0].Value = model.senderID;
			parameters[1].Value = model.contents;
			parameters[2].Value = model.state;
			parameters[3].Value = model.hasImgs;
			parameters[4].Value = model.typeID;
			parameters[5].Value = model.commentNum;
			parameters[6].Value = model.supportNum;
			parameters[7].Value = model.reportNum;
			parameters[8].Value = model.transmitNum;
			parameters[9].Value = model.publishtime;
			parameters[10].Value = model.noveltyID;

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
		public bool Delete(int noveltyID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from noveltyTb ");
			strSql.Append(" where noveltyID=@noveltyID");
			SqlParameter[] parameters = {
					new SqlParameter("@noveltyID", SqlDbType.Int,4)
};
			parameters[0].Value = noveltyID;

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
		public bool DeleteList(string noveltyIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from noveltyTb ");
			strSql.Append(" where noveltyID in ("+noveltyIDlist + ")  ");
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
		public littleworld.Model.noveltyTb GetModel(int noveltyID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 noveltyID,senderID,contents,state,hasImgs,typeID,commentNum,supportNum,reportNum,transmitNum,publishtime from noveltyTb ");
			strSql.Append(" where noveltyID=@noveltyID");
			SqlParameter[] parameters = {
					new SqlParameter("@noveltyID", SqlDbType.Int,4)
};
			parameters[0].Value = noveltyID;

			littleworld.Model.noveltyTb model=new littleworld.Model.noveltyTb();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["noveltyID"]!=null && ds.Tables[0].Rows[0]["noveltyID"].ToString()!="")
				{
					model.noveltyID=int.Parse(ds.Tables[0].Rows[0]["noveltyID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["senderID"]!=null && ds.Tables[0].Rows[0]["senderID"].ToString()!="")
				{
					model.senderID=int.Parse(ds.Tables[0].Rows[0]["senderID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["contents"]!=null && ds.Tables[0].Rows[0]["contents"].ToString()!="")
				{
					model.contents=ds.Tables[0].Rows[0]["contents"].ToString();
				}
				if(ds.Tables[0].Rows[0]["state"]!=null && ds.Tables[0].Rows[0]["state"].ToString()!="")
				{
					model.state=ds.Tables[0].Rows[0]["state"].ToString();
				}
				if(ds.Tables[0].Rows[0]["hasImgs"]!=null && ds.Tables[0].Rows[0]["hasImgs"].ToString()!="")
				{
					model.hasImgs=int.Parse(ds.Tables[0].Rows[0]["hasImgs"].ToString());
				}
				if(ds.Tables[0].Rows[0]["typeID"]!=null && ds.Tables[0].Rows[0]["typeID"].ToString()!="")
				{
					model.typeID=int.Parse(ds.Tables[0].Rows[0]["typeID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["commentNum"]!=null && ds.Tables[0].Rows[0]["commentNum"].ToString()!="")
				{
					model.commentNum=int.Parse(ds.Tables[0].Rows[0]["commentNum"].ToString());
				}
				if(ds.Tables[0].Rows[0]["supportNum"]!=null && ds.Tables[0].Rows[0]["supportNum"].ToString()!="")
				{
					model.supportNum=int.Parse(ds.Tables[0].Rows[0]["supportNum"].ToString());
				}
				if(ds.Tables[0].Rows[0]["reportNum"]!=null && ds.Tables[0].Rows[0]["reportNum"].ToString()!="")
				{
					model.reportNum=int.Parse(ds.Tables[0].Rows[0]["reportNum"].ToString());
				}
				if(ds.Tables[0].Rows[0]["transmitNum"]!=null && ds.Tables[0].Rows[0]["transmitNum"].ToString()!="")
				{
					model.transmitNum=int.Parse(ds.Tables[0].Rows[0]["transmitNum"].ToString());
				}
				if(ds.Tables[0].Rows[0]["publishtime"]!=null && ds.Tables[0].Rows[0]["publishtime"].ToString()!="")
				{
					model.publishtime=DateTime.Parse(ds.Tables[0].Rows[0]["publishtime"].ToString());
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
			strSql.Append("select noveltyID,senderID,contents,state,hasImgs,typeID,commentNum,supportNum,reportNum,transmitNum,publishtime ");
			strSql.Append(" FROM noveltyTb ");
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
			strSql.Append(" noveltyID,senderID,contents,state,hasImgs,typeID,commentNum,supportNum,reportNum,transmitNum,publishtime ");
			strSql.Append(" FROM noveltyTb ");
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
			parameters[0].Value = "noveltyTb";
			parameters[1].Value = "noveltyID";
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

