using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Report
    {
        public int Id { get; set; }
        public User User { get; set; }
        public EstimationRequest Request { get; set; }
    }
}
