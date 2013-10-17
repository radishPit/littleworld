using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using littleworld.Model;
namespace littleworld.BLL
{
	/// <summary>
	/// privateLetterTb
	/// </summary>
	public partial class privateLetterTb
	{
		private readonly littleworld.DAL.privateLetterTb dal=new littleworld.DAL.privateLetterTb();
		public privateLetterTb()
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
		public int  Add(littleworld.Model.privateLetterTb model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(littleworld.Model.privateLetterTb model)
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
		public littleworld.Model.privateLetterTb GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public littleworld.Model.privateLetterTb GetModelByCache(int ID)
		{
			
			string CacheKey = "privateLetterTbModel-" + ID;
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
			return (littleworld.Model.privateLetterTb)objModel;
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
		public List<littleworld.Model.privateLetterTb> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<littleworld.Model.privateLetterTb> DataTableToList(DataTable dt)
		{
			List<littleworld.Model.privateLetterTb> modelList = new List<littleworld.Model.privateLetterTb>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				littleworld.Model.privateLetterTb model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new littleworld.Model.privateLetterTb();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["senderID"]!=null && dt.Rows[n]["senderID"].ToString()!="")
					{
						model.senderID=int.Parse(dt.Rows[n]["senderID"].ToString());
					}
					if(dt.Rows[n]["receiveID"]!=null && dt.Rows[n]["receiveID"].ToString()!="")
					{
						model.receiveID=int.Parse(dt.Rows[n]["receiveID"].ToString());
					}
					if(dt.Rows[n]["contents"]!=null && dt.Rows[n]["contents"].ToString()!="")
					{
					model.contents=dt.Rows[n]["contents"].ToString();
					}
					if(dt.Rows[n]["sendTime"]!=null && dt.Rows[n]["sendTime"].ToString()!="")
					{
						model.sendTime=DateTime.Parse(dt.Rows[n]["sendTime"].ToString());
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

