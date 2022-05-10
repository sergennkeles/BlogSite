using BlogSite.Core.Repositories;
using BlogSite.Core.Services;
using BlogSite.Core.UnitOfWorks;
using BlogSite.Repository;
using BlogSite.Repository.Repositories;
using BlogSite.Repository.UnitOfWorks;
using BlogSite.Service.Mapping;
using BlogSite.Service.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(MapProfile)); // MapProfile class'ýmzýn asembly'sinin(katmanýnýn) yolunu belirtiyoruz.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(x =>
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), 
    option => option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext))
    .GetName().Name)));

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<ITwitterRepository, TwitterRepository>();
builder.Services.AddScoped<ITwitterService, TwitterService>();

builder.Services.AddScoped<IPostRepository, PostRepository>();
builder.Services.AddScoped<IPostService, PostService>();

builder.Services.AddScoped<IInstagramRepository, InstagramRepository>();
builder.Services.AddScoped<IInstagramService, InstagramService>();

builder.Services.AddScoped<IGithubRepository,GithubRepository>();
builder.Services.AddScoped<IGithubService, GithubService>();

builder.Services.AddScoped<IFavoriteRepository, FavoriteRepository>();
builder.Services.AddScoped<IFavoriteService, FavoriteService>();

builder.Services.AddScoped<IFacebookRepository, FacebookRepository>();
builder.Services.AddScoped<IFacebookService, FacebookService>();

builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddScoped<ICommentService, CommentService>();
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
