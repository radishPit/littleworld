using System;
namespace littleworld.Model
{
	/// <summary>
	/// eventsTb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class eventsTb
	{
		public eventsTb()
		{}
		#region Model
		private int _id;
		private int _operatorid;
		private string _operateaction;
		private string _operatecontent;
		private DateTime? _operatetime;
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
		public int operatorID
		{
			set{ _operatorid=value;}
			get{return _operatorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string operateAction
		{
			set{ _operateaction=value;}
			get{return _operateaction;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string operateContent
		{
			set{ _operatecontent=value;}
			get{return _operatecontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? operateTime
		{
			set{ _operatetime=value;}
			get{return _operatetime;}
		}
		#endregion Model

	}
}

