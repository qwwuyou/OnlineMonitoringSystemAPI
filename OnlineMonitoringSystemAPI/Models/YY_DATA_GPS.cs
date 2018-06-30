using System;
namespace Models
{
	/// <summary>
	/// YY_DATA_AUTO:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class YY_DATA_GPS
    {
		public YY_DATA_GPS()
		{}
		
		private string _stcd;
		private DateTime _tm;
		private DateTime? _downdate;
		private int? _nfoindex;
		private decimal? _longitude;
        private decimal? _latitude;
		private decimal? _altitude;
        private decimal? _accuracy;
        private decimal? _speed;
        private decimal? _bearing;
        private int _isrealtime;
        

        private int _loctype;
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
		/// 经度
		/// </summary>
		public decimal? Longitude
        {
			set{ _longitude = value;}
			get{return _longitude; }
		}
        /// <summary>
        /// 纬度
        /// </summary>
        public decimal? Latitude
        {
            set { _latitude = value; }
            get { return _latitude; }
        }
        /// <summary>
        /// 海拔
        /// </summary>
        public decimal? Altitude
        {
            set { _altitude = value; }
            get { return _altitude; }
        }
        /// <summary>
        /// 精度
        /// </summary>
        public decimal? Accuracy
        {
            set { _accuracy = value; }
            get { return _accuracy; }
        }

        /// <summary>
        /// 速度
        /// </summary>
        public decimal? Speed
        {
            set { _speed = value; }
            get { return _speed; }
        }
        /// <summary>
        /// 方位角
        /// </summary>
        public decimal? Bearing
        {
            set { _bearing = value; }
            get { return _bearing; }
        }


        /// <summary>
        /// 定位类型  0 gps  1北斗 2基站 
        /// </summary>
        public int LocType
        {
            set { _loctype = value; }
            get { return _loctype; }
        }

        /// <summary>
        /// 是否为实时数据  0缓存   1实时  
        /// </summary>
        public int IsRealTime
        {
            set { _isrealtime = value; }
            get { return _isrealtime; }
        }

    }
}

