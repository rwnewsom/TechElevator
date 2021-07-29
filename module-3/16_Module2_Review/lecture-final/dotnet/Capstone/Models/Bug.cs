using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Bug
    {
		public int Id { get; set; }

		[Required]
		[MaxLength(120)]
		public string Title { get; set; }

		public string Description { get; set; }

		public bool IsOpen { get; set; }

		[Range(1, 5)]
		public int Priority { get; set; }

		public string Resolution { get; set; }
	}
}
