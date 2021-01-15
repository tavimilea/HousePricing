using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class EstimationRequestWrapper
    {
        [Required]
        public float Floors { get; set; }
        [Required]
        public float Grade { get; set; }
        [Required]
        public float Condition { get; set; }

        public string Token { get; set; }

        public  EstimationRequest UnrwrapEstimation()
        {
            var req = new EstimationRequest();
            req.Floors = this.Floors;
            req.Condition = this.Condition;
            req.Grade = this.Grade;
            req.Token = this.Token;
            return req;
        }
    }
}
