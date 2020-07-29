namespace Xc.HiKVisionSdk.Isc.Managers
{
    /// <summary>
    /// 查询表达式
    /// </summary>
    public class RequestExpression
    {
        /// <summary>
        /// 资源属性名，key传updateTime，operator传between可以查询特定时间段更新的数据，考虑到校时和夏令时，建议值查询过去一天的数据变更
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 操作运算符，0 ：=，1 ：>=，2 ：<=，3 ：in，4 ：not in，5 ：between，6 ：like，7 ：pre like，8 ：suffix like
        ///  </summary>
        public RequestExpressionOperator Operator { get; set; }

        /// <summary>
        ///  	资源属性值，=、>=、<=、like、values数组长度只能是1；
        ///  	in、not in，values数组长度大于1，最大不超时20；
        ///  	in_array用于查询key值有多个value的情况，例如行车监控添加的设备类型为encodeDevice、encodeDeviceMss两个类型，使用encodeDevice或者encodeDeviceMss都可以查询到；between只能用于整形、日期
        ///  	；like只能用于字符串。
        /// </summary>
        public string[] Values { get; set; }


    }
}
