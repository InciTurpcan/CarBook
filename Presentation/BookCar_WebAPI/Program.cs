using CarBook_Application.Features.CQRS.Handlers.AboutHandlers;
using CarBook_Application.Features.CQRS.Handlers.BannerHandlers;
using CarBook_Application.Features.CQRS.Handlers.BrandHandlers;
using CarBook_Application.Features.CQRS.Handlers.CarHandlers;
using CarBook_Application.Features.CQRS.Handlers.CategoryHandlers;
using CarBook_Application.Features.CQRS.Handlers.ContactHandlers;
using CarBook_Application.Features.CQRS.Queries.AboutQueries;
using CarBook_Application.Features.RepositoryPattern;
using CarBook_Application.Interfaces;
using CarBook_Application.Interfaces.BlogInterfaces;
using CarBook_Application.Interfaces.CarInterfaces;
using CarBook_Application.Interfaces.CarPricingInterfaces;
using CarBook_Application.Interfaces.StatisticsInterfaces;
using CarBook_Application.Interfaces.TagCloudInterfaces;
using CarBook_Application.Services;
using CarBook_Domain.Entities;
using CarBook_Persistence.Context;
using CarBook_Persistence.Repositories;
using CarBook_Persistence.Repositories.BlogRepositories;
using CarBook_Persistence.Repositories.CarPricingRepositories;
using CarBook_Persistence.Repositories.CarRepositories;
using CarBook_Persistence.Repositories.CommentRepositories;
using CarBook_Persistence.Repositories.StatisticsRepositories;
using CarBook_Persistence.Repositories.TagCloudRepositories;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddScoped<CarBookContext, CarBookContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(ICarRepository),typeof(CarRepository));
builder.Services.AddScoped(typeof(IBlogRepository), typeof(BlogRepository));
builder.Services.AddScoped(typeof(ICarPricingRepository), typeof(CarPricingRepository));
builder.Services.AddScoped(typeof(ITagCloudRepository), typeof(TagCloudRepository));
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(CommentRepository<>));
builder.Services.AddScoped(typeof(IStatisticsRepository), typeof(StatisticsRepository));


//About
builder.Services.AddScoped<GetAboutQueryHandler>();
builder.Services.AddScoped<GetAboutByIdQueryHandler>();
builder.Services.AddScoped<CreateAboutCommandHandler>();
builder.Services.AddScoped<UpdateAboutCommandHandler>();    
builder.Services.AddScoped<RemoveAboutCommandHandler>();

//Banner
builder.Services.AddScoped<GetBannerQueryHandler>();
builder.Services.AddScoped<GetBannerByIdQueryHandler>();
builder.Services.AddScoped<CreateBannerCommandHandler>();
builder.Services.AddScoped<RemoveBannerCommandHandler>();
builder.Services.AddScoped<UpdateBannerCommandHandler>();

//Brand
builder.Services.AddScoped<GetBrandQueryHandler>();
builder.Services.AddScoped<GetBrandByIdQueryHandler>();
builder.Services.AddScoped<CreateBrandCommandHandler>();
builder.Services.AddScoped<UpdateBrandCommandHandler>();
builder.Services.AddScoped<RemoveBrandCommandHandler>();

//Car
builder.Services.AddScoped<GetCarQueryHandler>();
builder.Services.AddScoped<GetCarByIdQueryHandler>();
builder.Services.AddScoped<CreateCarCommandHandler>();
builder.Services.AddScoped<UpdateCarCommandHandler>();
builder.Services.AddScoped<RemoveCarCommandHandler>();
builder.Services.AddScoped<GetCarWithBrandQueryHandler>();
builder.Services.AddScoped<GetLast5CarWithBrandQueryHandler>();



//Category
builder.Services.AddScoped<GetCategoryQueryHandler>();
builder.Services.AddScoped<GetCategoryByIdQueryHandler>();
builder.Services.AddScoped<CreateCategoryCommandHandler>();
builder.Services.AddScoped<UpdateCategoryCommandHandler>();
builder.Services.AddScoped<RemoveCategoryCommandHandler>();

//Contact
builder.Services.AddScoped<GetContactQueryHandler>();
builder.Services.AddScoped<GetContactByIdQueryHandler>();
builder.Services.AddScoped<CreateContactCommandHandler>();
builder.Services.AddScoped<UpdateContactCommandHandler>();
builder.Services.AddScoped<RemoveContactCommandHandler>();


builder.Services.AddApplicationServices(builder.Configuration);

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
