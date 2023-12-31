﻿using System.ComponentModel.DataAnnotations;

namespace Pustokk.Models
{
    public class Service:BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 30)]
        public string Title { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Description { get; set; }
        [Required]
        public string Icon { get; set; }
    }
}
