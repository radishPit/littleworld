using System;
namespace littleworld.Model
{
	/// <summary>
	/// LTnoteTb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class LTnoteTb
	{
		public LTnoteTb()
		{}
		#region Model
		private int _noteid;
		private int _sectionid;
		private int _senderid;
		private string _ncontent;
		private int? _ncommentnum;
		private int? _nsupportnum;
		private int? _nreportnum;
		private int? _ntransmitnum;
		private DateTime? _npublishtime;
		private string _nstate;
		private int _parentnoteid;
		/// <summary>
		/// 
		/// </summary>
		public int noteID
		{
			set{ _noteid=value;}
			get{return _noteid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int sectionID
		{
			set{ _sectionid=value;}
			get{return _sectionid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int senderID
		{
			set{ _senderid=value;}
			get{return _senderid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NContent
		{
			set{ _ncontent=value;}
			get{return _ncontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? NCommentNum
		{
			set{ _ncommentnum=value;}
			get{return _ncommentnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? NSupportNum
		{
			set{ _nsupportnum=value;}
			get{return _nsupportnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? NReportNum
		{
			set{ _nreportnum=value;}
			get{return _nreportnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? NTransmitNum
		{
			set{ _ntransmitnum=value;}
			get{return _ntransmitnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? NPublishtime
		{
			set{ _npublishtime=value;}
			get{return _npublishtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NState
		{
			set{ _nstate=value;}
			get{return _nstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int parentNoteID
		{
			set{ _parentnoteid=value;}
			get{return _parentnoteid;}
		}
		#endregion Model

	}
}

