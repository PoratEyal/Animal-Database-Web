var builder = WebApplication.CreateBuilder(args);

// add services
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddScoped<IFileUploadService, LocalFileUploadService>();

// add the connection string for the Databases
builder.Services.AddDbContext<MyDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("defualtConnection")));
builder.Services.AddDbContext<AuthenticationContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("Authentication")));

// add the identity service and remove all the rules for the password
builder.Services.AddIdentity<IdentityUser, IdentityRole>(o =>
{
    // configure identity options
    o.Password.RequireDigit = false;
    o.Password.RequireLowercase = false;
    o.Password.RequireUppercase = false;
    o.Password.RequireNonAlphanumeric = false;
    o.Password.RequiredLength = 6;
})
.AddEntityFrameworkStores<AuthenticationContext>().AddDefaultTokenProviders();

// configure the login path routing
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
});


builder.Services.AddControllersWithViews();
var app = builder.Build();

// create animals DB
using (var scope = app.Services.CreateScope())
{
    var ctx = scope.ServiceProvider.GetRequiredService<MyDbContext>();
    ctx.Database.EnsureDeleted();
    ctx.Database.EnsureCreated();
}

// create users DB
using (var scope = app.Services.CreateScope())
{
    var ctx = scope.ServiceProvider.GetRequiredService<AuthenticationContext>();
    ctx.Database.EnsureDeleted();
    ctx.Database.EnsureCreated();
}


app.UseStaticFiles();
app.UseAuthentication();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute("Default", "{controller=Home}/{action=HomePage}/{id?}");

app.Run();
