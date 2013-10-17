using System;
namespace littleworld.Model
{
	/// <summary>
	/// fansGroupTb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class fansGroupTb
	{
		public fansGroupTb()
		{}
		#region Model
		private int _fansgroupid;
		private string _groupname;
		private DateTime? _createtime;
		/// <summary>
		/// 
		/// </summary>
		public int fansGroupID
		{
			set{ _fansgroupid=value;}
			get{return _fansgroupid;}
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
		public DateTime? createTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		#endregion Model

	}
}

