using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectErov.Core.Entities
{
    public enum LevelErov
    {
        City, Neighborhood, GoodNeighborhood
    }
	[Table("Erov")]

	public class ErovEntity
    {
        public int IdInTable { get; set; }
        public int Id { get; set; }
        public int? Level { get; set; }
        public string BorderErov { get; set; }
        public bool? YardErov { get; set; }
        public bool? Status { get; set; }
        [ForeignKey("User")]
        public int IdRav { get; set; }
        public string? Message { get; set; }
        [ForeignKey("Place")]
        public int IdPlace { get; set; }

    }
}
