using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectErov.Core.Entities
{
    public enum Type
    {
        City, Neighborhood, Complex
    }
    public enum Area
    {
        North, South, Center
    }
    public enum NameCity
    {
        BneyBrak, Jersulem, Elad, Tzat
    }
	[Table("Place")]

	public class PlaceEntity
    {
        [Key]
        public int IdInTable { get; set; }
        public int Id { get; set; }
        //public NameCity Name { get; set; }
        //public Type Type { get; set; }
        //public Area Area { get; set; }
    }
}
