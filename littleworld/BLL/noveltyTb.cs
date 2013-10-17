using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using littleworld.Model;
namespace littleworld.BLL
{
	/// <summary>
	/// noveltyTb
	/// </summary>
	public partial class noveltyTb
	{
		private readonly littleworld.DAL.noveltyTb dal=new littleworld.DAL.noveltyTb();
		public noveltyTb()
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
		public bool Exists(int noveltyID)
		{
			return dal.Exists(noveltyID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(littleworld.Model.noveltyTb model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(littleworld.Model.noveltyTb model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int noveltyID)
		{
			
			return dal.Delete(noveltyID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string noveltyIDlist )
		{
			return dal.DeleteList(noveltyIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public littleworld.Model.noveltyTb GetModel(int noveltyID)
		{
			
			return dal.GetModel(noveltyID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public littleworld.Model.noveltyTb GetModelByCache(int noveltyID)
		{
			
			string CacheKey = "noveltyTbModel-" + noveltyID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(noveltyID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (littleworld.Model.noveltyTb)objModel;
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
		public List<littleworld.Model.noveltyTb> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<littleworld.Model.noveltyTb> DataTableToList(DataTable dt)
		{
			List<littleworld.Model.noveltyTb> modelList = new List<littleworld.Model.noveltyTb>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				littleworld.Model.noveltyTb model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new littleworld.Model.noveltyTb();
					if(dt.Rows[n]["noveltyID"]!=null && dt.Rows[n]["noveltyID"].ToString()!="")
					{
						model.noveltyID=int.Parse(dt.Rows[n]["noveltyID"].ToString());
					}
					if(dt.Rows[n]["senderID"]!=null && dt.Rows[n]["senderID"].ToString()!="")
					{
						model.senderID=int.Parse(dt.Rows[n]["senderID"].ToString());
					}
					if(dt.Rows[n]["contents"]!=null && dt.Rows[n]["contents"].ToString()!="")
					{
					model.contents=dt.Rows[n]["contents"].ToString();
					}
					if(dt.Rows[n]["state"]!=null && dt.Rows[n]["state"].ToString()!="")
					{
					model.state=dt.Rows[n]["state"].ToString();
					}
					if(dt.Rows[n]["hasImgs"]!=null && dt.Rows[n]["hasImgs"].ToString()!="")
					{
						model.hasImgs=int.Parse(dt.Rows[n]["hasImgs"].ToString());
					}
					if(dt.Rows[n]["typeID"]!=null && dt.Rows[n]["typeID"].ToString()!="")
					{
						model.typeID=int.Parse(dt.Rows[n]["typeID"].ToString());
					}
					if(dt.Rows[n]["commentNum"]!=null && dt.Rows[n]["commentNum"].ToString()!="")
					{
						model.commentNum=int.Parse(dt.Rows[n]["commentNum"].ToString());
					}
					if(dt.Rows[n]["supportNum"]!=null && dt.Rows[n]["supportNum"].ToString()!="")
					{
						model.supportNum=int.Parse(dt.Rows[n]["supportNum"].ToString());
					}
					if(dt.Rows[n]["reportNum"]!=null && dt.Rows[n]["reportNum"].ToString()!="")
					{
						model.reportNum=int.Parse(dt.Rows[n]["reportNum"].ToString());
					}
					if(dt.Rows[n]["transmitNum"]!=null && dt.Rows[n]["transmitNum"].ToString()!="")
					{
						model.transmitNum=int.Parse(dt.Rows[n]["transmitNum"].ToString());
					}
					if(dt.Rows[n]["publishtime"]!=null && dt.Rows[n]["publishtime"].ToString()!="")
					{
						model.publishtime=DateTime.Parse(dt.Rows[n]["publishtime"].ToString());
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

