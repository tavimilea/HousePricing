using System;
using System.ComponentModel.DataAnnotations;

namespace HousePricingUI
{
    public class HouseModel
    {
        
        [Range(1, 90000000, ErrorMessage = "Floors number invalid (1-90000000).")]
        public float Floors { get; set; }
        [Range(1, 10)]
        public int Condition { get; set; }
        [Range(1, 10)]
        public int Grade { get; set; }

    }
}

