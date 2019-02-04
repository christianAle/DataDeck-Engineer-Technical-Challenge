using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api
{
   public class Genre :BaseEntity 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Genre()
        {

        }


        public Genre(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Genre( string name)
        {
            
            Name = name;
        }

    }
}
