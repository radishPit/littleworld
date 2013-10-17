using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace littleworld.DAL
{
	/// <summary>
	/// 数据访问类:userTb
	/// </summary>
	public partial class userTb
	{
		public userTb()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("userID", "userTb"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int userID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from userTb");
			strSql.Append(" where userID=@userID");
			SqlParameter[] parameters = {
					new SqlParameter("@userID", SqlDbType.Int,4)
};
			parameters[0].Value = userID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(littleworld.Model.userTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into userTb(");
			strSql.Append("userName,userEmail,userPwd,headImgUrl,sex,addr,age,primarySchool,juniorSchool,highSchool,collegeSchool,interstID,state,groupID,reprotNum,skinID)");
			strSql.Append(" values (");
			strSql.Append("@userName,@userEmail,@userPwd,@headImgUrl,@sex,@addr,@age,@primarySchool,@juniorSchool,@highSchool,@collegeSchool,@interstID,@state,@groupID,@reprotNum,@skinID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@userName", SqlDbType.NVarChar,50),
					new SqlParameter("@userEmail", SqlDbType.VarChar,50),
					new SqlParameter("@userPwd", SqlDbType.VarChar,50),
					new SqlParameter("@headImgUrl", SqlDbType.VarChar,500),
					new SqlParameter("@sex", SqlDbType.NVarChar,50),
					new SqlParameter("@addr", SqlDbType.NVarChar,50),
					new SqlParameter("@age", SqlDbType.Int,4),
					new SqlParameter("@primarySchool", SqlDbType.NVarChar,50),
					new SqlParameter("@juniorSchool", SqlDbType.NVarChar,50),
					new SqlParameter("@highSchool", SqlDbType.NVarChar,50),
					new SqlParameter("@collegeSchool", SqlDbType.NVarChar,50),
					new SqlParameter("@interstID", SqlDbType.Int,4),
					new SqlParameter("@state", SqlDbType.NVarChar,50),
					new SqlParameter("@groupID", SqlDbType.Int,4),
					new SqlParameter("@reprotNum", SqlDbType.Int,4),
					new SqlParameter("@skinID", SqlDbType.Int,4)};
			parameters[0].Value = model.userName;
			parameters[1].Value = model.userEmail;
			parameters[2].Value = model.userPwd;
			parameters[3].Value = model.headImgUrl;
			parameters[4].Value = model.sex;
			parameters[5].Value = model.addr;
			parameters[6].Value = model.age;
			parameters[7].Value = model.primarySchool;
			parameters[8].Value = model.juniorSchool;
			parameters[9].Value = model.highSchool;
			parameters[10].Value = model.collegeSchool;
			parameters[11].Value = model.interstID;
			parameters[12].Value = model.state;
			parameters[13].Value = model.groupID;
			parameters[14].Value = model.reprotNum;
			parameters[15].Value = model.skinID;

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
		public bool Update(littleworld.Model.userTb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update userTb set ");
			strSql.Append("userName=@userName,");
			strSql.Append("userEmail=@userEmail,");
			strSql.Append("userPwd=@userPwd,");
			strSql.Append("headImgUrl=@headImgUrl,");
			strSql.Append("sex=@sex,");
			strSql.Append("addr=@addr,");
			strSql.Append("age=@age,");
			strSql.Append("primarySchool=@primarySchool,");
			strSql.Append("juniorSchool=@juniorSchool,");
			strSql.Append("highSchool=@highSchool,");
			strSql.Append("collegeSchool=@collegeSchool,");
			strSql.Append("interstID=@interstID,");
			strSql.Append("state=@state,");
			strSql.Append("groupID=@groupID,");
			strSql.Append("reprotNum=@reprotNum,");
			strSql.Append("skinID=@skinID");
			strSql.Append(" where userID=@userID");
			SqlParameter[] parameters = {
					new SqlParameter("@userName", SqlDbType.NVarChar,50),
					new SqlParameter("@userEmail", SqlDbType.VarChar,50),
					new SqlParameter("@userPwd", SqlDbType.VarChar,50),
					new SqlParameter("@headImgUrl", SqlDbType.VarChar,500),
					new SqlParameter("@sex", SqlDbType.NVarChar,50),
					new SqlParameter("@addr", SqlDbType.NVarChar,50),
					new SqlParameter("@age", SqlDbType.Int,4),
					new SqlParameter("@primarySchool", SqlDbType.NVarChar,50),
					new SqlParameter("@juniorSchool", SqlDbType.NVarChar,50),
					new SqlParameter("@highSchool", SqlDbType.NVarChar,50),
					new SqlParameter("@collegeSchool", SqlDbType.NVarChar,50),
					new SqlParameter("@interstID", SqlDbType.Int,4),
					new SqlParameter("@state", SqlDbType.NVarChar,50),
					new SqlParameter("@groupID", SqlDbType.Int,4),
					new SqlParameter("@reprotNum", SqlDbType.Int,4),
					new SqlParameter("@skinID", SqlDbType.Int,4),
					new SqlParameter("@userID", SqlDbType.Int,4)};
			parameters[0].Value = model.userName;
			parameters[1].Value = model.userEmail;
			parameters[2].Value = model.userPwd;
			parameters[3].Value = model.headImgUrl;
			parameters[4].Value = model.sex;
			parameters[5].Value = model.addr;
			parameters[6].Value = model.age;
			parameters[7].Value = model.primarySchool;
			parameters[8].Value = model.juniorSchool;
			parameters[9].Value = model.highSchool;
			parameters[10].Value = model.collegeSchool;
			parameters[11].Value = model.interstID;
			parameters[12].Value = model.state;
			parameters[13].Value = model.groupID;
			parameters[14].Value = model.reprotNum;
			parameters[15].Value = model.skinID;
			parameters[16].Value = model.userID;

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
		public bool Delete(int userID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from userTb ");
			strSql.Append(" where userID=@userID");
			SqlParameter[] parameters = {
					new SqlParameter("@userID", SqlDbType.Int,4)
};
			parameters[0].Value = userID;

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
		public bool DeleteList(string userIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from userTb ");
			strSql.Append(" where userID in ("+userIDlist + ")  ");
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
		public littleworld.Model.userTb GetModel(int userID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 userID,userName,userEmail,userPwd,headImgUrl,sex,addr,age,primarySchool,juniorSchool,highSchool,collegeSchool,interstID,state,groupID,reprotNum,skinID from userTb ");
			strSql.Append(" where userID=@userID");
			SqlParameter[] parameters = {
					new SqlParameter("@userID", SqlDbType.Int,4)
};
			parameters[0].Value = userID;

			littleworld.Model.userTb model=new littleworld.Model.userTb();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["userID"]!=null && ds.Tables[0].Rows[0]["userID"].ToString()!="")
				{
					model.userID=int.Parse(ds.Tables[0].Rows[0]["userID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["userName"]!=null && ds.Tables[0].Rows[0]["userName"].ToString()!="")
				{
					model.userName=ds.Tables[0].Rows[0]["userName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["userEmail"]!=null && ds.Tables[0].Rows[0]["userEmail"].ToString()!="")
				{
					model.userEmail=ds.Tables[0].Rows[0]["userEmail"].ToString();
				}
				if(ds.Tables[0].Rows[0]["userPwd"]!=null && ds.Tables[0].Rows[0]["userPwd"].ToString()!="")
				{
					model.userPwd=ds.Tables[0].Rows[0]["userPwd"].ToString();
				}
				if(ds.Tables[0].Rows[0]["headImgUrl"]!=null && ds.Tables[0].Rows[0]["headImgUrl"].ToString()!="")
				{
					model.headImgUrl=ds.Tables[0].Rows[0]["headImgUrl"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sex"]!=null && ds.Tables[0].Rows[0]["sex"].ToString()!="")
				{
					model.sex=ds.Tables[0].Rows[0]["sex"].ToString();
				}
				if(ds.Tables[0].Rows[0]["addr"]!=null && ds.Tables[0].Rows[0]["addr"].ToString()!="")
				{
					model.addr=ds.Tables[0].Rows[0]["addr"].ToString();
				}
				if(ds.Tables[0].Rows[0]["age"]!=null && ds.Tables[0].Rows[0]["age"].ToString()!="")
				{
					model.age=int.Parse(ds.Tables[0].Rows[0]["age"].ToString());
				}
				if(ds.Tables[0].Rows[0]["primarySchool"]!=null && ds.Tables[0].Rows[0]["primarySchool"].ToString()!="")
				{
					model.primarySchool=ds.Tables[0].Rows[0]["primarySchool"].ToString();
				}
				if(ds.Tables[0].Rows[0]["juniorSchool"]!=null && ds.Tables[0].Rows[0]["juniorSchool"].ToString()!="")
				{
					model.juniorSchool=ds.Tables[0].Rows[0]["juniorSchool"].ToString();
				}
				if(ds.Tables[0].Rows[0]["highSchool"]!=null && ds.Tables[0].Rows[0]["highSchool"].ToString()!="")
				{
					model.highSchool=ds.Tables[0].Rows[0]["highSchool"].ToString();
				}
				if(ds.Tables[0].Rows[0]["collegeSchool"]!=null && ds.Tables[0].Rows[0]["collegeSchool"].ToString()!="")
				{
					model.collegeSchool=ds.Tables[0].Rows[0]["collegeSchool"].ToString();
				}
				if(ds.Tables[0].Rows[0]["interstID"]!=null && ds.Tables[0].Rows[0]["interstID"].ToString()!="")
				{
					model.interstID=int.Parse(ds.Tables[0].Rows[0]["interstID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["state"]!=null && ds.Tables[0].Rows[0]["state"].ToString()!="")
				{
					model.state=ds.Tables[0].Rows[0]["state"].ToString();
				}
				if(ds.Tables[0].Rows[0]["groupID"]!=null && ds.Tables[0].Rows[0]["groupID"].ToString()!="")
				{
					model.groupID=int.Parse(ds.Tables[0].Rows[0]["groupID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["reprotNum"]!=null && ds.Tables[0].Rows[0]["reprotNum"].ToString()!="")
				{
					model.reprotNum=int.Parse(ds.Tables[0].Rows[0]["reprotNum"].ToString());
				}
				if(ds.Tables[0].Rows[0]["skinID"]!=null && ds.Tables[0].Rows[0]["skinID"].ToString()!="")
				{
					model.skinID=int.Parse(ds.Tables[0].Rows[0]["skinID"].ToString());
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
			strSql.Append("select userID,userName,userEmail,userPwd,headImgUrl,sex,addr,age,primarySchool,juniorSchool,highSchool,collegeSchool,interstID,state,groupID,reprotNum,skinID ");
			strSql.Append(" FROM userTb ");
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
			strSql.Append(" userID,userName,userEmail,userPwd,headImgUrl,sex,addr,age,primarySchool,juniorSchool,highSchool,collegeSchool,interstID,state,groupID,reprotNum,skinID ");
			strSql.Append(" FROM userTb ");
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
			parameters[0].Value = "userTb";
			parameters[1].Value = "userID";
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

