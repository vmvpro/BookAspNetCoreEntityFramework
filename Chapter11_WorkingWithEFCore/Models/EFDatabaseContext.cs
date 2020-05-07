using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
// ReSharper disable All

namespace Chapter11_WorkingWithEFCore.Models
{
	public class EFDatabaseContext : DbContext
	{
		public EFDatabaseContext(DbContextOptions options) : base(options){}

		public DbSet<Product> Products { get; set; }
	}
}
