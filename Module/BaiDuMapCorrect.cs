using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GMap.NET;

namespace MultiWiiWinGUI.Module
{
    // 作者           : Administrator
    // 创建日期          : 2015年11月19日
    //
    // 最后修改用户 : Administrator
    // 最后修改时间 : 2015年11月19日 09:43:14
    /// <summary>
    /// 百度地图纠偏加偏
    /// </summary>
    public class BaiDuMapCorrect
    {
        private const double x_pi = 3.14159265358979324*3000.0/180.0;

        /// <作者>Administrator</作者>
        /// <创建日期>2015年11月19日</创建日期>
        /// <修改记录>
        /// 用户 : Administrator,修改时间 : 2015年11月19日 09:43:32
        /// </修改记录>
        /// <summary>
        /// 将 GCJ-02 坐标转换成 BD-09 坐标
        /// </summary>
        /// <param name="gg_lat">The gg_lat.</param>
        /// <param name="gg_lon">The gg_lon.</param>
        /// <param name="bd_lat">The bd_lat.</param>
        /// <param name="bd_lon">The bd_lon.</param>
        public static PointLatLng bd_encrypt(double gg_lat, double gg_lon)
        {
            double x = gg_lon, y = gg_lat;
            double z = Math.Sqrt(x*x + y*y) + 0.00002*Math.Sin(y*x_pi);
            double theta = Math.Atan2(y, x) + 0.000003*Math.Cos(x*x_pi);
           // bd_lon = z*Math.Cos(theta) + 0.0065;
            //bd_lat = z*Math.Sin(theta) + 0.006;
            return new PointLatLng(z * Math.Sin(theta) + 0.006, z * Math.Cos(theta) + 0.0065);
        }
        /// <作者>Administrator</作者>
        /// <创建日期>2015年11月19日</创建日期>
        /// <修改记录>
        /// 用户 : Administrator,修改时间 : 2015年11月19日 09:44:31
        /// </修改记录>
        /// <summary>
        /// 将 BD-09 坐标转换成 GCJ-02 坐标
        /// </summary>
        /// <param name="bd_lat">The bd_lat.</param>
        /// <param name="bd_lon">The bd_lon.</param>
        /// <param name="gg_lat">The gg_lat.</param>
        /// <param name="gg_lon">The gg_lon.</param>
        public static PointLatLng bd_decrypt(double bd_lat, double bd_lon)
        {
            double x = bd_lon - 0.0065, y = bd_lat - 0.006;
            double z = Math.Sqrt(x*x + y*y) - 0.00002*Math.Sin(y*x_pi);
            double theta = Math.Atan2(y, x) - 0.000003*Math.Cos(x*x_pi);
            //gg_lon = z*Math.Cos(theta);
            //gg_lat = z*Math.Sin(theta);
            return new PointLatLng(z*Math.Sin(theta),z * Math.Cos(theta));
        }
    }
}
