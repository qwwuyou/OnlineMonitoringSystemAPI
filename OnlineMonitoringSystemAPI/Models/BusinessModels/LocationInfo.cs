using System;
using System.Collections.Generic;

namespace Models
{
	/// <summary>
	/// YY_RTU_Basic:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class LocationInfo
	{
		public LocationInfo()
		{}
		#region Model
		private string _stcd;
		private string _password;
		private string _nicename;
        private decimal? _longitude;
        private decimal? _latitude;
        public LocaInfo_Tab LocaInfo { get; set; }
        public List<Image_Tab> Image { get; set; }

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
		public string PassWord
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NiceName
		{
			set{ _nicename=value;}
			get{return _nicename;}
		}


        /// <summary>
		/// 
		/// </summary>
		public decimal? Longitude
        {
            set { _longitude = value; }
            get { return _longitude; }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal? Latitude
        {
            set { _latitude = value; }
            get { return _latitude; }
        }

        #endregion Model
    }
}

