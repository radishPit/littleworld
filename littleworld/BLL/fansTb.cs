using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using littleworld.Model;
namespace littleworld.BLL
{
	/// <summary>
	/// fansTb
	/// </summary>
	public partial class fansTb
	{
		private readonly littleworld.DAL.fansTb dal=new littleworld.DAL.fansTb();
		public fansTb()
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
		public int  Add(littleworld.Model.fansTb model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(littleworld.Model.fansTb model)
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
		public littleworld.Model.fansTb GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public littleworld.Model.fansTb GetModelByCache(int ID)
		{
			
			string CacheKey = "fansTbModel-" + ID;
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
			return (littleworld.Model.fansTb)objModel;
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
		public List<littleworld.Model.fansTb> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<littleworld.Model.fansTb> DataTableToList(DataTable dt)
		{
			List<littleworld.Model.fansTb> modelList = new List<littleworld.Model.fansTb>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				littleworld.Model.fansTb model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new littleworld.Model.fansTb();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["ownID"]!=null && dt.Rows[n]["ownID"].ToString()!="")
					{
						model.ownID=int.Parse(dt.Rows[n]["ownID"].ToString());
					}
					if(dt.Rows[n]["ownedID"]!=null && dt.Rows[n]["ownedID"].ToString()!="")
					{
						model.ownedID=int.Parse(dt.Rows[n]["ownedID"].ToString());
					}
					if(dt.Rows[n]["ownedName"]!=null && dt.Rows[n]["ownedName"].ToString()!="")
					{
					model.ownedName=dt.Rows[n]["ownedName"].ToString();
					}
					if(dt.Rows[n]["groupID"]!=null && dt.Rows[n]["groupID"].ToString()!="")
					{
						model.groupID=int.Parse(dt.Rows[n]["groupID"].ToString());
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

