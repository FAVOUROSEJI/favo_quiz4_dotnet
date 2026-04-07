using Microsoft.EntityFrameworkCore;
using quiz4_dotnet.Data;  // If you have a Data folder

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllersWithViews();

// Add DbContext for SQLite (from your assignment)
builder.Services.AddDbContext<SchoolContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();  // Keep this - it's the .NET 8 way

app.UseRouting();

app.UseAuthorization();

// REMOVE: app.MapStaticAssets();  <-- DELETE THIS LINE

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
// REMOVE: .WithStaticAssets();  <-- DELETE THIS

app.Run();