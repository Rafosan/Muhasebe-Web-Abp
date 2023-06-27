using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MuhasebeWeb.Authorization.Roles;
using MuhasebeWeb.Authorization.Users;
using MuhasebeWeb.MultiTenancy;
using MuhasebeWeb.Entity.Gelir;
using MuhasebeWeb.Entity.Gider;
using MuhasebeWeb.Entity.AlimTurleri;
using MuhasebeWeb.Entity.Birim;
using MuhasebeWeb.Entity.AlimUsulu;

namespace MuhasebeWeb.EntityFrameworkCore
{
	public class MuhasebeWebDbContext : AbpZeroDbContext<Tenant, Role, User, MuhasebeWebDbContext>
    {
		/* Define a DbSet for each entity of the application */
		public DbSet<BirimEntity> Birim { get; set; }
		public DbSet<AlimTuruEntity> AlimTuru { get; set; }
		public DbSet<AlimUsuluEntity> AlimUsulu { get; set; }
        public DbSet<GelirEntity> Gelir { get; set; }
        public DbSet<GiderEntity> Gider { get; set; }

		public MuhasebeWebDbContext(DbContextOptions<MuhasebeWebDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ChangeAbpTablePrefix<Tenant, Role, User>(""); //Removes table prefixes. You can specify another prefix.
        }
    }
}
