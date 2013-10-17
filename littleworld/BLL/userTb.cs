using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using littleworld.Model;
namespace littleworld.BLL
{
	/// <summary>
	/// userTb
	/// </summary>
	public partial class userTb
	{
		private readonly littleworld.DAL.userTb dal=new littleworld.DAL.userTb();
		public userTb()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int userID)
		{
			return dal.Exists(userID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(littleworld.Model.userTb model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(littleworld.Model.userTb model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int userID)
		{
			
			return dal.Delete(userID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string userIDlist )
		{
			return dal.DeleteList(userIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public littleworld.Model.userTb GetModel(int userID)
		{
			
			return dal.GetModel(userID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public littleworld.Model.userTb GetModelByCache(int userID)
		{
			
			string CacheKey = "userTbModel-" + userID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(userID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (littleworld.Model.userTb)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<littleworld.Model.userTb> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<littleworld.Model.userTb> DataTableToList(DataTable dt)
		{
			List<littleworld.Model.userTb> modelList = new List<littleworld.Model.userTb>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				littleworld.Model.userTb model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new littleworld.Model.userTb();
					if(dt.Rows[n]["userID"]!=null && dt.Rows[n]["userID"].ToString()!="")
					{
						model.userID=int.Parse(dt.Rows[n]["userID"].ToString());
					}
					if(dt.Rows[n]["userName"]!=null && dt.Rows[n]["userName"].ToString()!="")
					{
					model.userName=dt.Rows[n]["userName"].ToString();
					}
					if(dt.Rows[n]["userEmail"]!=null && dt.Rows[n]["userEmail"].ToString()!="")
					{
					model.userEmail=dt.Rows[n]["userEmail"].ToString();
					}
					if(dt.Rows[n]["userPwd"]!=null && dt.Rows[n]["userPwd"].ToString()!="")
					{
					model.userPwd=dt.Rows[n]["userPwd"].ToString();
					}
					if(dt.Rows[n]["headImgUrl"]!=null && dt.Rows[n]["headImgUrl"].ToString()!="")
					{
					model.headImgUrl=dt.Rows[n]["headImgUrl"].ToString();
					}
					if(dt.Rows[n]["sex"]!=null && dt.Rows[n]["sex"].ToString()!="")
					{
					model.sex=dt.Rows[n]["sex"].ToString();
					}
					if(dt.Rows[n]["addr"]!=null && dt.Rows[n]["addr"].ToString()!="")
					{
					model.addr=dt.Rows[n]["addr"].ToString();
					}
					if(dt.Rows[n]["age"]!=null && dt.Rows[n]["age"].ToString()!="")
					{
						model.age=int.Parse(dt.Rows[n]["age"].ToString());
					}
					if(dt.Rows[n]["primarySchool"]!=null && dt.Rows[n]["primarySchool"].ToString()!="")
					{
					model.primarySchool=dt.Rows[n]["primarySchool"].ToString();
					}
					if(dt.Rows[n]["juniorSchool"]!=null && dt.Rows[n]["juniorSchool"].ToString()!="")
					{
					model.juniorSchool=dt.Rows[n]["juniorSchool"].ToString();
					}
					if(dt.Rows[n]["highSchool"]!=null && dt.Rows[n]["highSchool"].ToString()!="")
					{
					model.highSchool=dt.Rows[n]["highSchool"].ToString();
					}
					if(dt.Rows[n]["collegeSchool"]!=null && dt.Rows[n]["collegeSchool"].ToString()!="")
					{
					model.collegeSchool=dt.Rows[n]["collegeSchool"].ToString();
					}
					if(dt.Rows[n]["interstID"]!=null && dt.Rows[n]["interstID"].ToString()!="")
					{
						model.interstID=int.Parse(dt.Rows[n]["interstID"].ToString());
					}
					if(dt.Rows[n]["state"]!=null && dt.Rows[n]["state"].ToString()!="")
					{
					model.state=dt.Rows[n]["state"].ToString();
					}
					if(dt.Rows[n]["groupID"]!=null && dt.Rows[n]["groupID"].ToString()!="")
					{
						model.groupID=int.Parse(dt.Rows[n]["groupID"].ToString());
					}
					if(dt.Rows[n]["reprotNum"]!=null && dt.Rows[n]["reprotNum"].ToString()!="")
					{
						model.reprotNum=int.Parse(dt.Rows[n]["reprotNum"].ToString());
					}
					if(dt.Rows[n]["skinID"]!=null && dt.Rows[n]["skinID"].ToString()!="")
					{
						model.skinID=int.Parse(dt.Rows[n]["skinID"].ToString());
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

