using System.Runtime.Caching;

namespace Caching
{
    public interface ICacheManager
    {
        object Get(string key);
        void Set(string key, object data);
        void Remove(string key);
    }

    public class CacheManager : ICacheManager
    {
        private ObjectCache Cache
        {
            get
            {
                return MemoryCache.Default;
            }
        }

        public object Get(string key)
        {
            return Cache[key];
        }

        public void Set(string key, object data)
        {
            Cache.Add(new CacheItem(key, data), new CacheItemPolicy());
        }

        public void Remove(string key)
        {
            Cache.Remove(key);
        }
    }
}