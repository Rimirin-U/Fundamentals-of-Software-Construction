
using Microsoft.EntityFrameworkCore;
using OrderApp;

namespace OrderWebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var builder = WebApplication.CreateBuilder(args);
            //builder.Services.AddDbContext<OrderDbContext>(options =>
            //    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            // **ADDED**
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var connectionString = "Server=localhost;Database=OrderDataBase;User=root;password=cr3502427;";
            var serverVersion = ServerVersion.AutoDetect(connectionString);

            builder.Services.AddDbContext<OrderDbContext>(opt =>
                opt.UseMySql(connectionString, serverVersion));

            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
