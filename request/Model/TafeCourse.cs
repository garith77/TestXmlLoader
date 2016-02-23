using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace request.Model
{
    public class TafeCourse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UnitCode { get; set; }
        public List<Topic> Topics { get; set; }
    }
}
