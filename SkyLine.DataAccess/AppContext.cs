using System;
using Microsoft.EntityFrameworkCore;
using SkyLine.Models;

namespace SkyLine.DataAccess
{
    public class AppContext : DbContext
    {
        public AppContext() : base()
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<SchoolLevel> SchoolLevel { get; set; }
        public DbSet<Teaching> Teaching { get; set; }
        public DbSet<ClassDetail> ClassDetail { get; set; }
        public DbSet<MasterCode> MasterCode { get; set; }
        public DbSet<MasterCodeDetail> MasterCodeDetail { get; set; }
        public DbSet<MessageGroup> MessageGroup { get; set; }
        public DbSet<MessageDetail> MessageDetail { get; set; }
        public DbSet<WorkOnClass> WorkOnClass { get; set; }
        public DbSet<StudentMenu> StudentMenu { get; set; }
        public DbSet<StandardMaster> StandardMaster { get; set; }
        public DbSet<StudentHealthData> StudentHealthData { get; set; }
        public DbSet<HealthDiary> HealthDiary { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<News> News { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClassDetail>()
            .HasKey(c => new { c.ClassID, c.StudentID });

            modelBuilder.Entity<Teaching>()
            .HasKey(c => new { c.ClassID, c.TeacherID });
            
            modelBuilder.Entity<MasterCodeDetail>()
            .HasKey(c => new { c.MasterID, c.MasterDetailID });
            
            modelBuilder.Entity<StudentHealthData>()
            .HasKey(c => new { c.Month, c.StudentID });
                                                 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connstr = @"Server=tcp:ndtinit.database.windows.net,1433;Initial Catalog=SkyLine;Persist Security Info=False;User ID=SkyLineUser01;Password=SkyLine123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            optionsBuilder.UseSqlServer(connstr);
        }
    }
}
