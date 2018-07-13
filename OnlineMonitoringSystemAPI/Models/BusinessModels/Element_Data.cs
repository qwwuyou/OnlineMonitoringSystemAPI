using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Models
{
    public class Element_Data
    {
        [DataMember]
        public YY_RTU_ITEM Elements
        { get; set; }
        [DataMember]
        public ElementsChartsInfo_Tab ChartsInfo
        { get; set; }
        [DataMember]
        public List<YY_DATA_AUTO> Data
        { get; set; }
    }
}