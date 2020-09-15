using System.Collections.Generic;
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
                new KeyValuePair<string, string>("SmartCard","一卡通" ) ,
                new KeyValuePair<string, string>("Vehicle","车辆管理" ) ,
                new KeyValuePair<string, string>( "Face","人脸监控") ,
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
                    return new[] { new KeyValuePair<string, string>("Acs", "门禁") };
                case "Vehicle":
                    return new[] { new KeyValuePair<string, string>("Pms", "停车场") };
                case "Face":
                    return new[] { new KeyValuePair<string, string>("Face", "人脸监控") };
                default:
                    return new KeyValuePair<string, string>[0];
            }

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
                    Id = code
                };
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public EventCollection()
        {
            InitAcs();

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
                Id = 198914,
                Name = "合法卡比对通过",
                Type = "SmartCard",
                TypeName = "一卡通",
                Subclass = "Acs",
                SubclassName = "门禁",
                Action = "acs"
            });


            Items.Add(196893, new EventCollectionItem
            {
                Id = 196893,
                Name = "人脸认证通过",
                Type = "SmartCard",
                TypeName = "一卡通",
                Subclass = "Acs",
                SubclassName = "门禁",
                Action = "acs"
            });


            Items.Add(197162, new EventCollectionItem
            {
                Id = 197162,
                Name = "人证比对通过",
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
                Id = 771756034,
                Name = "黑名单",
                Type = "Vehicle",
                TypeName = "车辆管理",
                Subclass = "Pms",
                SubclassName = "停车场",
                Action = "ParkingInOrOut"
            });


            Items.Add(771760131, new EventCollectionItem
            {
                Id = 771760131,
                Name = "入场放行",
                Type = "Vehicle",
                TypeName = "车辆管理",
                Subclass = "Pms",
                SubclassName = "停车场",
                Action = "ParkingInOrOut"
            });

            Items.Add(771760134, new EventCollectionItem
            {
                Id = 771760134,
                Name = "出场放行",
                Type = "Vehicle",
                TypeName = "车辆管理",
                Subclass = "Pms",
                SubclassName = "停车场",
                Action = "ParkingInOrOut"
            });

        }
        /// <summary>
        /// 
        /// </summary>
        public void InitFace()
        {
            Items.Add(1644175361, new EventCollectionItem
            {
                Id = 1644175361,
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
