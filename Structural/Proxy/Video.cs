using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class Video
    {
        public int Id { get; set; }

        public Video(int id)
        {
            Id = id;
        }
    }
}
