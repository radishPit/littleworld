using System;
namespace littleworld.Model
{
	/// <summary>
	/// photoGroupTb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class photoGroupTb
	{
		public photoGroupTb()
		{}
		#region Model
		private int _photogroupid;
		private string _groupname;
		private int? _ownid;
		/// <summary>
		/// 
		/// </summary>
		public int photoGroupID
		{
			set{ _photogroupid=value;}
			get{return _photogroupid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string groupName
		{
			set{ _groupname=value;}
			get{return _groupname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ownID
		{
			set{ _ownid=value;}
			get{return _ownid;}
		}
		#endregion Model

	}
}

