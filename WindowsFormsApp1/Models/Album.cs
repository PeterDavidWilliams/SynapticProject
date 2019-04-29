using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class Album
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public List<Song> Songs { get; set; }
        public int Id { get; set; }
    }
}
