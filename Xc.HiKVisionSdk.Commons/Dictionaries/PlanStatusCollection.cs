namespace Xc.HiKVisionSdk.Dictionaries
{
    /// <summary>
    /// 识别计划状态类型
    /// </summary>
    public static class PlanStatusCollection
    {

        public static string Get(string key)
        {
            switch (key)
            {
                case "RUNNING": return "正在下发";
                case "SUCCESS": return "下发成功";
                case "PART_FAIL": return "部分失败";
                case "FAIL": return "下发失败";
                case "WAITING": return "等待下发";
                case "PAUSE": return "暂停";
                default:
                    return key;
            }

        }
    }
}
