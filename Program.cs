using efept.Components;
using efept.Components.Account;
using efept.Data;
using efept.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using efept.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

var dbUser = Environment.GetEnvironmentVariable("Uid_efept");
var dbPassword = Environment.GetEnvironmentVariable("Pwd_efept");
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
connectionString += $"Uid={dbUser};Pwd={dbPassword};";

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionString!, ServerVersion.AutoDetect(connectionString)));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

var smtp_Username = Environment.GetEnvironmentVariable("Smtp_Username");
var smtp_Password = Environment.GetEnvironmentVariable("Smtp_Password");

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, EmailSender>(
    serviceProvider => new EmailSender(
    smtpServer: builder.Configuration["Smtp:Server"]!,
    smtpPort: int.Parse(builder.Configuration["Smtp:Port"]!),
    smtpUsername: smtp_Username!,
    smtpPassword: smtp_Password!
    ));

builder.Services.AddScoped<ITarjetaService, TarjetaService>();
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<IComentarioService, ComentarioService>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<ILegalService, LegalService>();
builder.Services.AddScoped<IAboutService, AboutService>();
builder.Services.AddScoped<IBlogService, BlogService>();
builder.Services.AddScoped<ICorreoService, CorreoService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

app.MapHub<PostHub>("/postHub");

app.Run();
