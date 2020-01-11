using Caching;
using System.IO;

namespace System.Web.Mvc
{
    public static class HtmlExtensions
    {
        public static ICacheManager Cache = new CacheManager();
        public static string VersiyonEkle(this HtmlHelper html, string dosyaYeri)
        {
            object cachedDosya = Cache.Get(dosyaYeri);
            var serverDosyaYolu = HttpContext.Current.Server.MapPath("~/" + dosyaYeri);
            var versiyon = File.GetLastWriteTime(serverDosyaYolu).ToString("yyMMddHHmmssfff");
            object dosya = string.Format("/{0}?v={1}", dosyaYeri, versiyon);
            if (cachedDosya as string == dosya as string)
            {
                return cachedDosya as string;
            }
            else if (cachedDosya != null)
            {
                Cache.Remove(dosyaYeri);
            }
            Cache.Set(dosyaYeri, dosya);
            return dosya as string;
        }
    }
}