using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace projectErov.Core.Entities
{
	[Table("QuestionAnswer")]

	public class QuestionAnswerEntity
    {
		[Key]
		public int IdInTable { get; set; }
		public int Id { get; set; }
		public string Subject { get; set; }
		public string Question { get; set; }
		public string? Answer { get; set; }
		public DateTime DateUpdate { get; set; }
		public string? NameAsker { get; set; }
        [ForeignKey("User")]
        public int AskerId { get; set; }
		[ForeignKey("User")]
        public int RavId{ get; set; }
	}
}
