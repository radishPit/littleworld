using System;
namespace littleworld.Model
{
	/// <summary>
	/// noveltyTb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class noveltyTb
	{
		public noveltyTb()
		{}
		#region Model
		private int _noveltyid;
		private int _senderid;
		private string _contents;
		private string _state;
		private int? _hasimgs;
		private int? _typeid;
		private int? _commentnum;
		private int? _supportnum;
		private int? _reportnum;
		private int? _transmitnum;
		private DateTime? _publishtime;
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
		public int senderID
		{
			set{ _senderid=value;}
			get{return _senderid;}
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
		public string state
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? hasImgs
		{
			set{ _hasimgs=value;}
			get{return _hasimgs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? typeID
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? commentNum
		{
			set{ _commentnum=value;}
			get{return _commentnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? supportNum
		{
			set{ _supportnum=value;}
			get{return _supportnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? reportNum
		{
			set{ _reportnum=value;}
			get{return _reportnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? transmitNum
		{
			set{ _transmitnum=value;}
			get{return _transmitnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? publishtime
		{
			set{ _publishtime=value;}
			get{return _publishtime;}
		}
		#endregion Model

	}
}

