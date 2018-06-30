using System;
namespace Models
{
    /// <summary>
    /// WX_AlarmInfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class WX_AlarmInfo
    {
        public WX_AlarmInfo()
        { }

        #region Model
        private string _alarmid;
        private string _stcd;
        private string _itemid;
        private string _alarmcontent;
        private int _alarmlevel;
        //private string _openid;
        //private string _nickname;
        private int _state;
        private int _condition;
        private DateTime _alarmtime;
        private DateTime _sendtime;

        public string AlarmId
        {
            get { return _alarmid; }
            set { _alarmid = value; }
        }

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
        public string AlarmContent
        {
            get { return _alarmcontent; }
            set { _alarmcontent = value; }
        }

        public int AlarmLevel
        {
            get { return _alarmlevel; }
            set { _alarmlevel = value; }
        }
        
        //public string OpenId
        //{
        //    get { return _openid; }
        //    set { _openid = value; }
        //}

        //public string NickName
        //{
        //    get { return _nickname; }
        //    set { _nickname = value; }
        //}

        public int State
        {
            get { return _state; }
            set { _state = value; }
        }

        public int Condition
        {
            get { return _condition; }
            set { _condition= value; }
        }
        public DateTime AlarmTime
        {
            get { return _alarmtime; }
            set { _alarmtime = value; }
        }
        public DateTime SendTime
        {
            get { return _sendtime; }
            set { _sendtime = value; }
        }
        #endregion Model

    }
}
