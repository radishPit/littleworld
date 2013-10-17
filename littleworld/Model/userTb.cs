using System;
namespace littleworld.Model
{
	/// <summary>
	/// userTb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class userTb
	{
		public userTb()
		{}
		#region Model
		private int _userid;
		private string _username;
		private string _useremail;
		private string _userpwd;
		private string _headimgurl;
		private string _sex;
		private string _addr;
		private int? _age;
		private string _primaryschool;
		private string _juniorschool;
		private string _highschool;
		private string _collegeschool;
		private int? _interstid;
		private string _state;
		private int? _groupid;
		private int? _reprotnum;
		private int _skinid=1;
		/// <summary>
		/// 
		/// </summary>
		public int userID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string userName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string userEmail
		{
			set{ _useremail=value;}
			get{return _useremail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string userPwd
		{
			set{ _userpwd=value;}
			get{return _userpwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string headImgUrl
		{
			set{ _headimgurl=value;}
			get{return _headimgurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string addr
		{
			set{ _addr=value;}
			get{return _addr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? age
		{
			set{ _age=value;}
			get{return _age;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string primarySchool
		{
			set{ _primaryschool=value;}
			get{return _primaryschool;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string juniorSchool
		{
			set{ _juniorschool=value;}
			get{return _juniorschool;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string highSchool
		{
			set{ _highschool=value;}
			get{return _highschool;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string collegeSchool
		{
			set{ _collegeschool=value;}
			get{return _collegeschool;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? interstID
		{
			set{ _interstid=value;}
			get{return _interstid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string state
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? groupID
		{
			set{ _groupid=value;}
			get{return _groupid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? reprotNum
		{
			set{ _reprotnum=value;}
			get{return _reprotnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int skinID
		{
			set{ _skinid=value;}
			get{return _skinid;}
		}
		#endregion Model

	}
}

