﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WxApi.ReceiveEntity.DataCube
{
    public class ArticleUserShareHour
    {
        /// <summary>
        /// 数据的日期，需在begin_date和end_date之间
        /// </summary>
        public DateTime ref_date { get; set; }
        /// <summary>
        /// 数据的小时，包括从000到2300，分别代表的是[000,100)到[2300,2400)，即每日的第1小时和最后1小时
        /// </summary>
        public int ref_hour { get; set; }
        /// <summary>
        /// 分享的场景1代表好友转发 2代表朋友圈 3代表腾讯微博 255代表其他
        /// </summary>
        public int share_scene { get; set; }
        /// <summary>
        /// 分享的次数
        /// </summary>
        public int share_count { get; set; }
        /// <summary>
        /// 分享的人数
        /// </summary>
        public int share_user { get; set; }
    }
    /// <summary>
    /// 图文分享转发分时数据
    /// </summary>
    public class ArticleUserShareHours
    {
        public List<ArticleUserShareHour> list { get; set; }
    }


}
