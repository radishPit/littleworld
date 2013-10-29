using System;
namespace littleworld.Model
{
	/// <summary>
	/// LTsuppoterTb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class LTsuppoterTb
	{
		public LTsuppoterTb()
		{}
		#region Model
		private int _id;
		private int _noteid;
		private int _nsuppoterid;
		private DateTime _nsuppottime;
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
		public int NsuppoterID
		{
			set{ _nsuppoterid=value;}
			get{return _nsuppoterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime NsuppotTime
		{
			set{ _nsuppottime=value;}
			get{return _nsuppottime;}
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

