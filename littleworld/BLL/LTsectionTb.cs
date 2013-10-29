using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using littleworld.Model;
namespace littleworld.BLL
{
	/// <summary>
	/// LTsectionTb
	/// </summary>
	public partial class LTsectionTb
	{
		private readonly littleworld.DAL.LTsectionTb dal=new littleworld.DAL.LTsectionTb();
		public LTsectionTb()
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
		public bool Exists(int sectionId)
		{
			return dal.Exists(sectionId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(littleworld.Model.LTsectionTb model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(littleworld.Model.LTsectionTb model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int sectionId)
		{
			
			return dal.Delete(sectionId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string sectionIdlist )
		{
			return dal.DeleteList(sectionIdlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public littleworld.Model.LTsectionTb GetModel(int sectionId)
		{
			
			return dal.GetModel(sectionId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public littleworld.Model.LTsectionTb GetModelByCache(int sectionId)
		{
			
			string CacheKey = "LTsectionTbModel-" + sectionId;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(sectionId);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (littleworld.Model.LTsectionTb)objModel;
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
		public List<littleworld.Model.LTsectionTb> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<littleworld.Model.LTsectionTb> DataTableToList(DataTable dt)
		{
			List<littleworld.Model.LTsectionTb> modelList = new List<littleworld.Model.LTsectionTb>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				littleworld.Model.LTsectionTb model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new littleworld.Model.LTsectionTb();
					if(dt.Rows[n]["sectionId"]!=null && dt.Rows[n]["sectionId"].ToString()!="")
					{
						model.sectionId=int.Parse(dt.Rows[n]["sectionId"].ToString());
					}
					if(dt.Rows[n]["sectionName"]!=null && dt.Rows[n]["sectionName"].ToString()!="")
					{
					model.sectionName=dt.Rows[n]["sectionName"].ToString();
					}
					if(dt.Rows[n]["sectionImg"]!=null && dt.Rows[n]["sectionImg"].ToString()!="")
					{
					model.sectionImg=dt.Rows[n]["sectionImg"].ToString();
					}
					if(dt.Rows[n]["sectionIntro"]!=null && dt.Rows[n]["sectionIntro"].ToString()!="")
					{
					model.sectionIntro=dt.Rows[n]["sectionIntro"].ToString();
					}
					if(dt.Rows[n]["adminID"]!=null && dt.Rows[n]["adminID"].ToString()!="")
					{
						model.adminID=int.Parse(dt.Rows[n]["adminID"].ToString());
					}
					if(dt.Rows[n]["state"]!=null && dt.Rows[n]["state"].ToString()!="")
					{
					model.state=dt.Rows[n]["state"].ToString();
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

