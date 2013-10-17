using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using littleworld.Model;
namespace littleworld.BLL
{
	/// <summary>
	/// noticeTb
	/// </summary>
	public partial class noticeTb
	{
		private readonly littleworld.DAL.noticeTb dal=new littleworld.DAL.noticeTb();
		public noticeTb()
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
		public bool Exists(int noticeID)
		{
			return dal.Exists(noticeID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(littleworld.Model.noticeTb model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(littleworld.Model.noticeTb model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int noticeID)
		{
			
			return dal.Delete(noticeID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string noticeIDlist )
		{
			return dal.DeleteList(noticeIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public littleworld.Model.noticeTb GetModel(int noticeID)
		{
			
			return dal.GetModel(noticeID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public littleworld.Model.noticeTb GetModelByCache(int noticeID)
		{
			
			string CacheKey = "noticeTbModel-" + noticeID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(noticeID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (littleworld.Model.noticeTb)objModel;
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
		public List<littleworld.Model.noticeTb> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<littleworld.Model.noticeTb> DataTableToList(DataTable dt)
		{
			List<littleworld.Model.noticeTb> modelList = new List<littleworld.Model.noticeTb>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				littleworld.Model.noticeTb model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new littleworld.Model.noticeTb();
					if(dt.Rows[n]["noticeID"]!=null && dt.Rows[n]["noticeID"].ToString()!="")
					{
						model.noticeID=int.Parse(dt.Rows[n]["noticeID"].ToString());
					}
					if(dt.Rows[n]["adminID"]!=null && dt.Rows[n]["adminID"].ToString()!="")
					{
						model.adminID=int.Parse(dt.Rows[n]["adminID"].ToString());
					}
					if(dt.Rows[n]["title"]!=null && dt.Rows[n]["title"].ToString()!="")
					{
					model.title=dt.Rows[n]["title"].ToString();
					}
					if(dt.Rows[n]["contents"]!=null && dt.Rows[n]["contents"].ToString()!="")
					{
					model.contents=dt.Rows[n]["contents"].ToString();
					}
					if(dt.Rows[n]["sentTime"]!=null && dt.Rows[n]["sentTime"].ToString()!="")
					{
						model.sentTime=DateTime.Parse(dt.Rows[n]["sentTime"].ToString());
					}
					if(dt.Rows[n]["state"]!=null && dt.Rows[n]["state"].ToString()!="")
					{
					model.state=dt.Rows[n]["state"].ToString();
					}
					if(dt.Rows[n]["receiveID"]!=null && dt.Rows[n]["receiveID"].ToString()!="")
					{
						model.receiveID=int.Parse(dt.Rows[n]["receiveID"].ToString());
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

