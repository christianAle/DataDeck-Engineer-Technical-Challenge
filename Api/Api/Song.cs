using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api
{
    public class Song : BaseEntity
    {
        public int SongId { get; set; }
        public string Artist { get; set; }
        public string SongName { get; set; }
        public int GenreId { get; set; }
        public int Length { get; set; }


        public Song()
        {

        }

     

        public Song(int songId, string artist, string songName, int genreId, int length)
        {
            SongId = songId;
            Artist = artist;
            SongName = songName;
            GenreId = genreId;
            Length = Length;
        }

        public Song(string songName)
        {
            SongName = songName;
        }

        public Song(int a , string artist)
        {
            Artist = artist;
        }

        public Song(int genre)
        {
            Genre = genre;
        }

    }
}
