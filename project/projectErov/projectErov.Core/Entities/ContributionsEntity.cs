using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectErov.Core.Entities
{
	[Table("Contribute")]

	public class ContributionsEntity
    {
        [Key]
        public int IdInTable { get; set; }

		[Column(TypeName = "decimal(18,4)")]
		public decimal Sum { get; set; }
        public DateTime Date { get; set; }
        public string? Donor { get; set; }
        public string? NameForPraying { get; set; }
        public int NumInvoice { get; set; }
    }
}
