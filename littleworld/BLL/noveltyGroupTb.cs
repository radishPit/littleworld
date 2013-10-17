using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using littleworld.Model;
namespace littleworld.BLL
{
	/// <summary>
	/// noveltyGroupTb
	/// </summary>
	public partial class noveltyGroupTb
	{
		private readonly littleworld.DAL.noveltyGroupTb dal=new littleworld.DAL.noveltyGroupTb();
		public noveltyGroupTb()
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
		public bool Exists(int noveltyGroupID)
		{
			return dal.Exists(noveltyGroupID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(littleworld.Model.noveltyGroupTb model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(littleworld.Model.noveltyGroupTb model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int noveltyGroupID)
		{
			
			return dal.Delete(noveltyGroupID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string noveltyGroupIDlist )
		{
			return dal.DeleteList(noveltyGroupIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public littleworld.Model.noveltyGroupTb GetModel(int noveltyGroupID)
		{
			
			return dal.GetModel(noveltyGroupID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public littleworld.Model.noveltyGroupTb GetModelByCache(int noveltyGroupID)
		{
			
			string CacheKey = "noveltyGroupTbModel-" + noveltyGroupID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(noveltyGroupID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (littleworld.Model.noveltyGroupTb)objModel;
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
		public List<littleworld.Model.noveltyGroupTb> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<littleworld.Model.noveltyGroupTb> DataTableToList(DataTable dt)
		{
			List<littleworld.Model.noveltyGroupTb> modelList = new List<littleworld.Model.noveltyGroupTb>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				littleworld.Model.noveltyGroupTb model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new littleworld.Model.noveltyGroupTb();
					if(dt.Rows[n]["noveltyGroupID"]!=null && dt.Rows[n]["noveltyGroupID"].ToString()!="")
					{
						model.noveltyGroupID=int.Parse(dt.Rows[n]["noveltyGroupID"].ToString());
					}
					if(dt.Rows[n]["noveltyGroupName"]!=null && dt.Rows[n]["noveltyGroupName"].ToString()!="")
					{
					model.noveltyGroupName=dt.Rows[n]["noveltyGroupName"].ToString();
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

