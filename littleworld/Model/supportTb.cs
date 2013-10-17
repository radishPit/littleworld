using System;
namespace littleworld.Model
{
	/// <summary>
	/// supportTb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class supportTb
	{
		public supportTb()
		{}
		#region Model
		private int _id;
		private int _noveltyid;
		private int _suppoterid;
		private DateTime? _suppottime;
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
		public int suppoterID
		{
			set{ _suppoterid=value;}
			get{return _suppoterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? suppotTime
		{
			set{ _suppottime=value;}
			get{return _suppottime;}
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

