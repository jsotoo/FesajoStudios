using FesajoStudios.DataAccess;
using FesajoStudios.DataAccess.Data;
using FesajoStudios.Server.DependencyInjection;
using FesajoStudios.Shared.Configuration;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.SwaggerUI;
using System.Text;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.


// Leer el archivo de configuracion y lo traslada a un objeto fuertemente tipado
builder.Services.Configure<AppSettings>(builder.Configuration);

builder.Services.AddDbContext<FesajoStudiosDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("FesajoStudiosDb"));
    options.EnableSensitiveDataLogging();
    
});

// Configuramos ASP.NET Identity
builder.Services.AddIdentity<IdentityUserFesajoStudios, IdentityRole>(policies =>
{
    policies.Password.RequireDigit = false;
    policies.Password.RequireLowercase = false;
    policies.Password.RequireUppercase = true;
    policies.Password.RequireNonAlphanumeric = true;
    policies.Password.RequiredLength = 8;

    policies.User.RequireUniqueEmail = true;

})
    .AddEntityFrameworkStores<FesajoStudiosDbContext>()
    .AddDefaultTokenProviders();



builder.Services.AddRepositories().AddServices();


builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo()
    {
        Title = "Fesajo Studios API REST",
        Version = "v1"
    });
});

// Configuramos el contexto de seguridad del API
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    var secretKey = Encoding.UTF8.GetBytes(builder.Configuration["Jwt:SecretKey"] ??
                                           throw new InvalidOperationException("No se configuro el SecretKey"));

    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Emisor"],
        ValidAudience = builder.Configuration["Jwt:Audiencia"],
        IssuerSigningKey = new SymmetricSecurityKey(secretKey)
    };
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAny",
        builder =>
        {
            builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
        });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {

        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Fesajo Studios API v1");
        c.RoutePrefix = "swagger";
        c.DocumentTitle = "Documentación de la API REST";
        c.DocExpansion(DocExpansion.List);
    });
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}




app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
// Autorizacion (Permisos)
app.UseAuthorization();

app.MapControllers();
app.MapFallbackToFile("index.html");
app.UseCors("AllowAny");

using (var scope = app.Services.CreateScope())
{
    await UserDataSeeder.Seed(scope.ServiceProvider);
}


app.Run();
