using System;
namespace littleworld.Model
{
	/// <summary>
	/// transmitTb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class transmitTb
	{
		public transmitTb()
		{}
		#region Model
		private int _id;
		private int _noveltyid;
		private int _transmiterid;
		private int? _power=1;
		private string _contents;
		private DateTime? _transmittime;
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
		public int transmiterID
		{
			set{ _transmiterid=value;}
			get{return _transmiterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? power
		{
			set{ _power=value;}
			get{return _power;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string contents
		{
			set{ _contents=value;}
			get{return _contents;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? transmitTime
		{
			set{ _transmittime=value;}
			get{return _transmittime;}
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

