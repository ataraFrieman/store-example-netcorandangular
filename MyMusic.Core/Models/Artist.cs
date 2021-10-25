using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyMusic.Core.Models
{
    public class Artist: EntityBase
    {
        public Artist()
        {
            Musics = new Collection<Music>();
        }

        public string Name { get; set; }

        public ICollection<Music> Musics { get; set; }
    }
}