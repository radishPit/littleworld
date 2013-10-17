using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using littleworld.Model;
namespace littleworld.BLL
{
	/// <summary>
	/// commentTb
	/// </summary>
	public partial class commentTb
	{
		private readonly littleworld.DAL.commentTb dal=new littleworld.DAL.commentTb();
		public commentTb()
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
		public bool Exists(int ID)
		{
			return dal.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(littleworld.Model.commentTb model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(littleworld.Model.commentTb model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			return dal.Delete(ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			return dal.DeleteList(IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public littleworld.Model.commentTb GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public littleworld.Model.commentTb GetModelByCache(int ID)
		{
			
			string CacheKey = "commentTbModel-" + ID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(ID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (littleworld.Model.commentTb)objModel;
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
		public List<littleworld.Model.commentTb> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<littleworld.Model.commentTb> DataTableToList(DataTable dt)
		{
			List<littleworld.Model.commentTb> modelList = new List<littleworld.Model.commentTb>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				littleworld.Model.commentTb model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new littleworld.Model.commentTb();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["noveltyID"]!=null && dt.Rows[n]["noveltyID"].ToString()!="")
					{
						model.noveltyID=int.Parse(dt.Rows[n]["noveltyID"].ToString());
					}
					if(dt.Rows[n]["commenterID"]!=null && dt.Rows[n]["commenterID"].ToString()!="")
					{
						model.commenterID=int.Parse(dt.Rows[n]["commenterID"].ToString());
					}
					if(dt.Rows[n]["contents"]!=null && dt.Rows[n]["contents"].ToString()!="")
					{
					model.contents=dt.Rows[n]["contents"].ToString();
					}
					if(dt.Rows[n]["commentTime"]!=null && dt.Rows[n]["commentTime"].ToString()!="")
					{
						model.commentTime=DateTime.Parse(dt.Rows[n]["commentTime"].ToString());
					}
					if(dt.Rows[n]["parentID"]!=null && dt.Rows[n]["parentID"].ToString()!="")
					{
						model.parentID=int.Parse(dt.Rows[n]["parentID"].ToString());
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

