using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using littleworld.Model;
namespace littleworld.BLL
{
	/// <summary>
	/// interestTb
	/// </summary>
	public partial class interestTb
	{
		private readonly littleworld.DAL.interestTb dal=new littleworld.DAL.interestTb();
		public interestTb()
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
		public bool Exists(int interestID)
		{
			return dal.Exists(interestID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(littleworld.Model.interestTb model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(littleworld.Model.interestTb model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int interestID)
		{
			
			return dal.Delete(interestID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string interestIDlist )
		{
			return dal.DeleteList(interestIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public littleworld.Model.interestTb GetModel(int interestID)
		{
			
			return dal.GetModel(interestID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public littleworld.Model.interestTb GetModelByCache(int interestID)
		{
			
			string CacheKey = "interestTbModel-" + interestID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(interestID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (littleworld.Model.interestTb)objModel;
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
		public List<littleworld.Model.interestTb> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<littleworld.Model.interestTb> DataTableToList(DataTable dt)
		{
			List<littleworld.Model.interestTb> modelList = new List<littleworld.Model.interestTb>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				littleworld.Model.interestTb model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new littleworld.Model.interestTb();
					if(dt.Rows[n]["interestID"]!=null && dt.Rows[n]["interestID"].ToString()!="")
					{
						model.interestID=int.Parse(dt.Rows[n]["interestID"].ToString());
					}
					if(dt.Rows[n]["interestName"]!=null && dt.Rows[n]["interestName"].ToString()!="")
					{
					model.interestName=dt.Rows[n]["interestName"].ToString();
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

