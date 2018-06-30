using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Models;

namespace OnlineMonitoringSystemAPI.Controllers
{
    /// <summary>
    /// a
    /// </summary>
    public class LocationController : ApiController
    {
        DataAccess._51Data dt = new DataAccess._51Data();

        /// <summary>
        /// 得到站点基本信息
        /// </summary>
        /// <returns>站点信息列表</returns>
        [HttpPost]
        public List<YY_RTU_Basic> GetLocation(string where="")
        {
            return dt.Select<YY_RTU_Basic>("YY_RTU_Basic", new string[] { "*" }, where).ToList();
        }

        /// <summary>
        /// 得到站点所有信息
        /// </summary>
        /// <returns>站点信息列表</returns>
        [HttpPost]
        public List<LocationInfo> GetLocationInfo(string where = "")
        {
            List<LocationInfo> info = new List<LocationInfo>();
            List<YY_RTU_Basic> rtu = dt.Select<YY_RTU_Basic>("YY_RTU_Basic", new string[] { "*" }, where).ToList();
            List<LocaInfo_Tab> loca = dt.Select<LocaInfo_Tab>("LocaInfo_Tab", new string[] { "*" }, where).ToList();
            List<Image_Tab> img = dt.Select<Image_Tab>("Image_Tab", new string[] { "*" }, where).ToList();

            foreach (var item in rtu)
            {
                var Loca = loca.Find(l => l.STCD == item.STCD);
               
                List<Image_Tab> Img = (from i in img where item.STCD == i.STCD select i).ToList();
                if (Img.Count == 0)
                {
                    Img = null;
                }

                info.Add(new LocationInfo { STCD = item.STCD, Latitude = item.Latitude, Longitude = item.Longitude, NiceName = item.NiceName, PassWord = item.PassWord, Image = Img, LocaInfo = Loca });

            }

            return info;
        }





    }

}
