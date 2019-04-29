using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public int AlbumId { get; set; }
        public string Path { get; set; }
    }
}
