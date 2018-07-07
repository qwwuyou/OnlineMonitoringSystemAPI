using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Models;

namespace OnlineMonitoringSystemAPI.Controllers
{
    public class ElementsController : ApiController
    {
        DataAccess._51Data dt = new DataAccess._51Data();

        /// <summary>
        /// 得到所有监测元素信息
        /// </summary>
        /// <param name="where">条件</param>
        /// <returns>监测元素列表</returns>
        [HttpPost]
        public List<YY_RTU_ITEM> GetAllElements()
        {
            return dt.Select<YY_RTU_ITEM>("YY_RTU_ITEM", new string[] { "*" }, "").ToList();
        }

        /// <summary>
        /// 得到监测元素类型
        /// </summary>
        [HttpPost]
        public List<YY_ITEMTYPE> GetElementsType()
        {
            return dt.Select<YY_ITEMTYPE>("YY_ITEMTYPE", new string[] { "*" }, " order by ItemTypeIndex").ToList();
        }

        /// <summary>
        /// 得到监测元素类型和包含的相关元素
        /// </summary>
        [HttpPost]
        public List<Elements> GetElements()
        {
            List<Elements> el = new List<Elements>();
            List<YY_ITEMTYPE> itemtype= GetElementsType();
            List<YY_ITEM_TI>  itemti=dt.Select<YY_ITEM_TI>("YY_ITEM_TI", new string[] { "*" }, "").ToList();
            List<YY_RTU_ITEM> Item = GetAllElements();
            foreach (var item in itemtype)
            {
                var ti = (from i in itemti where item.ItemTypeID == i.ItemTypeID orderby i.ItemIndex select i).ToList();

                var it = Item.Where(i => ti.Exists(il => i.ItemID.Contains(il.ItemID))).ToList();

                el.Add(new Models.Elements() { ItemTypeID = item.ItemTypeID, ItemType = item.ItemType, ItemTypeIndex = item.ItemTypeIndex, ITEM =it });
            }

            return el;
        }

        /// <summary>
        /// 根据站号得到监测元素
        /// </summary>
        /// <param name="Loca">站号参数类</param>
        /// <returns>监测元素列表</returns>
        [HttpPost]
        public List<YY_RTU_ITEM> GetElementsForLocation(STCDParameter Loca)
        {
            List<YY_RTU_BI> itemlist= dt.Select<YY_RTU_BI>("YY_RTU_BI", new string[] { "*" }, " where STCD='" + Loca.STCD + "'").ToList();
            List<YY_RTU_ITEM> Item = GetAllElements();
            var item= Item.Where(i=>itemlist.Exists(il=>i.ItemID.Contains(il.ItemID))).ToList();
            return item;
        }
        
    }
}
