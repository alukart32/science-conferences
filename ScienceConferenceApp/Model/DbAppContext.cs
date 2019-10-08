namespace ScienceConferenceApp.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbAppContext : DbContext
    {
        public DbAppContext()
            : base("name=DbAppContext")
        {
        }

        public virtual DbSet<academicDegree> academicDegrees { get; set; }
        public virtual DbSet<address> addresses { get; set; }
        public virtual DbSet<company> companies { get; set; }
        public virtual DbSet<conference> conferences { get; set; }
        public virtual DbSet<country> countries { get; set; }
        public virtual DbSet<participant> participants { get; set; }
        public virtual DbSet<scientist> scientists { get; set; }
        public virtual DbSet<subject> subjects { get; set; }
        public virtual DbSet<theme> themes { get; set; }
        public virtual DbSet<ViewConference> ViewConferences { get; set; }
        public virtual DbSet<ViewConferencesWithParticipant> ViewConferencesWithParticipants { get; set; }
        public virtual DbSet<ViewParticipant> ViewParticipants { get; set; }
        public virtual DbSet<ViewScientist> ViewScientists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<academicDegree>()
                .Property(e => e.degree)
                .IsUnicode(false);

            modelBuilder.Entity<academicDegree>()
                .HasMany(e => e.scientists)
                .WithOptional(e => e.academicDegree1)
                .HasForeignKey(e => e.academicDegree);

            modelBuilder.Entity<address>()
                .Property(e => e.address1)
                .IsUnicode(false);

            modelBuilder.Entity<address>()
                .HasMany(e => e.conferences)
                .WithOptional(e => e.address1)
                .HasForeignKey(e => e.address);

            modelBuilder.Entity<company>()
                .Property(e => e.companyName)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .HasMany(e => e.scientists)
                .WithOptional(e => e.company1)
                .HasForeignKey(e => e.company);

            modelBuilder.Entity<conference>()
                .Property(e => e.conferenceName)
                .IsUnicode(false);

            modelBuilder.Entity<conference>()
                .HasMany(e => e.participants)
                .WithRequired(e => e.conference1)
                .HasForeignKey(e => e.conference)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<country>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<country>()
                .HasMany(e => e.addresses)
                .WithOptional(e => e.country1)
                .HasForeignKey(e => e.country);

            modelBuilder.Entity<country>()
                .HasMany(e => e.companies)
                .WithOptional(e => e.country1)
                .HasForeignKey(e => e.country);

            modelBuilder.Entity<country>()
                .HasMany(e => e.scientists)
                .WithOptional(e => e.country1)
                .HasForeignKey(e => e.country);

            modelBuilder.Entity<participant>()
                .Property(e => e.publication)
                .IsUnicode(false);

            modelBuilder.Entity<scientist>()
                .Property(e => e.firstName)
                .IsUnicode(false);

            modelBuilder.Entity<scientist>()
                .Property(e => e.secondName)
                .IsUnicode(false);

            modelBuilder.Entity<scientist>()
                .HasMany(e => e.participants)
                .WithRequired(e => e.scientist1)
                .HasForeignKey(e => e.scientist)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<subject>()
                .Property(e => e.subject1)
                .IsUnicode(false);

            modelBuilder.Entity<subject>()
                .HasMany(e => e.participants)
                .WithRequired(e => e.subject1)
                .HasForeignKey(e => e.subject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<theme>()
                .Property(e => e.themeName)
                .IsUnicode(false);

            modelBuilder.Entity<theme>()
                .HasMany(e => e.participants)
                .WithOptional(e => e.theme1)
                .HasForeignKey(e => e.theme);

            modelBuilder.Entity<ViewConference>()
                .Property(e => e.conferenceName)
                .IsUnicode(false);

            modelBuilder.Entity<ViewConference>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<ViewConference>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<ViewConferencesWithParticipant>()
                .Property(e => e.subject)
                .IsUnicode(false);

            modelBuilder.Entity<ViewConferencesWithParticipant>()
                .Property(e => e.themeName)
                .IsUnicode(false);

            modelBuilder.Entity<ViewConferencesWithParticipant>()
                .Property(e => e.firstName)
                .IsUnicode(false);

            modelBuilder.Entity<ViewConferencesWithParticipant>()
                .Property(e => e.secondName)
                .IsUnicode(false);

            modelBuilder.Entity<ViewConferencesWithParticipant>()
                .Property(e => e.degree)
                .IsUnicode(false);

            modelBuilder.Entity<ViewConferencesWithParticipant>()
                .Property(e => e.companyName)
                .IsUnicode(false);

            modelBuilder.Entity<ViewConferencesWithParticipant>()
                .Property(e => e.conferenceName)
                .IsUnicode(false);

            modelBuilder.Entity<ViewConferencesWithParticipant>()
                .Property(e => e.publication)
                .IsUnicode(false);

            modelBuilder.Entity<ViewParticipant>()
                .Property(e => e.publication)
                .IsUnicode(false);

            modelBuilder.Entity<ViewScientist>()
                .Property(e => e.firstName)
                .IsUnicode(false);

            modelBuilder.Entity<ViewScientist>()
                .Property(e => e.secondName)
                .IsUnicode(false);

            modelBuilder.Entity<ViewScientist>()
                .Property(e => e.degree)
                .IsUnicode(false);

            modelBuilder.Entity<ViewScientist>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<ViewScientist>()
                .Property(e => e.companyName)
                .IsUnicode(false);
        }
    }
}
