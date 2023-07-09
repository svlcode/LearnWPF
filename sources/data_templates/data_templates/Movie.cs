using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_templates
{
    public class Movie
    {
        public string Name { get; set; }
        public short Year { get; set; }
        public List<string> Cast { get; set; }
        public long HoursWatched { get; set; }

    }
}
