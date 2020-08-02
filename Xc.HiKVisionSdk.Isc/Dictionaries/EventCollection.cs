using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Xc.HiKVisionSdk.Isc.Models;

namespace Xc.HiKVisionSdk.Isc.Dictionaries
{
    /// <summary>
    /// 事件集合
    /// </summary>
    public class EventCollection : IEventCollection
    {
        /// <summary>
        /// 已同步
        /// </summary>
        public bool IsLoadState { get; set; }

        /// <summary>
        /// 项
        /// </summary>
        public Dictionary<int, EventCollectionItem> Items { get; } = new Dictionary<int, EventCollectionItem>();

        /// <summary>
        /// 获得事件类型
        /// </summary>
        /// <returns></returns>
        public KeyValuePair<string, string>[] GetEventTypes()
        {
            return new[] {
                new KeyValuePair<string, string>("一卡通", "SmartCard") ,
                new KeyValuePair<string, string>("车辆管理", "Vehicle") ,
                new KeyValuePair<string, string>("人脸监控", "Face") ,
            };
        }

        /// <summary>
        /// 子类型
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public KeyValuePair<string, string>[] GetEventSubclasses(string type)
        {
            switch (type)
            {
                case "SmartCard":
                    return new[] { new KeyValuePair<string, string>("门禁", "Acs") };
                case "Vehicle":
                    return new[] { new KeyValuePair<string, string>("停车场", "Pms") };
                case "Face":
                    return new[] { new KeyValuePair<string, string>("人脸监控", "Face") };
            }
            return null;
        }

        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public EventCollectionItem this[int code]
        {
            get
            {
                if (Items.ContainsKey(code))
                {
                    return Items[code];
                }
                return new EventCollectionItem
                {
                    Name = "未定义",
                    Code = code
                };
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public EventCollection()
        {
            InitAcs();
            //InitVis();
            //InitVisitor();
            //InitPms();
            //InitMpc();
            //InitIas();

            InitPms();
            InitFace();
        }

    

        /// <summary>
        /// 
        /// </summary>
        private void InitAcs()
        {

            Items.Add(198914, new EventCollectionItem
            {
                Code = 198914,
                Name = "合法卡比对通过",
                Type = "SmartCard",
                TypeName = "一卡通",
                Subclass = "Acs",
                SubclassName = "门禁",
                Action = "acs"
            });


            Items.Add(196893, new EventCollectionItem
            {
                Code = 196893,
                Name = "人脸认证通过",
                Type = "SmartCard",
                TypeName = "一卡通",
                Subclass = "Acs",
                SubclassName = "门禁",
                Action = "acs"
            });
        }
        /// <summary>
        /// 
        /// </summary>
        public void InitPms()
        {

            Items.Add(771756034, new EventCollectionItem
            {
                Code = 771756034,
                Name = "黑名单",
                Type = "Vehicle",
                TypeName = "车辆管理",
                Subclass = "Pms",
                SubclassName = "停车场",
                Action = "AlarmCar"
            });
        }
        /// <summary>
        /// 
        /// </summary>
        public void InitFace()
        {
            Items.Add(1644175361, new EventCollectionItem
            {
                Code = 1644175361,
                Name = "重点人员识别事件",
                Type = "Face",
                TypeName = "人脸监控",
                Subclass = "Face",
                SubclassName = "人脸监控",
                Action = "FrsBlack"
            });
        }
    }
}
