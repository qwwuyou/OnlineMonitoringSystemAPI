﻿using System;
namespace Models
{
	/// <summary>
	/// YY_DATA_MANUAL:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class YY_DATA_MANUAL
	{
		public YY_DATA_MANUAL()
		{}
		#region Model
		private string _stcd;
		private DateTime _tm;
		private DateTime? _downdate;
		private int? _nfoindex;
		private string _datavalue;
		private int? _datatype;
		/// <summary>
		/// 
		/// </summary>
		public string STCD
		{
			set{ _stcd=value;}
			get{return _stcd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime TM
		{
			set{ _tm=value;}
			get{return _tm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DOWNDATE
		{
			set{ _downdate=value;}
			get{return _downdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? NFOINDEX
		{
			set{ _nfoindex=value;}
			get{return _nfoindex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DATAVALUE
		{
			set{ _datavalue=value;}
			get{return _datavalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DATATYPE
		{
			set{ _datatype=value;}
			get{return _datatype;}
		}
		#endregion Model

	}
}

