using Api;
using DataAccess.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OperationMaster
    {
        protected SqlDao dao;
        GenreMapper mapper;

        public OperationMaster() 
        {
            mapper = new GenreMapper();
            dao = SqlDao.GetInstance();
        }


        public  List<T> RetrieveAll<T>()
        {
            var lstCustomers = new List<T>();

            var lstResult = dao.GetData("");
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                var objs = mapper.BuildObjects(lstResult);
                foreach (var c in objs)
                {
                    lstCustomers.Add((T)Convert.ChangeType(c, typeof(T)));
                }
            }

            return lstCustomers;
        }


        public T Retrieve<T>(Genre entity)
        {

          
            var sql = "SELECT * "
                    + "FROM Genres "
                    + "WHERE name='" + entity.Name + "';";

            var lstResult = dao.GetData(sql);
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                dic = lstResult[0];
                var objs = mapper.BuildObject(dic);
                return (T)Convert.ChangeType(objs, typeof(T));
            }

            return default(T);
        }



        public T Retrieve<T>(Song entity)
        {


            var sql = "SELECT * "
                    + "FROM Songs "
                    + "WHERE name='" + entity.SongName + "';";

            var lstResult = dao.GetData(sql);
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                dic = lstResult[0];
                var objs = mapper.BuildObject(dic);
                return (T)Convert.ChangeType(objs, typeof(T));
            }

            return default(T);
        }


        public T RetrieveByArtist<T>(Song song)
        {
            var sql = "SELECT * "
                  + "FROM Songs " 
                  + "WHERE artist='" + song.Artist + "';";

            var lstResult = dao.GetData(sql);
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                dic = lstResult[0];
                var objs = mapper.BuildObject(dic);
                return (T)Convert.ChangeType(objs, typeof(T));
            }

            return default(T);
        }


        public T RetrieveByGenre<T>(string genre)
        {
            var sql = "SELECT * "
                  + "FROM Songs s "
                  + "join Genres g on (g.Id = s.genre)"
                  + "WHERE g.name='" + genre + "';";

          

            var lstResult = dao.GetData(sql);
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                dic = lstResult[0];
                var objs = mapper.BuildObject(dic);
                return (T)Convert.ChangeType(objs, typeof(T));
            }

            return default(T);
        }
    }
}
