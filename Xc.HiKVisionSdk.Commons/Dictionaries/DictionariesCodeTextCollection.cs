using System.Collections.Generic;

namespace Xc.HiKVisionSdk.Dictionaries
{
    internal class DictionariesCodeTextCollection
    {
        private static Dictionary<string, DictionariesCodeTextItem> _collection = new Dictionary<string, DictionariesCodeTextItem>();
        private static string defaultKey;

        internal void Add(string code, string text, bool isDefault = false)
        {
            _collection.Add(code.ToLower(), new DictionariesCodeTextItem(code, text));
            if (isDefault)
            {
                defaultKey = code.ToLower();
            }
        }

        internal DictionariesCodeTextItem Get(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                return null;
            }
            key = key.ToLower();


            if (_collection.ContainsKey(key))
            {
                return _collection[key];
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        internal DictionariesCodeTextItem GetOrDefault(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                if (!string.IsNullOrWhiteSpace(defaultKey))
                {
                    return _collection[defaultKey];
                }
                return null;
            }
            key = key.ToLower();

            if (_collection.ContainsKey(key))
            {
                return _collection[key];
            }
            if (!string.IsNullOrWhiteSpace(defaultKey))
            {
                return _collection[defaultKey];
            }
            throw new System.ArgumentOutOfRangeException(key);

        }
    }
}
