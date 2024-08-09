// using TvShows.DB;

using TvShows.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSingleton<ITvShowsService, TvShowsService>();

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

app.MapControllers();

app.UseCors(builder =>
    builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()
);

// app.MapGet("/tv-shows/{id}", (int id) => TvShowsDB.GetTvShow(id));
// app.MapGet("/tv-shows/", () => TvShowsDB.GetTvShows());
// app.MapPost("/tv-shows/", (TvShow tvShow) => TvShowsDB.CreateTvShow(tvShow));
// app.MapPut("/tv-shows/", (TvShow tvShow) => TvShowsDB.UpdateTvShow(tvShow));
// app.MapDelete("/tv-shows/{id}", (int id) => TvShowsDB.RemoveTvShow(id));

app.Run();