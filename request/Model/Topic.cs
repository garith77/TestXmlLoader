using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace request
{
    public class Topic
    {
        public int Id { get; set; }
        public int TafeCourseId { get; set; }
        public string UnitCode { get; set; }
        public string Name { get; set; }
        public string AssesmentLink { get; set; }
        public string CriteriaLink { get; set; }
        public bool IsEssential { get; set; }
        public List<TextData> TextData { get; set; }
    }
}
