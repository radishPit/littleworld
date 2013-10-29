using System;
namespace littleworld.Model
{
	/// <summary>
	/// LTtransmitTb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class LTtransmitTb
	{
		public LTtransmitTb()
		{}
		#region Model
		private int _id;
		private int _noteid;
		private int _ntransmiterid;
		private string _contents;
		private DateTime _ntransmittime;
		private int _state;
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
		public int NtransmiterID
		{
			set{ _ntransmiterid=value;}
			get{return _ntransmiterid;}
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
		public DateTime NtransmitTime
		{
			set{ _ntransmittime=value;}
			get{return _ntransmittime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int state
		{
			set{ _state=value;}
			get{return _state;}
		}
		#endregion Model

	}
}

