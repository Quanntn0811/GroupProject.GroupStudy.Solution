using System;
using System.Collections.Generic;
using BusinessObjects.EntityModels;
using Microsoft.EntityFrameworkCore;

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

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<Participant> Participants { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Slot> Slots { get; set; }

    public virtual DbSet<StudyMaterial> StudyMaterials { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=(local);database=GroupStudy;uid=sa;pwd=123456789;Trustservercertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasOne(d => d.StudyMaterial).WithMany(p => p.Comments).HasConstraintName("FK_Comment_StudyMaterial");

            entity.HasOne(d => d.User).WithMany(p => p.Comments).HasConstraintName("FK_Comment_User");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasOne(d => d.Subject).WithMany(p => p.Groups)
                .OnDelete(DeleteBehavior.ClientSetNull)
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
