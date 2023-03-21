using Microsoft.EntityFrameworkCore;
using StaffApplication.Data;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<StaffContext>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
       
        ));


var app = builder.Build();





//builder.Services.AddDbContext<StaffContext>(options =>
//{
//    options.UseSqlServer(builder.Configuration.GetConnectionString("StaffDB"));
//});



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

app.UseAuthorization();
app.Use(async (context, next) =>
    {
        try
        {
            await next(context);
        }
        catch (Exception e)
        {
           context.Response.StatusCode = 500;
        }
        
        
    }
);

app.MapRazorPages();

app.Run();
