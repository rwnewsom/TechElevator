using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Bug
    {
		/*
		CREATE TABLE bugs(
			bug_id int IDENTITY(1,1) NOT NULL,
			title nvarchar(120) NOT NULL,
			description nvarchar(MAX) NULL,
			isOpen bit NOT NULL,
			resolution nvarchar(MAX) NULL,
			CONSTRAINT PK_bug PRIMARY KEY(bug_id)
			)
		*/

		public int Id { get; set; }
		
		[Required]
		[MaxLength(120)]
		public string Title { get; set; }

		public string Description { get; set; }

		public bool IsOpen { get; set; }

		public string Resolution { get; set; }
    }
}
