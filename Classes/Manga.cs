using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaView.Classes
{
    public class Manga
    {
        private readonly int id;
        private readonly string name = "Undefined";
        public readonly string indexer = "aaa";
        public Manga(int id)
        {
            this.id = id;
        }

        public Manga(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }
        public int GetId()
        {
            return this.id;
        }
    }
}
