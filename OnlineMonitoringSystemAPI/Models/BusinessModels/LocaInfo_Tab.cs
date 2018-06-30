using System;
namespace Models
{
    /// <summary>
    /// LocaInfo_Tab:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
	public partial class LocaInfo_Tab
    {
		public LocaInfo_Tab()
		{}
        #region Model


        private string _stcd;
		private string _locamanager;
		private string _tel;
        private decimal _longitude;
        private decimal _latitude;
        private decimal _altitud;
        private string _address;
        private DateTime _addtime;

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
		public string LocaManager
        {
			set{ _locamanager = value;}
			get{return _locamanager; }
		}
		/// <summary>
		/// 
		/// </summary>
		public string Tel
        {
			set{ _tel = value;}
			get{return _tel; }
		}


        /// <summary>
		/// 
		/// </summary>
		public decimal Longitude
        {
            set { _longitude = value; }
            get { return _longitude; }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal Latitude
        {
            set { _latitude = value; }
            get { return _latitude; }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal Altitud
        {
            set { _altitud = value; }
            get { return _altitud; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime AddTime
        {
            set { _addtime = value; }
            get { return _addtime; }
        }
        #endregion Model
    }
}

