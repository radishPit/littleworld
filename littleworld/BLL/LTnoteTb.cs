using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using littleworld.Model;
namespace littleworld.BLL
{
	/// <summary>
	/// LTnoteTb
	/// </summary>
	public partial class LTnoteTb
	{
		private readonly littleworld.DAL.LTnoteTb dal=new littleworld.DAL.LTnoteTb();
		public LTnoteTb()
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
		public bool Exists(int noteID)
		{
			return dal.Exists(noteID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(littleworld.Model.LTnoteTb model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(littleworld.Model.LTnoteTb model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int noteID)
		{
			
			return dal.Delete(noteID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string noteIDlist )
		{
			return dal.DeleteList(noteIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public littleworld.Model.LTnoteTb GetModel(int noteID)
		{
			
			return dal.GetModel(noteID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public littleworld.Model.LTnoteTb GetModelByCache(int noteID)
		{
			
			string CacheKey = "LTnoteTbModel-" + noteID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(noteID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (littleworld.Model.LTnoteTb)objModel;
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
		public List<littleworld.Model.LTnoteTb> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<littleworld.Model.LTnoteTb> DataTableToList(DataTable dt)
		{
			List<littleworld.Model.LTnoteTb> modelList = new List<littleworld.Model.LTnoteTb>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				littleworld.Model.LTnoteTb model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new littleworld.Model.LTnoteTb();
					if(dt.Rows[n]["noteID"]!=null && dt.Rows[n]["noteID"].ToString()!="")
					{
						model.noteID=int.Parse(dt.Rows[n]["noteID"].ToString());
					}
					if(dt.Rows[n]["sectionID"]!=null && dt.Rows[n]["sectionID"].ToString()!="")
					{
						model.sectionID=int.Parse(dt.Rows[n]["sectionID"].ToString());
					}
					if(dt.Rows[n]["senderID"]!=null && dt.Rows[n]["senderID"].ToString()!="")
					{
						model.senderID=int.Parse(dt.Rows[n]["senderID"].ToString());
					}
					if(dt.Rows[n]["NContent"]!=null && dt.Rows[n]["NContent"].ToString()!="")
					{
					model.NContent=dt.Rows[n]["NContent"].ToString();
					}
					if(dt.Rows[n]["NCommentNum"]!=null && dt.Rows[n]["NCommentNum"].ToString()!="")
					{
						model.NCommentNum=int.Parse(dt.Rows[n]["NCommentNum"].ToString());
					}
					if(dt.Rows[n]["NSupportNum"]!=null && dt.Rows[n]["NSupportNum"].ToString()!="")
					{
						model.NSupportNum=int.Parse(dt.Rows[n]["NSupportNum"].ToString());
					}
					if(dt.Rows[n]["NReportNum"]!=null && dt.Rows[n]["NReportNum"].ToString()!="")
					{
						model.NReportNum=int.Parse(dt.Rows[n]["NReportNum"].ToString());
					}
					if(dt.Rows[n]["NTransmitNum"]!=null && dt.Rows[n]["NTransmitNum"].ToString()!="")
					{
						model.NTransmitNum=int.Parse(dt.Rows[n]["NTransmitNum"].ToString());
					}
					if(dt.Rows[n]["NPublishtime"]!=null && dt.Rows[n]["NPublishtime"].ToString()!="")
					{
						model.NPublishtime=DateTime.Parse(dt.Rows[n]["NPublishtime"].ToString());
					}
					if(dt.Rows[n]["NState"]!=null && dt.Rows[n]["NState"].ToString()!="")
					{
					model.NState=dt.Rows[n]["NState"].ToString();
					}
					if(dt.Rows[n]["parentNoteID"]!=null && dt.Rows[n]["parentNoteID"].ToString()!="")
					{
						model.parentNoteID=int.Parse(dt.Rows[n]["parentNoteID"].ToString());
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

