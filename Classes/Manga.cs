using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaView.Classes
{
    public class Manga
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Manga(int id)
        {
            Id = id;
        }

        public Manga(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public int GetId()
        {
            return this.Id;
        }
    }
}
