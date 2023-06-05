using AdiSchedule.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);
//Syncfusion License key
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt+QHJqXU1hXk5Hd0BLVGpAblJ3T2ZQdVt5ZDU7a15RRnVfRF1mSXdTc0BgXn9ddQ==;Mgo+DSMBPh8sVXJ1S0R+VFpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jT35WdkxjXHpdd3VdQw==;ORg4AjUWIQA/Gnt2VFhiQllPd11dXmJWd1p/THNYflR1fV9DaUwxOX1dQl9gSXhTc0VqWXpbc3NQRGU=;MjMxMzg1MkAzMjMxMmUzMDJlMzBIeCtFQnNLVlIzK0h1MHVwTEl3Yy9mUTcwR211Smh3alFXdHIzMTFYb2YwPQ==;MjMxMzg1M0AzMjMxMmUzMDJlMzBQYjBtc3VXdkZXL2hzcmw1UUVTZWpycVQ3RzY2UDVwUjJOZFdyNno0anNnPQ==;NRAiBiAaIQQuGjN/V0d+Xk9MfV5AQmBIYVp/TGpJfl96cVxMZVVBJAtUQF1hSn5VdkBjUH9bdXdcR2JZ;MjMxMzg1NUAzMjMxMmUzMDJlMzBvZFVaZDJOWGV1M1FWR2p2WlV1M1NRUUcwM3hZVEdRTnd0VGdQUk9TdG1zPQ==;MjMxMzg1NkAzMjMxMmUzMDJlMzBMdkU0akhBT3UyTjk1RkVjM2RoYmhtSzB5NDhCSmlGeWFzNHptM1UwTDNVPQ==;Mgo+DSMBMAY9C3t2VFhiQllPd11dXmJWd1p/THNYflR1fV9DaUwxOX1dQl9gSXhTc0VqWXpbc31cTmU=;MjMxMzg1OEAzMjMxMmUzMDJlMzBuNXdoY1lQQjlSbFBnUFp3akZBTW5oTncyVEluaVJCYm5uRXZ5VG9hUGdBPQ==;MjMxMzg1OUAzMjMxMmUzMDJlMzBJaGZRbnhFRkFTWVRIMDk5dWtjcmFXMFhCWVhQZG9Ma2dld2NEOFBHUUpBPQ==;MjMxMzg2MEAzMjMxMmUzMDJlMzBvZFVaZDJOWGV1M1FWR2p2WlV1M1NRUUcwM3hZVEdRTnd0VGdQUk9TdG1zPQ==");
builder.Services.AddSyncfusionBlazor();
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<DialogService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
