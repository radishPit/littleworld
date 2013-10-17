using System;
namespace littleworld.Model
{
	/// <summary>
	/// noticeTb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class noticeTb
	{
		public noticeTb()
		{}
		#region Model
		private int _noticeid;
		private int _adminid;
		private string _title;
		private string _contents;
		private DateTime? _senttime;
		private string _state;
		private int? _receiveid;
		/// <summary>
		/// 
		/// </summary>
		public int noticeID
		{
			set{ _noticeid=value;}
			get{return _noticeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int adminID
		{
			set{ _adminid=value;}
			get{return _adminid;}
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
		public string contents
		{
			set{ _contents=value;}
			get{return _contents;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? sentTime
		{
			set{ _senttime=value;}
			get{return _senttime;}
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
		public int? receiveID
		{
			set{ _receiveid=value;}
			get{return _receiveid;}
		}
		#endregion Model

	}
}

