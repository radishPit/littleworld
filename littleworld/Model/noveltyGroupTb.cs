using System;
namespace littleworld.Model
{
	/// <summary>
	/// noveltyGroupTb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class noveltyGroupTb
	{
		public noveltyGroupTb()
		{}
		#region Model
		private int _noveltygroupid;
		private string _noveltygroupname;
		/// <summary>
		/// 
		/// </summary>
		public int noveltyGroupID
		{
			set{ _noveltygroupid=value;}
			get{return _noveltygroupid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string noveltyGroupName
		{
			set{ _noveltygroupname=value;}
			get{return _noveltygroupname;}
		}
		#endregion Model

	}
}

