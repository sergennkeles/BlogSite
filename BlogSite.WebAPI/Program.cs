using Autofac;
using Autofac.Extensions.DependencyInjection;
using BlogSite.Core.Repositories;
using BlogSite.Core.Services;
using BlogSite.Core.UnitOfWorks;
using BlogSite.Repository;
using BlogSite.Repository.Repositories;
using BlogSite.Repository.UnitOfWorks;
using BlogSite.Service.Mapping;
using BlogSite.Service.Repositories;
using BlogSite.WebAPI.Modules;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

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
 builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
//builder.Services.AddTransient<IUserRepository, UserRepository>();
//builder.Services.AddTransient<IUserService, UserService>();

//builder.Services.AddTransient<ITwitterRepository, TwitterRepository>();
//builder.Services.AddTransient<ITwitterService, TwitterService>();

//builder.Services.AddTransient<IPostRepository, PostRepository>();
//builder.Services.AddTransient<IPostService, PostService>();

//builder.Services.AddTransient<IInstagramRepository, InstagramRepository>();
//builder.Services.AddTransient<IInstagramService, InstagramService>();

//builder.Services.AddTransient<IGithubRepository, GithubRepository>();
//builder.Services.AddTransient<IGithubService, GithubService>();

//builder.Services.AddTransient<IFavoriteRepository, FavoriteRepository>();
//builder.Services.AddTransient<IFavoriteService, FavoriteService>();

//builder.Services.AddTransient<IFacebookRepository, FacebookRepository>();
//builder.Services.AddTransient<IFacebookService, FacebookService>();

//builder.Services.AddTransient<ICommentRepository, CommentRepository>();
//builder.Services.AddTransient<ICommentService, CommentService>();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder => containerBuilder.RegisterModule(new RepoServiceModule()));

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
