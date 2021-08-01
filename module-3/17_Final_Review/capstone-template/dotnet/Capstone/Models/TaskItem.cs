using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [MaxLength(255)]
        [Required]
        public string Title { get; set; }

        public bool IsCompleted { get; set; }
    }
}
