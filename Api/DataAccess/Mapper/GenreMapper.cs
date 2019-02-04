using Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    public class GenreMapper:EntityMapper
    {
        private const string DB_COL_ID = "ID";
        private const string DB_COL_NAME = "name";
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
            var genre = new Genre
            {
                Id = GetIntValue(row, DB_COL_ID),
                Name = GetStringValue(row, DB_COL_NAME),
              
            };

            return genre;
        }
    }
}
