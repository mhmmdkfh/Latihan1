using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Latihan1.Models
{
    public partial class GraphQLContext : DbContext
    {
        public GraphQLContext()
        {
        }

        public GraphQLContext(DbContextOptions<GraphQLContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=KIFAHI\\SQLEXPRESS;Database=GraphQL;uid=user;pwd=pass123;");
            }*/
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Todo>(entity =>
            {
                entity.ToTable("todo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Completed).HasColumnName("completed");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Task)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("task");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
