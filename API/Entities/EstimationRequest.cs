using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class EstimationRequest
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public float Floors { get; set; }
        [Required]
        public float Grade { get; set; }
        [Required]
        public float Condition { get; set; }

        public string Token { get; set; }
        [ForeignKey("Report")]
        public int? ReportFk { get; set; }

        public Report Report { get; set; }
    }
}
