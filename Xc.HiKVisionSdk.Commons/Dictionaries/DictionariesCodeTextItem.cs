namespace Xc.HiKVisionSdk.Dictionaries
{
    internal class DictionariesCodeTextItem
    {
        internal DictionariesCodeTextItem(string code, string name)
        {
            Code = code;
            Text = name;
        }

        internal string Code { get; set; }
        internal string Text { get; set; }
    }
}
