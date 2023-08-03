namespace ZabbixApi.Helper;

internal static class DictionaryExtensions
{
    public static void AddIfNotExist<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
    {
        if (!dictionary.TryGetValue(key, out _)) dictionary.Add(key, value);
    }
}