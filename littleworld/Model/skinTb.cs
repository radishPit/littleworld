using System;
namespace littleworld.Model
{
	/// <summary>
	/// skinTb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class skinTb
	{
		public skinTb()
		{}
		#region Model
		private int _id;
		private string _skinname;
		private string _imgurl;
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
		public string skinName
		{
			set{ _skinname=value;}
			get{return _skinname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string imgUrl
		{
			set{ _imgurl=value;}
			get{return _imgurl;}
		}
		#endregion Model

	}
}

