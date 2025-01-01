using projectErov.Core.Entities;
using projectErov.Core.IRepository;
using projectErov.Core.IService;
using projectErov.Data.Repository;
using projectErov.Service;

namespace projectErov.Api
{
    public static class Extation
    {
        public static void AddDependency(this IServiceCollection Services)
        {
            Services.AddScoped<IContributeService, ContributionService>();
            Services.AddScoped<IRepository<ContributionsEntity>, ContributionsRepository>();
            Services.AddScoped<IQuestionAnswerService, QuestionAnswerService>();
            Services.AddScoped<IRepository<QuestionAnswerEntity>, QuestionAnswerRepository>();
            Services.AddScoped<IUserService, UserService>();
            Services.AddScoped<IRepository<UserEntity>, UserRepository>();
            Services.AddScoped<IErovService, ErovService>();
            Services.AddScoped<IRepository<ErovEntity>, ErovRepository>();
            Services.AddScoped<IPlaceService, PlaceService>();
            Services.AddScoped<IRepository<PlaceEntity>, PlaceRepository>();
        }
    }
}
