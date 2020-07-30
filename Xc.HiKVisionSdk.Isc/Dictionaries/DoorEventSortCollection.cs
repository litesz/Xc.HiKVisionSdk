namespace Xc.HiKVisionSdk.Isc.Dictionaries
{
    /// <summary>
    /// 
    /// </summary>
    public class DoorEventSortCollection : IDoorEventSortCollection
    {



        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string this[string key]
        {
            get
            {
                switch (key?.ToLower()?? "eventTime")
                {
                    case "personname": return "personName";
                    case "doorname": return "doorName";
                    default: return "eventTime";
                }
            }
        }
    }
}
