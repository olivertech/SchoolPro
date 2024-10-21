using Microsoft.EntityFrameworkCore;
using SchoolPro.Core.Entities;
using System.Reflection;

namespace SchoolPro.Infra.Context
{
    public class SchoolProDbContext : DbContext
    {
        public SchoolProDbContext(DbContextOptions<SchoolProDbContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FeatureRole> FeaturesRole { get; set; }
        public DbSet<FeeType> FeeTypes { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<SchoolCalendar> SchoolCalendars { get; set; }
        public DbSet<SchoolEnrollment> SchoolEnrollments { get; set; }
        public DbSet<SchoolFee> SchoolFees { get; set; }
        public DbSet<SchoolSubject> SchoolSubjects { get; set; }
        public DbSet<SchoolYear> SchoolYears { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }
        public DbSet<StudentGrade> StudentGrades { get; set; }
        public DbSet<StudentParent> StudentParents { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherSchoolSubject> TeacherSchoolSubjects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        /// <summary>
        /// Faz referencia as classes de configurações das entidades
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
