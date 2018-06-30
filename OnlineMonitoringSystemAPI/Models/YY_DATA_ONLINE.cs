using System;
namespace Models
{
	/// <summary>
	/// YY_DATA_AUTO:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class YY_DATA_ONLINE
    {
		public YY_DATA_ONLINE()
		{}
		
		private string _stcd;
		private DateTime _tm;
		private int _count;
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
        public int DATACOUNT
        {
            set { _count = value; }
            get { return _count; }
        }

    }
}

