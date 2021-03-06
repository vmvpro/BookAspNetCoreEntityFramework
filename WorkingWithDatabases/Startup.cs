﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkingWithDatabases.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WorkingWithDatabases
{
	public class Startup
	{
		public Startup(IConfiguration config) => Configuration = config;

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc();
			string conString = Configuration["ConnectionStrings:DefaultConnection"];
			services.AddDbContext<DataContext>(options =>
				options.UseSqlServer(conString));

			services.AddDbContext<DataContext>(options =>
			{
				options.EnableSensitiveDataLogging(true);
				options.UseSqlServer(conString);
			});
		}


		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			app.UseDeveloperExceptionPage();
			app.UseStatusCodePages();
			app.UseStaticFiles();
			app.UseMvcWithDefaultRoute();
		}
	}
}
