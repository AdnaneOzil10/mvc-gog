﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mvc_gog.Models
{
    public class User
    {

        public int UserID { get; set; }

        [Required]
        [StringLength(255)]
        public string? Email { get; set; }

        [Required]
        [StringLength(255)]
        public string? Password { get; set; }

        [Required]
        [StringLength(255)]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(255)]
        public string? LastName { get; set; }

        [DefaultValue(false)]
        public bool IsAdmin { get; set; }
        public DateTime BirthDate { get; set; }

    }



}

