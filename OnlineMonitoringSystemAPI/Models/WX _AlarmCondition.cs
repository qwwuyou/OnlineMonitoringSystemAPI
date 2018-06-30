using System;
namespace Models
{
    /// <summary>
    /// WX_AlarmCondition:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class WX_AlarmCondition
    {
        public WX_AlarmCondition()
        { }

        #region Model
        private string _stcd;
        private string _itemid;
        private int _condition;
        private decimal _datavalue;
        private int _alarmlevel;
        

        public string STCD
        {
            get { return _stcd; }
            set { _stcd = value; }
        }
        public string ItemID
        {
            get { return _itemid; }
            set { _itemid = value; }
        }
        public int Condition
        {
            get { return _condition; }
            set { _condition = value; }
        }

        public decimal DATAVALUE
        {
            get { return _datavalue; }
            set { _datavalue = value; }
        }
        
        public int AlarmLevel
        {
            get { return _alarmlevel; }
            set { _alarmlevel = value; }
        }
        #endregion Model

    }
}

