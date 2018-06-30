using System;
namespace Models
{
    [Serializable]
    public partial class YY_ITEM_TI
    {
        public YY_ITEM_TI() { }

        #region Model
        private string _ItemTypeID;
        private string _ItemID;
        private int _ItemIndex;

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

        public string ItemID
        {
            get
            {
                return _ItemID;
            }

            set
            {
                _ItemID = value;
            }
        }

        /// <summary>
        /// 监测项索引
        /// </summary>
        public int ItemIndex
        {
            get
            {
                return _ItemIndex;
            }

            set
            {
                _ItemIndex = value;
            }
        }
        #endregion
    }
}
