using System;
namespace littleworld.Model
{
	/// <summary>
	/// reportTypeTb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class reportTypeTb
	{
		public reportTypeTb()
		{}
		#region Model
		private int _reporttypeid;
		private string _reporttypename;
		/// <summary>
		/// 
		/// </summary>
		public int reportTypeID
		{
			set{ _reporttypeid=value;}
			get{return _reporttypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string reportTypeName
		{
			set{ _reporttypename=value;}
			get{return _reporttypename;}
		}
		#endregion Model

	}
}

