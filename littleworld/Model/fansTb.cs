using System;
namespace littleworld.Model
{
	/// <summary>
	/// fansTb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class fansTb
	{
		public fansTb()
		{}
		#region Model
		private int _id;
		private int _ownid;
		private int _ownedid;
		private string _ownedname;
		private int? _groupid;
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
		public int ownID
		{
			set{ _ownid=value;}
			get{return _ownid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ownedID
		{
			set{ _ownedid=value;}
			get{return _ownedid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ownedName
		{
			set{ _ownedname=value;}
			get{return _ownedname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? groupID
		{
			set{ _groupid=value;}
			get{return _groupid;}
		}
		#endregion Model

	}
}

