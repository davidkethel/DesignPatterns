using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Structural.Proxy
{
    public class ThirdPartyYouTubeService : IYouTubeService
    {
        private readonly List<Video> _videoDB =
        [
            new Video(1),
            new Video(2),
            new Video(3),
            new Video(4),
            new Video(5),
            new Video(6),
            new Video(7),
            new Video(8),
        ];

        public Video GetVideoInfo(int videoId)
        {
            Console.WriteLine($"Get Video Info: {videoId}");
            return _videoDB.FirstOrDefault(video => video.Id == videoId);
        }

        public IEnumerable<Video> ListVideos()
        {
            Console.WriteLine("List Videos");
            return _videoDB;
        }
    }
}
