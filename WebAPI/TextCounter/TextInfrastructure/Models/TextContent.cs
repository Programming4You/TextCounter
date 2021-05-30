using System;
using System.ComponentModel.DataAnnotations;

namespace TextInfrastructure.Models
{
    public class TextContent : BaseEntity
    {
        [Required]
        public string Content { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
