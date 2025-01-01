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
        [ForeignKey(nameof(RavId))]
        public UserEntity? Rav { get; set; }
        public int? RavId { get; set; }
        public string? Message { get; set; }
        [ForeignKey("PlaceId")]
        public PlaceEntity? PlaceErov { get; set; }
        public int? PlaceId { get; set; }

    }
}
