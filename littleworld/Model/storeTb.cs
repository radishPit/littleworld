using System;
namespace littleworld.Model
{
	/// <summary>
	/// storeTb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class storeTb
	{
		public storeTb()
		{}
		#region Model
		private int _id;
		private int _noveltyid;
		private int _storerid;
		private string _title;
		private string _state;
		private DateTime? _storetime;
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
		public int storerID
		{
			set{ _storerid=value;}
			get{return _storerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string state
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? storeTime
		{
			set{ _storetime=value;}
			get{return _storetime;}
		}
		#endregion Model

	}
}

