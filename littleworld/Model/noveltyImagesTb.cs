using System;
namespace littleworld.Model
{
	/// <summary>
	/// noveltyImagesTb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class noveltyImagesTb
	{
		public noveltyImagesTb()
		{}
		#region Model
		private int _id;
		private int _noveltyid;
		private string _imgurl;
		private string _smallimgurl;
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
		public string imgUrl
		{
			set{ _imgurl=value;}
			get{return _imgurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string smallImgUrl
		{
			set{ _smallimgurl=value;}
			get{return _smallimgurl;}
		}
		#endregion Model

	}
}

