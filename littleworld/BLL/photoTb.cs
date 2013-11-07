using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using littleworld.Model;
namespace littleworld.BLL
{
	/// <summary>
	/// photoTb
	/// </summary>
	public partial class photoTb
	{
		private readonly littleworld.DAL.photoTb dal=new littleworld.DAL.photoTb();
		public photoTb()
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
		public bool Exists(int photoID)
		{
			return dal.Exists(photoID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(littleworld.Model.photoTb model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(littleworld.Model.photoTb model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int photoID)
		{
			
			return dal.Delete(photoID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string photoIDlist )
		{
			return dal.DeleteList(photoIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public littleworld.Model.photoTb GetModel(int photoID)
		{
			
			return dal.GetModel(photoID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public littleworld.Model.photoTb GetModelByCache(int photoID)
		{
			
			string CacheKey = "photoTbModel-" + photoID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(photoID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (littleworld.Model.photoTb)objModel;
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
		public List<littleworld.Model.photoTb> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<littleworld.Model.photoTb> DataTableToList(DataTable dt)
		{
			List<littleworld.Model.photoTb> modelList = new List<littleworld.Model.photoTb>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				littleworld.Model.photoTb model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new littleworld.Model.photoTb();
					if(dt.Rows[n]["photoID"]!=null && dt.Rows[n]["photoID"].ToString()!="")
					{
						model.photoID=int.Parse(dt.Rows[n]["photoID"].ToString());
					}
					if(dt.Rows[n]["ownID"]!=null && dt.Rows[n]["ownID"].ToString()!="")
					{
						model.ownID=int.Parse(dt.Rows[n]["ownID"].ToString());
					}
					if(dt.Rows[n]["description"]!=null && dt.Rows[n]["description"].ToString()!="")
					{
					model.description=dt.Rows[n]["description"].ToString();
					}
					if(dt.Rows[n]["imgUrl"]!=null && dt.Rows[n]["imgUrl"].ToString()!="")
					{
					model.imgUrl=dt.Rows[n]["imgUrl"].ToString();
					}
					if(dt.Rows[n]["photoGroupID"]!=null && dt.Rows[n]["photoGroupID"].ToString()!="")
					{
						model.photoGroupID=int.Parse(dt.Rows[n]["photoGroupID"].ToString());
					}
					if(dt.Rows[n]["creatTime"]!=null && dt.Rows[n]["creatTime"].ToString()!="")
					{
						model.creatTime=DateTime.Parse(dt.Rows[n]["creatTime"].ToString());
					}
					if(dt.Rows[n]["littleImgUrl"]!=null && dt.Rows[n]["littleImgUrl"].ToString()!="")
					{
					model.littleImgUrl=dt.Rows[n]["littleImgUrl"].ToString();
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

