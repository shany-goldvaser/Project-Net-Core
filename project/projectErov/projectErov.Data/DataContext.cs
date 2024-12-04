using Microsoft.EntityFrameworkCore;
using projectErov.Core.Entities;
using System;
using System.Collections.Generic;
using System.IO;
namespace projectErov.Data
{
    public class DataContext:DbContext
    {
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}
		public DbSet<ContributionsEntity> ContributionsList { get; set; }
        public DbSet<ErovEntity> ErovList { get; set; }
        public DbSet<PlaceEntity>PlaceList { get; set; }
        public DbSet<QuestionAnswerEntity> QuestionAnswerList { get; set; }
        public DbSet<UserEntity> UsersList { get; set; }

    }
}
