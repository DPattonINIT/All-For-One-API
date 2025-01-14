using All_For_One_API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<SayHelloService>();
builder.Services.AddScoped<AskingQuestionsService>();
builder.Services.AddScoped<AddingTwoNumbersService>();
builder.Services.AddScoped<MadLibService>();
builder.Services.AddScoped<OddOrEvenService>();
builder.Services.AddScoped<ReverseItNumberService>();
builder.Services.AddScoped<ReverseItWordService>();
builder.Services.AddScoped<Magic8BallService>();
builder.Services.AddScoped<GuessItService>();
builder.Services.AddScoped<RestaurantPickerService>();



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
