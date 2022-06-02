namespace Xc.HiKVisionSdk.Consts
{
    public static class OrderTypeConsts
    {

        public const string ASC = "asc";
        public const string DESC = "desc";

        public static string GetOrderType(bool isAsc)
        {
            return isAsc ? ASC : DESC;
        }

    }
}
