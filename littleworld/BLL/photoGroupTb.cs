using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using littleworld.Model;
namespace littleworld.BLL
{
	/// <summary>
	/// photoGroupTb
	/// </summary>
	public partial class photoGroupTb
	{
		private readonly littleworld.DAL.photoGroupTb dal=new littleworld.DAL.photoGroupTb();
		public photoGroupTb()
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
		public bool Exists(int photoGroupID)
		{
			return dal.Exists(photoGroupID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(littleworld.Model.photoGroupTb model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(littleworld.Model.photoGroupTb model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int photoGroupID)
		{
			
			return dal.Delete(photoGroupID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string photoGroupIDlist )
		{
			return dal.DeleteList(photoGroupIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public littleworld.Model.photoGroupTb GetModel(int photoGroupID)
		{
			
			return dal.GetModel(photoGroupID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public littleworld.Model.photoGroupTb GetModelByCache(int photoGroupID)
		{
			
			string CacheKey = "photoGroupTbModel-" + photoGroupID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(photoGroupID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (littleworld.Model.photoGroupTb)objModel;
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
		public List<littleworld.Model.photoGroupTb> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<littleworld.Model.photoGroupTb> DataTableToList(DataTable dt)
		{
			List<littleworld.Model.photoGroupTb> modelList = new List<littleworld.Model.photoGroupTb>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				littleworld.Model.photoGroupTb model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new littleworld.Model.photoGroupTb();
					if(dt.Rows[n]["photoGroupID"]!=null && dt.Rows[n]["photoGroupID"].ToString()!="")
					{
						model.photoGroupID=int.Parse(dt.Rows[n]["photoGroupID"].ToString());
					}
					if(dt.Rows[n]["groupName"]!=null && dt.Rows[n]["groupName"].ToString()!="")
					{
					model.groupName=dt.Rows[n]["groupName"].ToString();
					}
					if(dt.Rows[n]["ownID"]!=null && dt.Rows[n]["ownID"].ToString()!="")
					{
						model.ownID=int.Parse(dt.Rows[n]["ownID"].ToString());
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

