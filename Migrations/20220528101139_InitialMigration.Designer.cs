﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Xpense.Data;

namespace Xpense.Migrations
{
    [DbContext(typeof(ExpenseContext))]
    [Migration("20220528101139_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Xpense.Models.ExpenseCategory", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("id");

                    b.Property<string>("CategoryName")
                        .HasColumnType("text")
                        .HasColumnName("category_name");

                    b.Property<DateTimeOffset>("DateCreated")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_created");

                    b.HasKey("Id");

                    b.ToTable("expense_categories");
                });

            modelBuilder.Entity("Xpense.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("id");

                    b.Property<DateTimeOffset>("DateJoined")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_joined");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Username")
                        .HasColumnType("text")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Xpense.Models.UserExpense", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("id");

                    b.Property<string>("CategoryId")
                        .HasColumnType("text")
                        .HasColumnName("category_id");

                    b.Property<DateTimeOffset>("DateCreated")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_created");

                    b.Property<int>("ExpenseAmount")
                        .HasColumnType("integer")
                        .HasColumnName("expense_amount");

                    b.Property<string>("ExpenseName")
                        .HasColumnType("text")
                        .HasColumnName("expense_name");

                    b.HasKey("Id");

                    b.ToTable("user_expenses");
                });
#pragma warning restore 612, 618
        }
    }
}
