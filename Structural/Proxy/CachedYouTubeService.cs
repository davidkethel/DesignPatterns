using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Structural.Proxy
{
    public class CachedYouTubeService : IYouTubeService
    {

        private IYouTubeService ThirdPartyYouTubeLib { get; set; }

        private List<Video> VideoCache { get; set; } = [];

        public CachedYouTubeService(IYouTubeService thirdPartyYouTubeLib)
        {
            ThirdPartyYouTubeLib = thirdPartyYouTubeLib;
        }

        public Video GetVideoInfo(int videoId)
        {
            Console.WriteLine($"Cache - Get Video Info: {videoId}");
            if (!VideoCache.Any(x => x.Id == videoId))
            {
                VideoCache.Add(ThirdPartyYouTubeLib.GetVideoInfo(videoId));
            }
            return VideoCache.First(x => x.Id == videoId);
        }

        public void ResetCache()
        {
            Console.WriteLine("Reset Cache");
            VideoCache = [];
        }
    }
}
