using System;
namespace littleworld.Model
{
	/// <summary>
	/// interestTb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class interestTb
	{
		public interestTb()
		{}
		#region Model
		private int _interestid;
		private string _interestname;
		/// <summary>
		/// 
		/// </summary>
		public int interestID
		{
			set{ _interestid=value;}
			get{return _interestid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string interestName
		{
			set{ _interestname=value;}
			get{return _interestname;}
		}
		#endregion Model

	}
}

