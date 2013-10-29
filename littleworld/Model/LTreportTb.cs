using System;
namespace littleworld.Model
{
	/// <summary>
	/// LTreportTb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class LTreportTb
	{
		public LTreportTb()
		{}
		#region Model
		private int _id;
		private int _noteid;
		private int _nreporterid;
		private DateTime _nreporttime;
		private int _nreporttypeid;
		private int _state;
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
		public int noteId
		{
			set{ _noteid=value;}
			get{return _noteid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int NreporterID
		{
			set{ _nreporterid=value;}
			get{return _nreporterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime NreportTime
		{
			set{ _nreporttime=value;}
			get{return _nreporttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int NreportTypeID
		{
			set{ _nreporttypeid=value;}
			get{return _nreporttypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int state
		{
			set{ _state=value;}
			get{return _state;}
		}
		#endregion Model

	}
}

