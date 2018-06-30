using System;
namespace Models
{
	/// <summary>
	/// YY_RTU_Basic:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Image_Tab
    {
		public Image_Tab()
		{}
		#region Model
		private string _stcd;
		private string _Imagepath;
		private string _remark;
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
		public string ImagePath
        {
			set{ _Imagepath = value;}
			get{return _Imagepath; }
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
        {
			set{ _remark = value;}
			get{return _remark; }
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

