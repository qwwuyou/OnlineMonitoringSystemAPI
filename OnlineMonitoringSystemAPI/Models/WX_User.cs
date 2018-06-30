using System;
namespace Models
{
    /// <summary>
    /// WX_AlarmInfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class WX_User
    {
        public WX_User()
        { }

        #region Model
        private string _openid;
        private string _nickname;
        private int _sex;
        private string _province;
        private int _state;
        private string _email;
        
        public string OpenId
        {
            get { return _openid; }
            set { _openid = value; }
        }

        public string NickName
        {
            get { return _nickname; }
            set { _nickname = value; }
        }
        public string Province
        {
            get { return _province; }
            set { _province = value; }
        }

        public int Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        public int State
        {
            get { return _state; }
            set { _state = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        
        #endregion Model

    }
}