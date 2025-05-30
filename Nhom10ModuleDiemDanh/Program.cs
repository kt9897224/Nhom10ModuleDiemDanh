using Nhom10ModuleDiemDanh.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// ��ng k? HttpClient
builder.Services.AddHttpClient();

// Register ICoSoService with HttpClient and set the correct BaseAddress
builder.Services.AddHttpClient<ICoSoService, CoSoService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7296/"); // �?m b?o kh?p v?i API project
});

builder.Services.AddHttpClient<IBoMonCoSoService, BoMonCoSoService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration["ApiBaseUrl"] ?? "https://localhost:7296/");
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Th�m �? debug d? h�n trong m�i tr�?ng dev
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();