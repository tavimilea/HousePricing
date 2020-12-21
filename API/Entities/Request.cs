﻿using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Request
    {
        public string Create { get; set; }
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
