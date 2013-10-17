using System;
namespace littleworld.Model
{
	/// <summary>
	/// privateLetterTb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class privateLetterTb
	{
		public privateLetterTb()
		{}
		#region Model
		private int _id;
		private int? _senderid;
		private int? _receiveid;
		private string _contents;
		private DateTime? _sendtime;
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
		public int? senderID
		{
			set{ _senderid=value;}
			get{return _senderid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? receiveID
		{
			set{ _receiveid=value;}
			get{return _receiveid;}
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
		public DateTime? sendTime
		{
			set{ _sendtime=value;}
			get{return _sendtime;}
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

