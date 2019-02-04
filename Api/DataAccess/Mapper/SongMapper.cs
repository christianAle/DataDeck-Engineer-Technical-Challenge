using Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    public class SongMapper:EntityMapper
    {
        private const string DB_COL_ID = "ID";
        private const string DB_COL_ARTIST = "artist";
        private const string DB_COL_SONG = "song";
        private const string DB_COL_GENRE = "genre";
        private const string DB_COL_LENGTH = "length";


        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var genre = BuildObject(row);
                lstResults.Add(genre);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var song = new Song
            {
                SongId = GetIntValue(row, DB_COL_ID),
                Artist = GetStringValue(row, DB_COL_ARTIST),
                SongName = GetStringValue(row, DB_COL_SONG),
                GenreId = GetIntValue(row, DB_COL_GENRE),
                Length = GetIntValue(row, DB_COL_LENGTH),

            };
             

            return song;
        }
    }
}
