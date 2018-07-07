using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Models
{
	/// <summary>
	/// YY_RTU_Basic:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[DataContract]
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

        [DataMember]
        public LocaInfo_Tab LocaInfo { get; set; }
        [DataMember]
        public List<Image_Tab> Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string STCD
		{
			set{ _stcd=value;}
			get{return _stcd;}
		}
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string PassWord
		{
			set{ _password=value;}
			get{return _password;}
		}
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string NiceName
		{
			set{ _nicename=value;}
			get{return _nicename;}
		}


        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public decimal? Longitude
        {
            set { _longitude = value; }
            get { return _longitude; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public decimal? Latitude
        {
            set { _latitude = value; }
            get { return _latitude; }
        }

        #endregion Model
    }
}

