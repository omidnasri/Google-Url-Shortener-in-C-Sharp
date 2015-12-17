using Google.Apis.Services;
using Google.Apis.Urlshortener.v1;
using System;

namespace GoogleURLShortener
{
    class Program
    {
        static void Main(string[] args)
        {

            
        }
        public static string shortenIt(string url)
        {
            UrlshortenerService service = new UrlshortenerService(new BaseClientService.Initializer()
            {
                ApiKey = "API KEY from Google developer console",
                ApplicationName = "Daimto URL shortener Sample",
            });

            var m = new Google.Apis.Urlshortener.v1.Data.Url();
            m.LongUrl = url;
            return service.Url.Insert(m).Execute().Id;
        }

        public static string unShortenIt(string url)
        {
            UrlshortenerService service = new UrlshortenerService(new BaseClientService.Initializer()
            {
                ApiKey = "API KEY from Google developer console",
                ApplicationName = "Daimto URL shortener Sample",
            });
            return service.Url.Get(url).Execute().LongUrl;
        }
    }
}
