using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

// Create builder
var builder = WebApplication.CreateBuilder(args);

// Add DbContext. This is the database for the app.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add Identity. This is the authentication system for the app.
builder.Services.AddIdentity<AppUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

// Configure Application Cookie. This is the cookie handler for the app.
builder.Services.ConfigureApplicationCookie(options => 
{
    options.LoginPath = "/Account/Login";
    options.AccessDeniedPath = "/Account/AccessDenied";
});

// Add services to the container.
builder.Services.AddControllersWithViews();

// Build the app to use the services.
var app = builder.Build();

// Configure the HTTP request pipeline. This is the middleware for the app. Can access the app through the browser.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Use Https Redirection for security. Required for HTTPS to work.
app.UseHttpsRedirection();

// Use Static Files for CSS, JS, Images, etc.
app.UseStaticFiles();

// Use Routing for MVC. Required for MVC to work.
app.UseRouting();

// Use Authorization for authentication. Usage of the app is restricted to authenticated users.
app.UseAuthorization();

// Map Controllers for MVC and API. This controls the routing for the app.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Run the app
app.Run();

using (var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    string[] roles = new[] { "Administrador", "Vendedor" };

    foreach (var role in roles)
    {
        if (!await roleManager.RoleExistsAsync(role))
            await roleManager.CreateAsync(new IdentityRole(role));
    }
}
