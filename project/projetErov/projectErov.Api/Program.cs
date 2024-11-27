using projectErov.Data;
using projectErov.Data.Repository;
using projectErov.Service;
using projetErov.Core.Entities;
using projetErov.Core.IRepository;
using projetErov.Core.IService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IContributeService, ContributionService>();
builder.Services.AddScoped<IRepository<ContributionsEntity>,ContributionsRepository>();
builder.Services.AddScoped<IQuestionAnswerService, QuestionAnswerService>();
builder.Services.AddScoped<IRepository<QuestionAnswerEntity>, QuestionAnswerRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IRepository<UserEntity>, UserRepository>();
builder.Services.AddScoped<IErovService, ErovService>();
builder.Services.AddScoped<IRepository<ErovEntity>, ErovRepository>();
builder.Services.AddScoped<IPlaceService, PlaceService>();
builder.Services.AddScoped<IRepository<PlaceEntity>, PlaceRepository>();
builder.Services.AddSingleton<DataContext>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
