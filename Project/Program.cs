using Microsoft.EntityFrameworkCore;
using Project.DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(
    opt=>opt.UseSqlServer(builder.Configuration.GetConnectionString("default"))
    
    
    );
var app = builder.Build();
app.UseStaticFiles();

app.MapControllerRoute(
    "default",
    pattern:"{controller=home}/{action=index}/{id?}"
    );

app.Run();
