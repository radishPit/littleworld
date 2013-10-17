using System;
namespace littleworld.Model
{
	/// <summary>
	/// photoTb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class photoTb
	{
		public photoTb()
		{}
		#region Model
		private int _photoid;
		private int _ownid;
		private string _description;
		private string _imgurl;
		private int? _photogroupid;
		private DateTime? _creattime;
		/// <summary>
		/// 
		/// </summary>
		public int photoID
		{
			set{ _photoid=value;}
			get{return _photoid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ownID
		{
			set{ _ownid=value;}
			get{return _ownid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string description
		{
			set{ _description=value;}
			get{return _description;}
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
		public int? photoGroupID
		{
			set{ _photogroupid=value;}
			get{return _photogroupid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? creatTime
		{
			set{ _creattime=value;}
			get{return _creattime;}
		}
		#endregion Model

	}
}

