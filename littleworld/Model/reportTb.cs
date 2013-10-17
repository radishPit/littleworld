using System;
namespace littleworld.Model
{
	/// <summary>
	/// reportTb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class reportTb
	{
		public reportTb()
		{}
		#region Model
		private int _id;
		private int _noveltyid;
		private int _reporterid;
		private DateTime? _reporttime;
		private int? _reporttypeid;
		private string _state;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int noveltyID
		{
			set{ _noveltyid=value;}
			get{return _noveltyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int reporterID
		{
			set{ _reporterid=value;}
			get{return _reporterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? reportTime
		{
			set{ _reporttime=value;}
			get{return _reporttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? reportTypeID
		{
			set{ _reporttypeid=value;}
			get{return _reporttypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string state
		{
			set{ _state=value;}
			get{return _state;}
		}
		#endregion Model

	}
}

