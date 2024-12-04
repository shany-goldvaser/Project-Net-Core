using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectErov.Core.Entities
{
	[Table("QuestionAnswer")]

	public class QuestionAnswerEntity
    {
		[Key]
		public int IdInTable { get; set; }
		public int Id { get; set; }
		public string? Subject { get; set; }
		public string? Question { get; set; }
		public string? Answer { get; set; }
		public DateTime DateUpdate { get; set; }
		public string? NameAsker { get; set; }
		public int IdRav { get; set; }
	}
}
