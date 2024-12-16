﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace StudentIMS.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Advisor> Advisors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourseSelection> StudentCourseSelections { get; set; }
        public DbSet<Transcript> Transcripts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
     

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudentCourseSelection>(entity =>
            {
                entity.HasKey(e => e.SelectionID);
                entity.HasOne(e => e.Student)
                      .WithMany(s => s.StudentCourseSelections)
                      .HasForeignKey(e => e.StudentID);

                entity.HasOne(e => e.Course)
                      .WithMany(c => c.StudentCourseSelections)
                      .HasForeignKey(e => e.CourseID);
            });
        }
    }
}
