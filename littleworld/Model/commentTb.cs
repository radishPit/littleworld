using System;
namespace littleworld.Model
{
	/// <summary>
	/// commentTb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class commentTb
	{
		public commentTb()
		{}
		#region Model
		private int _id;
		private int _noveltyid;
		private int _commenterid;
		private string _contents;
		private DateTime? _commenttime;
		private int _parentid=1;
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
		public int commenterID
		{
			set{ _commenterid=value;}
			get{return _commenterid;}
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
		public DateTime? commentTime
		{
			set{ _commenttime=value;}
			get{return _commenttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int parentID
		{
			set{ _parentid=value;}
			get{return _parentid;}
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

