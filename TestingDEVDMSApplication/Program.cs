using Microsoft.EntityFrameworkCore;
using TestingDEVDMSApplication.Context;
using TestingDEVDMSApplication.Repositories;
using TestingDEVDMSApplication.Repositories.Interface;
using TestingDEVDMSApplication.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// DB
builder.Services.AddDbContext<DmsDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Repositories
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IEducationRepository, EducationRepository>();
builder.Services.AddScoped<IOwnershipOfResidenceRepository, OwnershipOfResidenceRepository>();
builder.Services.AddScoped<ICompanyCategoryRepository, CompanyCategoryRepository>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<IRecordPaymentTrackRepository, RecordPaymentTrackRepository>();
builder.Services.AddScoped<ITrackDataSLIKRepository, TrackDataSLIKRepository>();
builder.Services.AddScoped<IPemilikanKartuKreditRepository, PemilikanKartuKreditRepository>();
builder.Services.AddScoped<ITujuanDariPembiayaanRepository, TujuanDariPembiayaanRepository>();

// Services
builder.Services.AddScoped<ICustomerService, CustomerService>();

builder.Services.AddControllers()
    .AddJsonOptions(o =>
    {
        o.JsonSerializerOptions.PropertyNamingPolicy = null;
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
