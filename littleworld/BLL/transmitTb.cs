using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using littleworld.Model;
namespace littleworld.BLL
{
	/// <summary>
	/// transmitTb
	/// </summary>
	public partial class transmitTb
	{
		private readonly littleworld.DAL.transmitTb dal=new littleworld.DAL.transmitTb();
		public transmitTb()
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
		public int  Add(littleworld.Model.transmitTb model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(littleworld.Model.transmitTb model)
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
		public littleworld.Model.transmitTb GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public littleworld.Model.transmitTb GetModelByCache(int ID)
		{
			
			string CacheKey = "transmitTbModel-" + ID;
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
			return (littleworld.Model.transmitTb)objModel;
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
		public List<littleworld.Model.transmitTb> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<littleworld.Model.transmitTb> DataTableToList(DataTable dt)
		{
			List<littleworld.Model.transmitTb> modelList = new List<littleworld.Model.transmitTb>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				littleworld.Model.transmitTb model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new littleworld.Model.transmitTb();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["noveltyID"]!=null && dt.Rows[n]["noveltyID"].ToString()!="")
					{
						model.noveltyID=int.Parse(dt.Rows[n]["noveltyID"].ToString());
					}
					if(dt.Rows[n]["transmiterID"]!=null && dt.Rows[n]["transmiterID"].ToString()!="")
					{
						model.transmiterID=int.Parse(dt.Rows[n]["transmiterID"].ToString());
					}
					if(dt.Rows[n]["power"]!=null && dt.Rows[n]["power"].ToString()!="")
					{
						model.power=int.Parse(dt.Rows[n]["power"].ToString());
					}
					if(dt.Rows[n]["contents"]!=null && dt.Rows[n]["contents"].ToString()!="")
					{
					model.contents=dt.Rows[n]["contents"].ToString();
					}
					if(dt.Rows[n]["transmitTime"]!=null && dt.Rows[n]["transmitTime"].ToString()!="")
					{
						model.transmitTime=DateTime.Parse(dt.Rows[n]["transmitTime"].ToString());
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

