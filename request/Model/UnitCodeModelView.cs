using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace request.Model
{
    public class UnitCodeModelView
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string UnitCode { get; set; }
        public string Name { get; set; }
        public string XmlCriteriaLink { get; set; }
        public string XmlAssesmentLink { get; set; }
    }
}
