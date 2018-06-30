﻿using System;
namespace Models
{
	/// <summary>
	/// YY_DATA_AUTO:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class YY_DATA_AUTO 
    {
		public YY_DATA_AUTO()
		{}
		
		private string _stcd;
		private string _itemid;
		private DateTime _tm;
		private DateTime? _downdate;
		private int? _nfoindex;
		private decimal? _datavalue;
        private decimal? _correctionvalue;
		private int? _datatype;
        private string _sttype;
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
		public string ItemID
		{
			set{ _itemid=value;}
			get{return _itemid;}
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
		public decimal? DATAVALUE
		{
			set{ _datavalue=value;}
			get{return _datavalue;}
		}
        /// <summary>
        /// 
        /// </summary>
        public decimal? CorrectionVALUE
        {
            set { _correctionvalue = value; }
            get { return _correctionvalue; }
        }
		/// <summary>
		/// 
		/// </summary>
		public int? DATATYPE
		{
			set{ _datatype=value;}
			get{return _datatype;}
		}
        /// <summary>
        /// 
        /// </summary>
        public string STTYPE
        {
            set { _sttype = value; }
            get { return _sttype; }
        }

    }
}

