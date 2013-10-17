using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using littleworld.Model;
namespace littleworld.BLL
{
	/// <summary>
	/// adminTb
	/// </summary>
	public partial class adminTb
	{
		private readonly littleworld.DAL.adminTb dal=new littleworld.DAL.adminTb();
		public adminTb()
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
		public bool Exists(int adminID)
		{
			return dal.Exists(adminID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(littleworld.Model.adminTb model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(littleworld.Model.adminTb model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int adminID)
		{
			
			return dal.Delete(adminID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string adminIDlist )
		{
			return dal.DeleteList(adminIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public littleworld.Model.adminTb GetModel(int adminID)
		{
			
			return dal.GetModel(adminID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public littleworld.Model.adminTb GetModelByCache(int adminID)
		{
			
			string CacheKey = "adminTbModel-" + adminID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(adminID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (littleworld.Model.adminTb)objModel;
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
		public List<littleworld.Model.adminTb> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<littleworld.Model.adminTb> DataTableToList(DataTable dt)
		{
			List<littleworld.Model.adminTb> modelList = new List<littleworld.Model.adminTb>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				littleworld.Model.adminTb model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new littleworld.Model.adminTb();
					if(dt.Rows[n]["adminID"]!=null && dt.Rows[n]["adminID"].ToString()!="")
					{
						model.adminID=int.Parse(dt.Rows[n]["adminID"].ToString());
					}
					if(dt.Rows[n]["adminName"]!=null && dt.Rows[n]["adminName"].ToString()!="")
					{
					model.adminName=dt.Rows[n]["adminName"].ToString();
					}
					if(dt.Rows[n]["adminPwd"]!=null && dt.Rows[n]["adminPwd"].ToString()!="")
					{
					model.adminPwd=dt.Rows[n]["adminPwd"].ToString();
					}
					if(dt.Rows[n]["adminEmail"]!=null && dt.Rows[n]["adminEmail"].ToString()!="")
					{
					model.adminEmail=dt.Rows[n]["adminEmail"].ToString();
					}
					if(dt.Rows[n]["adminLevel"]!=null && dt.Rows[n]["adminLevel"].ToString()!="")
					{
						model.adminLevel=int.Parse(dt.Rows[n]["adminLevel"].ToString());
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

