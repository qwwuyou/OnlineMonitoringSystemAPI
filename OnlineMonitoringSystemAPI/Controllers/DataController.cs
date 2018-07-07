using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Models;
namespace OnlineMonitoringSystemAPI.Controllers
{
    public class DataController : ApiController
    {

        DataAccess._51Data dt = new DataAccess._51Data();

        /// <summary>
        /// 根据监测元素ID获得数据
        /// </summary>
        /// <param name="Parameter">参数类</param>
        /// <returns></returns>
        [HttpPost]
        public List<YY_DATA_AUTO> GetDataForElements(GetDataForElementsParameter Parameter)
        {
            return dt.Select<YY_DATA_AUTO>("YY_DATA_AUTO", new string[] { "*" }, " where itemID='"+ Parameter.ElementID + "' and TM>='"+ Parameter.StartTime + "' and TM<='"+ Parameter.EndTime + "'").ToList();
        }
        
        /// <summary>
        /// 得到所有站点各参数最新数据
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public List<YY_DATA_AUTO> GetAllNewData()
        {
            return dt.Select<YY_DATA_AUTO>("YY_DATA_AUTO a,(select ItemID, max(tm) TM from YY_DATA_AUTO group by ItemID) b", new string[] { " a.*" }, " where a.TM = b.TM and a.ItemID = b.ItemID order by a.TM").ToList();
        }

    }
}
