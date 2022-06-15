namespace Xc.HiKVisionSdk.Dictionaries
{
    /// <summary>
    /// 
    /// </summary>
    public static class DoorEventSortCollection
    {

        public static string Get(string key)
        {
            switch (key?.ToLower() ?? "eventTime")
            {
                case "personname": return "personName";
                case "doorname": return "doorName";
                default: return "eventTime";
            }
        }

       
    }
}
