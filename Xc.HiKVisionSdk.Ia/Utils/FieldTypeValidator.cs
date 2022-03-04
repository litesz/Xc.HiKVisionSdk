using System.Collections.Generic;

namespace Xc.HiKVisionSdk.Ia.Utils
{
    internal static class FieldTypeValidator
    {
        static readonly Dictionary<string, string> types = new Dictionary<string, string>
        {
            {"eq","相等" },
            {"like","相似" },
            {"lt","小于" },
            {"gt","大于" },
            {"lte","小于等于" },
            {"gte","大于相等" },
            {"in","范围" },
            {"isNull","为空" },
            {"notNull","不为空" },
            {"neq","不等于" },
            {"notIn","不在范围" },

        };
        internal static void Vaild(string type)
        {
            if (string.IsNullOrWhiteSpace(type))
            {
                throw new System.ArgumentNullException(nameof(type));
            }
            if (!types.ContainsKey(type))
            {
                throw new System.ArgumentOutOfRangeException(type);
            }
        }
    }
}
