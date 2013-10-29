using System;
namespace littleworld.Model
{
	/// <summary>
	/// LTstoreTb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class LTstoreTb
	{
		public LTstoreTb()
		{}
		#region Model
		private int _id;
		private int _noteid;
		private int _storerid;
		private DateTime _storetime;
		private int _state;
		private string _cause;
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
		public int noteID
		{
			set{ _noteid=value;}
			get{return _noteid;}
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
		public DateTime storeTime
		{
			set{ _storetime=value;}
			get{return _storetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int state
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cause
		{
			set{ _cause=value;}
			get{return _cause;}
		}
		#endregion Model

	}
}

