using Microsoft.EntityFrameworkCore;
using RESTfulAPI.Models;
using System;
using System.Linq;
using Task = RESTfulAPI.Models.Task;

namespace RESTfulAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<ProjectTeam> ProjectTeams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectTeam>()
                .HasKey(pt => new { pt.ProjectId, pt.TeamId });

            modelBuilder.Entity<ProjectTeam>()
                .HasOne(pt => pt.Project)
                .WithMany(p => p.ProjectTeams)
                .HasForeignKey(pt => pt.ProjectId);

            modelBuilder.Entity<ProjectTeam>()
                .HasOne(pt => pt.Team)
                .WithMany(t => t.ProjectTeams)
                .HasForeignKey(pt => pt.TeamId);

            // Додати початкові дані до бази даних
            Seed(modelBuilder);
        }

        private void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(
                new Project { Id = 1, Name = "Project 1", Details = "Details of Project 1" },
                new Project { Id = 2, Name = "Project 2", Details = "Details of Project 2" }
            );

            modelBuilder.Entity<Team>().HasData(
                new Team { Id = 1, Name = "Team 1", Description = "Description of Team 1" },
                new Team { Id = 2, Name = "Team 2", Description = "Description of Team 2" }
            );

            modelBuilder.Entity<ProjectTeam>().HasData(
                new ProjectTeam { ProjectId = 1, TeamId = 1 },
                new ProjectTeam { ProjectId = 2, TeamId = 2 }
            );

            modelBuilder.Entity<Task>().HasData(
                new Task { Id = 1, Title = "Task 1", Details = "Details of Task 1", Deadline = DateTime.Now.AddDays(7), ProjectId = 1 },
                new Task { Id = 2, Title = "Task 2", Details = "Details of Task 2", Deadline = DateTime.Now.AddDays(14), ProjectId = 2 }
            );
        }
    }
}
