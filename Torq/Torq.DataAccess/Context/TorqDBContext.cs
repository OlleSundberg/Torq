﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Torq.Models.Objects;

namespace Torq.DataAccess.Context
{
	public class TorqDBContext : DbContext
	{
		public TorqDBContext() : base("TorqDB") { }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<Salary> Salaries { get; set; }
		public DbSet<Schedule> Schedules { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}
