using System;
using System.Collections.Generic;

namespace Database
{
    public partial class Movies
    {
        public string Tconst { get; set; }
        public string Titletype { get; set; }
        public string Primarytitle { get; set; }
        public string Originaltitle { get; set; }
        public bool? Isadult { get; set; }
        public int? Startyear { get; set; }
        public int? Endyear { get; set; }
        public int? Runtimeminutes { get; set; }
        public string Genres { get; set; }
    }
}
