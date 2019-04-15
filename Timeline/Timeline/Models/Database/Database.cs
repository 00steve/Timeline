namespace TimelineApp.Models.Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Database : DbContext
    {
        public Database()
            : base("name=Database")
        {
        }

        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<EventReference> EventReferences { get; set; }
        public virtual DbSet<MediaType> MediaTypes { get; set; }
        public virtual DbSet<Scale> Scales { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Timeline> Timelines { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<EventTag> EventTags { get; set; }
        public virtual DbSet<TimelineTag> TimelineTags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>()
                .Property(e => e.ID)
                .HasPrecision(19, 0);

            modelBuilder.Entity<Event>()
                .Property(e => e.TimelineID)
                .HasPrecision(19, 0);

            modelBuilder.Entity<Event>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Event>()
                .Property(e => e.Information)
                .IsUnicode(false);

            modelBuilder.Entity<Event>()
                .Property(e => e.When)
                .HasPrecision(0);

            modelBuilder.Entity<Event>()
                .Property(e => e.CreatedDate)
                .HasPrecision(0);

            modelBuilder.Entity<Event>()
                .Property(e => e.ModifiedDate)
                .HasPrecision(0);

            modelBuilder.Entity<Event>()
                .Property(e => e.CausedByID)
                .HasPrecision(19, 0);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.Event1)
                .WithRequired(e => e.Event2)
                .HasForeignKey(e => e.CausedByID);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.EventReferences)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.EventTags)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventReference>()
                .Property(e => e.ID)
                .HasPrecision(19, 0);

            modelBuilder.Entity<EventReference>()
                .Property(e => e.EventID)
                .HasPrecision(19, 0);

            modelBuilder.Entity<EventReference>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<EventReference>()
                .Property(e => e.SourceDate)
                .HasPrecision(0);

            modelBuilder.Entity<EventReference>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<EventReference>()
                .Property(e => e.CreatedDate)
                .HasPrecision(0);

            modelBuilder.Entity<MediaType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<MediaType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<MediaType>()
                .HasMany(e => e.EventReferences)
                .WithRequired(e => e.MediaType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Scale>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Scale>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Status>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Status>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.EventReferences)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tag>()
                .Property(e => e.ID)
                .HasPrecision(19, 0);

            modelBuilder.Entity<Tag>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<Tag>()
                .Property(e => e.CreatedDate)
                .HasPrecision(0);

            modelBuilder.Entity<Tag>()
                .HasMany(e => e.EventTags)
                .WithRequired(e => e.Tag)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tag>()
                .HasMany(e => e.TimelineTags)
                .WithRequired(e => e.Tag)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Timeline>()
                .Property(e => e.ID)
                .HasPrecision(19, 0);

            modelBuilder.Entity<Timeline>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Timeline>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Timeline>()
                .Property(e => e.CreatedDate)
                .HasPrecision(0);

            modelBuilder.Entity<Timeline>()
                .Property(e => e.ModifiedDate)
                .HasPrecision(0);

            modelBuilder.Entity<Timeline>()
                .HasMany(e => e.Events)
                .WithRequired(e => e.Timeline)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Timeline>()
                .HasMany(e => e.TimelineTags)
                .WithRequired(e => e.Timeline)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Unit>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Unit>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Unit>()
                .HasMany(e => e.Timelines)
                .WithRequired(e => e.Unit)
                .HasForeignKey(e => e.MaxUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Unit>()
                .HasMany(e => e.Timelines1)
                .WithRequired(e => e.Unit1)
                .HasForeignKey(e => e.MinUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventTag>()
                .Property(e => e.EventID)
                .HasPrecision(19, 0);

            modelBuilder.Entity<EventTag>()
                .Property(e => e.TagID)
                .HasPrecision(19, 0);

            modelBuilder.Entity<EventTag>()
                .Property(e => e.CreatedDate)
                .HasPrecision(0);

            modelBuilder.Entity<TimelineTag>()
                .Property(e => e.TimelineID)
                .HasPrecision(19, 0);

            modelBuilder.Entity<TimelineTag>()
                .Property(e => e.TagID)
                .HasPrecision(19, 0);

            modelBuilder.Entity<TimelineTag>()
                .Property(e => e.CreatedDate)
                .HasPrecision(0);
        }
    }
}
