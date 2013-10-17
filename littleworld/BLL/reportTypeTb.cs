using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using littleworld.Model;
namespace littleworld.BLL
{
	/// <summary>
	/// reportTypeTb
	/// </summary>
	public partial class reportTypeTb
	{
		private readonly littleworld.DAL.reportTypeTb dal=new littleworld.DAL.reportTypeTb();
		public reportTypeTb()
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
		public bool Exists(int reportTypeID)
		{
			return dal.Exists(reportTypeID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(littleworld.Model.reportTypeTb model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(littleworld.Model.reportTypeTb model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int reportTypeID)
		{
			
			return dal.Delete(reportTypeID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string reportTypeIDlist )
		{
			return dal.DeleteList(reportTypeIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public littleworld.Model.reportTypeTb GetModel(int reportTypeID)
		{
			
			return dal.GetModel(reportTypeID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public littleworld.Model.reportTypeTb GetModelByCache(int reportTypeID)
		{
			
			string CacheKey = "reportTypeTbModel-" + reportTypeID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(reportTypeID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (littleworld.Model.reportTypeTb)objModel;
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
		public List<littleworld.Model.reportTypeTb> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<littleworld.Model.reportTypeTb> DataTableToList(DataTable dt)
		{
			List<littleworld.Model.reportTypeTb> modelList = new List<littleworld.Model.reportTypeTb>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				littleworld.Model.reportTypeTb model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new littleworld.Model.reportTypeTb();
					if(dt.Rows[n]["reportTypeID"]!=null && dt.Rows[n]["reportTypeID"].ToString()!="")
					{
						model.reportTypeID=int.Parse(dt.Rows[n]["reportTypeID"].ToString());
					}
					if(dt.Rows[n]["reportTypeName"]!=null && dt.Rows[n]["reportTypeName"].ToString()!="")
					{
					model.reportTypeName=dt.Rows[n]["reportTypeName"].ToString();
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

