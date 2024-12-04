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
        //public LevelErov Level { get; set; }
        public string? BorderErov { get; set; }
        public bool YardErov { get; set; }
        public bool Status { get; set; }
        public int IdRav { get; set; }
        public string? Message { get; set; }
        //public PlaceEntity City { get; set; }
        //public List<PlaceEntity>? Place { get; set; }
        public int IdCity { get; set; }
        public int IdTypePlace { get; set; }
    }
}
