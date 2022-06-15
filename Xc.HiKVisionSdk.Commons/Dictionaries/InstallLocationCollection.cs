﻿using System.Collections.Generic;

namespace Xc.HiKVisionSdk.Dictionaries
{
    /// <summary>
    /// 安装位置
    /// </summary>
    public static class InstallLocationCollection
    {

        private static readonly Dictionary<string, string> _locations = new Dictionary<string, string>();

        /// <summary>
        /// 安装位置
        /// </summary>
        static InstallLocationCollection()
        {
            _locations.Add("    communityPerimeter".Trim(), "小区周界           ".Trim());
            _locations.Add(" communityEntrance".Trim(), "小区出入口             ".Trim());
            _locations.Add(" fireChannel".Trim(), "消防通道                     ".Trim());
            _locations.Add(" landscapePool".Trim(), "景观池                     ".Trim());
            _locations.Add(" outsideBuilding".Trim(), "住宅楼外                 ".Trim());
            _locations.Add(" parkEntrance".Trim(), "停车场（库）出入口            ".Trim());
            _locations.Add(" parkArea".Trim(), "停车场区                        ".Trim());
            _locations.Add(" equipmentRoom".Trim(), "设备房（机房、配电房、泵房）  ".Trim());
            _locations.Add(" monitorCenter".Trim(), "监控中心                   ".Trim());
            _locations.Add(" stopArea".Trim(), "禁停区                          ".Trim());
            _locations.Add("vault".Trim(), "金库                               ".Trim());

        }


        public static string Get(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                return "未设置";
            }
            if (_locations.ContainsKey(key))
            {
                return _locations[key];
            }
            return key;
        }

        

    }
}
