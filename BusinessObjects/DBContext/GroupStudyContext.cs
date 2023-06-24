using System;
using System.Collections.Generic;
using BusinessObjects.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BusinessObjects.DBContext;

public partial class GroupStudyContext : DbContext
{
    public GroupStudyContext()
    {
    }

    public GroupStudyContext(DbContextOptions<GroupStudyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<Participant> Participants { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Slot> Slots { get; set; }

    public virtual DbSet<StudyMaterial> StudyMaterials { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(GetConnectionString());

    private string GetConnectionString()
    {
        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true).Build();

        return configuration["ConnectionStrings:DefaultConnectionString"];
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasOne(d => d.Subject).WithMany(p => p.Groups)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Group_Subject");
        });

        modelBuilder.Entity<Participant>(entity =>
        {
            entity.HasOne(d => d.Group).WithMany()
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Participant_Group");

            entity.HasOne(d => d.User).WithMany()
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Participant_User");
        });

        modelBuilder.Entity<Slot>(entity =>
        {
            entity.HasOne(d => d.Group).WithMany(p => p.Slots)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Slot_Group");
        });

        modelBuilder.Entity<StudyMaterial>(entity =>
        {
            entity.HasOne(d => d.Slot).WithMany(p => p.StudyMaterials)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_StudyMaterial_Slot");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_User_Role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
