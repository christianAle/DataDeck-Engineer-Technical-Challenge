using Api;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApi
{
    public class Manager
    {
        private OperationMaster master;

        public Manager()
        {
            master = new OperationMaster();
        }

        public List<Genre> RetrieveAll()
        {
            return master.RetrieveAll<Genre>();
        }

        public Genre RetrieveByName(Genre genre)
        {
            Genre g = null;
           
                g = master.Retrieve<Genre>(genre);
                          

            return g;
        }


        public Song RetrieveSongByName(Song song)
        {
            Song s = null;

            s = master.Retrieve<Song>(song);


            return s;
        }


        public Song RetrieveSongByArtis(Song song)
        {
            Song s = null;

            s = master.RetrieveByArtist<Song>(song);


            return s;
        }

        public List<Song> RetrieveSongByGenre(string id)
        {
            

          List<Song>  s = master.RetrieveByGenre<Song>(id);


            return s;
        }
    }
}
