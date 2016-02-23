using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace request
{
    public class UnitCodeDetails
    {
        public int Id { get; set; }
        public string UnitCode { get; set; }
        public string Name { get; set; }

        public List<Topic> Topics { get; set; }
    }
}
