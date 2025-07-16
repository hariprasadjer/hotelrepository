using HotelInventoryMiddleware.Adapters;
using HotelInventoryMiddleware.Data;
using HotelInventoryMiddleware.Services;
using Microsoft.EntityFrameworkCore;

namespace HotelInventoryMiddleware
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<Data.HotelContext>(options =>
                options.UseInMemoryDatabase("hotelDb"));

            builder.Services.AddScoped<Adapters.ITspAdapter, Adapters.DummyTspAdapter>();
            builder.Services.AddScoped<Services.ITspService, Services.TspService>();
            builder.Services.AddScoped<Services.IHotelService, Services.HotelService>();

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
        }
    }
}
