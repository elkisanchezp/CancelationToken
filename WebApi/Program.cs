using ExampleCancelationToken.Infraextructura.Extensions;
using ExampleCancelationToken.Application.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddAplication();


builder.Services.AddPersistenceInfraestructure(builder.Configuration);

// Add services to the container.

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

app.Services.MigrateDatabase();

app.UseAuthorization();

//app.Use(async (context, next) =>
//{
//    using (var cts = new CancellationTokenSource())
//    {
//        context.RequestAborted.Register(() => cts.Cancel());
//        context.Items["CancellationToken"] = cts.Token;

//        await next();
//    }
//});


app.MapControllers();

app.Run();
