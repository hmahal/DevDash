﻿// <auto-generated />
using DevDash.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DevDash.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20171119203411_efasda")]
    partial class efasda
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DevDash.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<bool>("GithubAuthenticated");

                    b.Property<string>("GithubKey");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TrelloAuthenticated");

                    b.Property<string>("TrelloKey");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("DevDash.Models.Dashboard", b =>
                {
                    b.Property<Guid>("DashboardId")
                        .HasColumnName("dashboardID");

                    b.Property<string>("BoardId")
                        .IsRequired()
                        .HasColumnName("boardID")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("DashboardName")
                        .IsRequired()
                        .HasColumnName("dashboardName")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<long>("RepoId")
                        .HasColumnName("repoID")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("UserId")
                        .HasColumnName("userID");

                    b.HasKey("DashboardId");

                    b.HasIndex("UserId", "BoardId");

                    b.HasIndex("UserId", "RepoId");

                    b.ToTable("Dashboard");
                });

            modelBuilder.Entity("DevDash.Models.GitHub", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnName("userID");

                    b.Property<long>("RepoId")
                        .HasColumnName("repoID")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("RepoName")
                        .IsRequired()
                        .HasColumnName("repoName")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("UserId", "RepoId");

                    b.HasAlternateKey("RepoName");

                    b.ToTable("GitHub");
                });

            modelBuilder.Entity("DevDash.Models.Trello", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnName("userID");

                    b.Property<string>("BoardId")
                        .HasColumnName("boardID")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("BoardName")
                        .IsRequired()
                        .HasColumnName("boardName")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("UserId", "BoardId");

                    b.ToTable("Trello");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DevDash.Models.Dashboard", b =>
                {
                    b.HasOne("DevDash.Models.ApplicationUser", "User")
                        .WithMany("Dashboard")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Dashboard_ToUser");

                    b.HasOne("DevDash.Models.Trello", "Trello")
                        .WithMany("Dashboard")
                        .HasForeignKey("UserId", "BoardId")
                        .HasConstraintName("FK_Dashboard_ToTrello");

                    b.HasOne("DevDash.Models.GitHub", "GitHub")
                        .WithMany("Dashboard")
                        .HasForeignKey("UserId", "RepoId")
                        .HasConstraintName("FK_Dashboard_ToGithub");
                });

            modelBuilder.Entity("DevDash.Models.GitHub", b =>
                {
                    b.HasOne("DevDash.Models.ApplicationUser", "User")
                        .WithMany("GitHub")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_GitHub_ToUser");
                });

            modelBuilder.Entity("DevDash.Models.Trello", b =>
                {
                    b.HasOne("DevDash.Models.ApplicationUser", "User")
                        .WithMany("Trello")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Trello_ToUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DevDash.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DevDash.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DevDash.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DevDash.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
