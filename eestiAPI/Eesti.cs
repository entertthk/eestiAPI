using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eestiAPI
{
    public class Eesti
    {
        public string Name { get; set; }
        public string Cioc { get; set; }
        public string Capital { get; set; }
        public string Region { get; set; }
        public int Population { get; set; }

        public List<string> topLevelDomain;
        public List<Language> Languages { get; set; }

        public class Language
        {
            public string Name { get; set; }
        }

    }

}
