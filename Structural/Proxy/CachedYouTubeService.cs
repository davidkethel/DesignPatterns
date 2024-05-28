using System;
using System.Collections.Generic;

namespace DesignPatterns.Structural.Proxy
{
    public class CachedYouTubeService : IYouTubeService
    {

        private IYouTubeService ThirdPartyYouTubeLib { get; set; }

        private IEnumerable<Video> ListCache;

        public bool NeedReset { get; set; }

        private Video VideoCache { get; set; }

        public CachedYouTubeService(IYouTubeService thirdPartyYouTubeLib)
        {
            ThirdPartyYouTubeLib = thirdPartyYouTubeLib;
        }

        public IEnumerable<Video> ListVideos()
        {
            Console.WriteLine("Cache  - List Videos");
            if(ListCache == null || NeedReset)
            {
                ListCache = ThirdPartyYouTubeLib.ListVideos();
            }
            return ListCache;
        }

        public Video GetVideoInfo(int videoId)
        {
            Console.WriteLine($"Cache - Get Video Info: {videoId}");
            if (VideoCache == null || NeedReset)
            {
                VideoCache  = ThirdPartyYouTubeLib.GetVideoInfo(videoId);
            }
            return VideoCache;
        }
    }
}
