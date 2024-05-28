using System.Collections.Generic;

namespace DesignPatterns.Structural.Proxy
{
    public interface IYouTubeService
    {
        public IEnumerable<Video> ListVideos();
        public Video GetVideoInfo(int videoId);
    }
}
