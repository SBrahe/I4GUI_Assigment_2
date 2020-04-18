using Microsoft.EntityFrameworkCore;
using I4GUI_Assigment_2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineHelpSystem.Data
{
    partial class MyDbContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            //Student
            modelbuilder.Entity<Student>()
                .HasKey(s => s.AuId);

            //Courses
            modelbuilder.Entity<Course>()
                .HasKey(c => c.CourseId);

            //Teachers
            modelbuilder.Entity<Teacher>()
                .HasKey(t => t.TAuId);

            modelbuilder.Entity<Teacher>()
               .HasOne<Course>(t => t.Course)
               .WithMany(t => t.Teachers)
               .HasForeignKey(t => t.CourseId);

            //Assignments
            modelbuilder.Entity<Assignment>().Property(a => a.Open).HasDefaultValue(true);      
               
            modelbuilder.Entity<Assignment>()
                .HasKey(a => a.AssignmentNumber);
            
            modelbuilder.Entity<Assignment>()
                .HasOne<Course>(a => a.Course)
                .WithMany(a => a.Assignments)
                .HasForeignKey(a => a.CourseId);

            modelbuilder.Entity<Assignment>()
                .HasOne<Teacher>(a => a.Teacher)
                .WithMany(a => a.Assignments)
                .HasForeignKey(a => a.TAuId);


            //Exercises
            modelbuilder.Entity<Exercise>().Property(e => e.Open).HasDefaultValue(true);

            modelbuilder.Entity<Exercise>()
                .HasKey(e => new { e.Lecture, e.ExerciseNumber });

    
            modelbuilder.Entity<Exercise>()
             .HasOne<Student>(e => e.Student)
             .WithMany(e => e.Exercises)
             .HasForeignKey(e => e.AuId);

            modelbuilder.Entity<Exercise>()
            .HasOne<Course>(e => e.Course)
            .WithMany(e => e.Exercises)
            .HasForeignKey(e => e.CourseId);

            modelbuilder.Entity<Exercise>()
            .HasOne<Teacher>(e => e.Teacher)
            .WithMany(e => e.Exercises)
            .HasForeignKey(e => e.TAuId);


            //StudentAssignment
            modelbuilder.Entity<StudentAssignment>()
                .HasKey(sa => new { sa.AuId, sa.AssignmentNumber });

            modelbuilder.Entity<StudentAssignment>()
                .HasOne(sa => sa.Student)
                .WithMany(sa => sa.StudentAssignments)
                .HasForeignKey(sa => sa.AuId);


            modelbuilder.Entity<StudentAssignment>()
              .HasOne(sa => sa.Assignment)
              .WithMany(sa => sa.StudentAssignments)
              .HasForeignKey(sa => sa.AssignmentNumber);



            //StudentCourses
            modelbuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.AuId, sc.CourseId });


            modelbuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(sc => sc.StudentCourses)
                .HasForeignKey(sc => sc.AuId);

            modelbuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(sc => sc.StudentCourses)
                .HasForeignKey(sc => sc.CourseId);
        }
    }
}