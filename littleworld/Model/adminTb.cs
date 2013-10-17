using System;
namespace littleworld.Model
{
	/// <summary>
	/// adminTb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class adminTb
	{
		public adminTb()
		{}
		#region Model
		private int _adminid;
		private string _adminname;
		private string _adminpwd;
		private string _adminemail;
		private int _adminlevel;
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
		public string adminName
		{
			set{ _adminname=value;}
			get{return _adminname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string adminPwd
		{
			set{ _adminpwd=value;}
			get{return _adminpwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string adminEmail
		{
			set{ _adminemail=value;}
			get{return _adminemail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int adminLevel
		{
			set{ _adminlevel=value;}
			get{return _adminlevel;}
		}
		#endregion Model

	}
}

