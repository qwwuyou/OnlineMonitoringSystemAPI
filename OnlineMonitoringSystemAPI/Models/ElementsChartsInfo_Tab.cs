using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    [Serializable]
    public class ElementsChartsInfo_Tab
    {
        public ElementsChartsInfo_Tab() { }

   
        private string _ItemID;
        private decimal? _displayareamax;
        private decimal? _displayareamin;
        private decimal? _alarmareamax;
        private decimal? _alarmareamin;
        
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

        public decimal? DisplayAreaMax
        {
            set { _displayareamax = value; }
            get { return _displayareamax; }
        }

        public decimal? DisplayAreaMin
        {
            set { _displayareamin = value; }
            get { return _displayareamin; }
        }

        public decimal? AlarmAreaMax
        {
            set { _alarmareamax = value; }
            get { return _alarmareamax; }
        }

        public decimal? AlarmAreaMin
        {
            set { _alarmareamin = value; }
            get { return _alarmareamin; }
        }
        
    }
}