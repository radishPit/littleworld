using System;
namespace littleworld.Model
{
	/// <summary>
	/// webInfoTb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class webInfoTb
	{
		public webInfoTb()
		{}
		#region Model
		private int _id;
		private string _webname;
		private string _logourl;
		private DateTime? _lastpub;
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
		public string webName
		{
			set{ _webname=value;}
			get{return _webname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string logoURL
		{
			set{ _logourl=value;}
			get{return _logourl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? lastPub
		{
			set{ _lastpub=value;}
			get{return _lastpub;}
		}
		#endregion Model

	}
}

