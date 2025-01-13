using AllForOneAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<SayHelloServices>();
builder.Services.AddScoped<Add2NumServices>();
builder.Services.AddScoped<AskingQuestionsServices>();
builder.Services.AddScoped<MadLibServices>();
builder.Services.AddScoped<OddEvenServices>();
builder.Services.AddScoped<StringReverseServices>();
builder.Services.AddScoped<NumberReverseServices>();
builder.Services.AddScoped<Magic8BallServices>();


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
