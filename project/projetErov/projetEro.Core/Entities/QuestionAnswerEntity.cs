using System;

namespace projetErov.Core.Entities
{
    public class QuestionAnswerEntity
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public DateTime DateUpdate { get; set; }
        public string NameAsker { get; set; }
        public int IdRav { get; set; }

    }
}
