using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectErov.Core.Entities
{
    [Table("User")]

	public class UserEntity
    {
		[Key]
		public int IdInTable { get; set; }
		public string? FullName { get; set; }
		public string? Tz { get; set; }
		public string? PhoneNumber { get; set; }
		public string? Email { get; set; }
		public string? Adress { get; set; }
		public bool Permission { get; set; }
	}
}
