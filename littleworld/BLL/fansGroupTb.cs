using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using littleworld.Model;
namespace littleworld.BLL
{
	/// <summary>
	/// fansGroupTb
	/// </summary>
	public partial class fansGroupTb
	{
		private readonly littleworld.DAL.fansGroupTb dal=new littleworld.DAL.fansGroupTb();
		public fansGroupTb()
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
		public bool Exists(int fansGroupID)
		{
			return dal.Exists(fansGroupID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(littleworld.Model.fansGroupTb model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(littleworld.Model.fansGroupTb model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int fansGroupID)
		{
			
			return dal.Delete(fansGroupID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string fansGroupIDlist )
		{
			return dal.DeleteList(fansGroupIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public littleworld.Model.fansGroupTb GetModel(int fansGroupID)
		{
			
			return dal.GetModel(fansGroupID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public littleworld.Model.fansGroupTb GetModelByCache(int fansGroupID)
		{
			
			string CacheKey = "fansGroupTbModel-" + fansGroupID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(fansGroupID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (littleworld.Model.fansGroupTb)objModel;
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
		public List<littleworld.Model.fansGroupTb> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<littleworld.Model.fansGroupTb> DataTableToList(DataTable dt)
		{
			List<littleworld.Model.fansGroupTb> modelList = new List<littleworld.Model.fansGroupTb>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				littleworld.Model.fansGroupTb model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new littleworld.Model.fansGroupTb();
					if(dt.Rows[n]["fansGroupID"]!=null && dt.Rows[n]["fansGroupID"].ToString()!="")
					{
						model.fansGroupID=int.Parse(dt.Rows[n]["fansGroupID"].ToString());
					}
					if(dt.Rows[n]["groupName"]!=null && dt.Rows[n]["groupName"].ToString()!="")
					{
					model.groupName=dt.Rows[n]["groupName"].ToString();
					}
					if(dt.Rows[n]["createTime"]!=null && dt.Rows[n]["createTime"].ToString()!="")
					{
						model.createTime=DateTime.Parse(dt.Rows[n]["createTime"].ToString());
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

