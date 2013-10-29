using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using littleworld.Model;
namespace littleworld.BLL
{
	/// <summary>
	/// LTreportTypeTb
	/// </summary>
	public partial class LTreportTypeTb
	{
		private readonly littleworld.DAL.LTreportTypeTb dal=new littleworld.DAL.LTreportTypeTb();
		public LTreportTypeTb()
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
		public bool Exists(int NreporterID)
		{
			return dal.Exists(NreporterID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(littleworld.Model.LTreportTypeTb model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(littleworld.Model.LTreportTypeTb model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int NreporterID)
		{
			
			return dal.Delete(NreporterID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string NreporterIDlist )
		{
			return dal.DeleteList(NreporterIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public littleworld.Model.LTreportTypeTb GetModel(int NreporterID)
		{
			
			return dal.GetModel(NreporterID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public littleworld.Model.LTreportTypeTb GetModelByCache(int NreporterID)
		{
			
			string CacheKey = "LTreportTypeTbModel-" + NreporterID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(NreporterID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (littleworld.Model.LTreportTypeTb)objModel;
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
		public List<littleworld.Model.LTreportTypeTb> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<littleworld.Model.LTreportTypeTb> DataTableToList(DataTable dt)
		{
			List<littleworld.Model.LTreportTypeTb> modelList = new List<littleworld.Model.LTreportTypeTb>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				littleworld.Model.LTreportTypeTb model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new littleworld.Model.LTreportTypeTb();
					if(dt.Rows[n]["NreporterID"]!=null && dt.Rows[n]["NreporterID"].ToString()!="")
					{
						model.NreporterID=int.Parse(dt.Rows[n]["NreporterID"].ToString());
					}
					if(dt.Rows[n]["NreporterName"]!=null && dt.Rows[n]["NreporterName"].ToString()!="")
					{
					model.NreporterName=dt.Rows[n]["NreporterName"].ToString();
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

