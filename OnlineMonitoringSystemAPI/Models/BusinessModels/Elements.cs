using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public partial class Elements
    {
        public Elements(){}

        #region Model
        private string _ItemTypeID;
        private string _ItemType;
        private int _ItemTypeIndex;

        [DataMember]
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
        [DataMember]
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
        [DataMember]
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

        [DataMember]
        public List<YY_RTU_ITEM> ITEM
        { get; set; }
        #endregion
    }
}
