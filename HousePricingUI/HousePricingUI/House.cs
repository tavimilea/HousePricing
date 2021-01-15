using Microsoft.ML.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace HousePricingUI
{
    public class House
    {
        [Required]
        [Range(1, 90000000, ErrorMessage = "Bedrooms number invalid (1-90000000).")]
        public int Bedrooms { get; set; }
        [Required]
        [Range(1, 90000000, ErrorMessage = "Bathrooms number invalid (1-90000000).")]
        public int Bathrooms { get; set; }
        [Range(1, 90000000, ErrorMessage = "Sqft(living) number invalid (1-90000000).")]
        public float Sqft_living { get; set; }
        [Range(1, 90000000, ErrorMessage = "Sqft(lot) number invalid (1-90000000).")]
        public float Sqft_lot { get; set; }
        [Range(1, 90000000, ErrorMessage = "Floors number invalid (1-90000000).")]
        public int Floors { get; set; }
        public bool Waterfront { get; set; }
        public bool View { get; set; }
        [Range(1, 10)]
        public int Condition { get; set; }
        [Range(1, 10)]
        public int Grade { get; set; }
        [Range(1, 90000000, ErrorMessage = "Sqft(above) number invalid (1-90000000).")]
        public float Sqft_above { get; set; }
        [Range(0, 90000000, ErrorMessage = "Sqft(basement) number invalid (1-90000000).")]
        public float Sqft_basement { get; set; }
        
        public DateTimeDataViewType Year_built { get; set; }
        
        public DateTimeDataViewType Year_renovated { get; set; }
    }
}
