using System;

namespace DesignPatterns.Structural.Proxy
{
    public static class ProxyExample
    {
        public static void Run()
        {
            Console.WriteLine("Proxy Example");

            var youTubeService = new ThirdPartyYouTubeService();
            var proxy = new CachedYouTubeService(youTubeService);

            var video1 = proxy.GetVideoInfo(1);
            var video1Again = proxy.GetVideoInfo(1);
            var video2 = proxy.GetVideoInfo(2);

            proxy.ResetCache();

            var video1AgainAgain = proxy.GetVideoInfo(1);
            var video2Again = proxy.GetVideoInfo(2);
        }
    }
}
