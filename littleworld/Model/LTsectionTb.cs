using System;
namespace littleworld.Model
{
	/// <summary>
	/// LTsectionTb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class LTsectionTb
	{
		public LTsectionTb()
		{}
		#region Model
		private int _sectionid;
		private string _sectionname;
		private string _sectionimg;
		private string _sectionintro;
		private int _adminid;
		private string _state;
		/// <summary>
		/// 
		/// </summary>
		public int sectionId
		{
			set{ _sectionid=value;}
			get{return _sectionid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sectionName
		{
			set{ _sectionname=value;}
			get{return _sectionname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sectionImg
		{
			set{ _sectionimg=value;}
			get{return _sectionimg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sectionIntro
		{
			set{ _sectionintro=value;}
			get{return _sectionintro;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int adminID
		{
			set{ _adminid=value;}
			get{return _adminid;}
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

