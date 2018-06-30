using System;
namespace Models
{
    [Serializable]
    public partial class YY_ITEMTYPE
    {
        public YY_ITEMTYPE(){}

        #region Model
        private string _ItemTypeID;
        private string _ItemType;
        private int _ItemTypeIndex;

        public string ItemTypeID
        {
            get
            {
                return _ItemTypeID;
            }

            set
            {
                _ItemTypeID = value;
            }
        }

        public string ItemType
        {
            get
            {
                return _ItemType;
            }

            set
            {
                _ItemType = value;
            }
        }

        /// <summary>
        /// 监测项类型的索引
        /// </summary>
        public int ItemTypeIndex
        {
            get
            {
                return _ItemTypeIndex;
            }

            set
            {
                _ItemTypeIndex = value;
            }
        }
        #endregion
    }
}
