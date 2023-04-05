using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.SqlServer.Infrastructure.Internal;
using Microsoft.CodeAnalysis;
using System;
using System.Linq.Expressions;
using StaffApplication.Models;

namespace StaffApplication.Data
{
    public class StaffContext : DbContext
    {

        //public string ConnectionString => _connectionString;
        //private readonly string _connectionString;
        public StaffContext(DbContextOptions<StaffContext> options) : base(options)
        {
            //if (options != null)
            //{
            //    //extract connnection string
            //    var extension = options.FindExtension<SqlServerOptionsExtension>();
            //    _connectionString = extension.ConnectionString;
            //}
        }

        //private void CreateIndex<T>(ModelBuilder builder, Expression<Func<T, object>> KeyPropertyExpression, string IndexName = "IX_Unique", bool IsUnique = true)
        //    where T : class
        //{
        //    var indexBuilder = builder.Entity<T>().HasIndex(KeyPropertyExpression);
        //    if (!string.IsNullOrEmpty(IndexName)) indexBuilder.HasName(IndexName);
        //    if (IsUnique) indexBuilder.IsUnique();
        //}
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    // Call the base class first:
        //    base.OnModelCreating(builder);
        //    if (builder != null)
        //    {
        //        CreateIndex<LookupMapping>(builder, r => new { r.ClasName, r.Parent_ClassName });
        //        CreateIndex<DocumentCertification>(builder, r => new { r.ReceiptNumber });
        //        CreateIndex<ResolutionRegistration>(builder, r => new { r.ReceiptNumber });
        //        CreateIndex<CooperativeDetailsSearch>(builder, r => new { r.ReceiptNumber });
        //        CreateIndex<Cooperative>(builder, r => new { r.ReceiptNumber });
        //    }
        //}


        public DbSet<Staff> Staff { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}
