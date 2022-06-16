using System.Collections.Generic;

namespace Xc.HiKVisionSdk.Dictionaries
{
    /// <summary>
    /// 安装位置
    /// </summary>
    public static class InstallLocation
    {


        /// <summary>
        /// 
        /// </summary>
        private static readonly DictionariesCodeTextCollection _items = new DictionariesCodeTextCollection();

        /// <summary>
        /// 小区周界
        /// </summary>
        public const string CommunityPerimeter = "communityPerimeter";
        /// <summary>
        /// 小区出入口
        /// </summary>
        public const string CommunityEntrance = "communityEntrance";
        /// <summary>
        /// 消防通道
        /// </summary>
        public const string FireChannel = "fireChannel";
        /// <summary>
        /// 景观池
        /// </summary>
        public const string LandscapePool = "landscapePool";
        /// <summary>
        /// 住宅楼外
        /// </summary>
        public const string OutsideBuilding = "outsideBuilding";
        /// <summary>
        /// 停车场（库）出入口
        /// </summary>
        public const string ParkEntrance = "parkEntrance";
        /// <summary>
        /// 停车场区
        /// </summary>
        public const string ParkArea = "parkArea";
        /// <summary>
        /// 设备房（机房、配电房、泵房）
        /// </summary>
        public const string EquipmentRoom = "equipmentRoom";
        /// <summary>
        /// 监控中心
        /// </summary>
        public const string MonitorCenter = "monitorCenter";
        /// <summary>
        /// 禁停区
        /// </summary>
        public const string StopArea = "stopArea";
        /// <summary>
        /// 金库
        /// </summary>
        public const string Vault = "vault";



        /// <summary>
        /// 安装位置
        /// </summary>
        static InstallLocation()
        {
            _items.Add(CommunityPerimeter, "小区周界");
            _items.Add(CommunityEntrance, "小区出入口");
            _items.Add(FireChannel, "消防通道");
            _items.Add(LandscapePool, "景观池");
            _items.Add(OutsideBuilding, "住宅楼外");
            _items.Add(ParkEntrance, "停车场（库）出入口");
            _items.Add(ParkArea, "停车场区");
            _items.Add(EquipmentRoom, "设备房（机房、配电房、泵房）");
            _items.Add(MonitorCenter, "监控中心");
            _items.Add(StopArea, "禁停区");
            _items.Add(Vault, "金库");
        }


        public static string GetText(string key)
        {
            return _items.Get(key)?.Text;
        }



    }
}
