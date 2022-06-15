namespace Xc.HiKVisionSdk.Isc.ManagersV2.Resources.Dtos
{
    /// <summary>
    /// 资源属性
    /// </summary>
    public class ResourceProperty
    {
        /// <summary>
        ///  	属性id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 属性名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 属性是否必输，0-非必输，1-必输
        /// </summary>
        public int Required { get; set; }
        /// <summary>
        /// 属性类型
        /// </summary>
        public string FieldType { get; set; }
        /// <summary>
        /// 属性描述
        /// </summary>
        public string Desc { get; set; }
        /// <summary>
        /// 属性最小长度
        /// </summary>
        public int MinLength { get; set; }
        /// <summary>
        /// 属性最大长度
        /// </summary>
        public int MaxLength { get; set; }
        /// <summary>
        /// 值类型
        /// </summary>
        public string ValueType { get; set; }
        /// <summary>
        /// 是否是备选主键
        /// </summary>
        public int OptionKey { get; set; }
        /// <summary>
        /// 是否是主键
        /// </summary>
        public int Key { get; set; }
        /// <summary>
        /// 属性正则表达式
        /// </summary>
        public string Regular { get; set; }
        /// <summary>
        /// 是否唯一
        /// </summary>
        public int Unique { get; set; }
        /// <summary>
        /// ldap中属性名称
        /// </summary>
        public string LdapName { get; set; }
        /// <summary>
        /// ldap中模型
        /// </summary>
        public string ObjectClass { get; set; }

        /// <summary>
        /// 属性是否必输
        /// </summary>
        public bool IsRequired => Required != 0;
        /// <summary>
        /// 是否是备选主键
        /// </summary>
        public bool IsOptionKey => OptionKey != 0;
        /// <summary>
        /// 是否是主键
        /// </summary>
        public bool IsKey => Key != 0;
        /// <summary>
        /// 是否唯一
        /// </summary>
        public bool IsUnique => Unique != 0;
    }
}
