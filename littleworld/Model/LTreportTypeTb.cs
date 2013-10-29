using System;
namespace littleworld.Model
{
	/// <summary>
	/// LTreportTypeTb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class LTreportTypeTb
	{
		public LTreportTypeTb()
		{}
		#region Model
		private int _nreporterid;
		private string _nreportername;
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
		public string NreporterName
		{
			set{ _nreportername=value;}
			get{return _nreportername;}
		}
		#endregion Model

	}
}

