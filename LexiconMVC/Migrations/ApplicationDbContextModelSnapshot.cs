﻿// <auto-generated />
using System;
using LexiconMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LexiconMVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LanguagePerson", b =>
                {
                    b.Property<int>("LanguagesListId")
                        .HasColumnType("int");

                    b.Property<int>("PeopleListId")
                        .HasColumnType("int");

                    b.HasKey("LanguagesListId", "PeopleListId");

                    b.HasIndex("PeopleListId");

                    b.ToTable("LanguagePerson");

                    b.HasData(
                        new
                        {
                            LanguagesListId = -1,
                            PeopleListId = -1
                        },
                        new
                        {
                            LanguagesListId = -2,
                            PeopleListId = -1
                        },
                        new
                        {
                            LanguagesListId = -3,
                            PeopleListId = -2
                        },
                        new
                        {
                            LanguagesListId = -4,
                            PeopleListId = -3
                        });
                });

            modelBuilder.Entity("LexiconMVC.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("BirthDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "cc8a47a7-3061-4511-b5d2-fe92e9fbcaed",
                            AccessFailedCount = 0,
                            BirthDate = "1800-01-01",
                            ConcurrencyStamp = "dcc405fa-61d1-44d3-acc0-858e94fd98bc",
                            Email = "admin@admin.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "Adminsson",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN@ADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEOyb1Yi6th2lPhoU+Ck+FQf3Xrx3iybhMJxK26vjAZffaw/b5G7xvA9G6jI0yzAYQg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "816bdc3a-3712-4393-afc0-e6a5bdfc7d8b",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.com"
                        });
                });

            modelBuilder.Entity("LexiconMVC.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            CityName = "Gothenburg",
                            CountryId = -1
                        },
                        new
                        {
                            Id = -2,
                            CityName = "Borås",
                            CountryId = -1
                        },
                        new
                        {
                            Id = -3,
                            CityName = "Oslo",
                            CountryId = -2
                        },
                        new
                        {
                            Id = -4,
                            CityName = "Austin",
                            CountryId = -3
                        },
                        new
                        {
                            Id = -5,
                            CityName = "Tijuana",
                            CountryId = -4
                        },
                        new
                        {
                            Id = -6,
                            CityName = "Tokyo",
                            CountryId = -5
                        },
                        new
                        {
                            Id = -7,
                            CityName = "Melbourne",
                            CountryId = -6
                        },
                        new
                        {
                            Id = -8,
                            CityName = "Chicago",
                            CountryId = -3
                        },
                        new
                        {
                            Id = -9,
                            CityName = "Kyoto",
                            CountryId = -5
                        },
                        new
                        {
                            Id = -10,
                            CityName = "Bergen",
                            CountryId = -2
                        });
                });

            modelBuilder.Entity("LexiconMVC.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Continent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Continent = "Europe",
                            CountryName = "Sweden"
                        },
                        new
                        {
                            Id = -2,
                            Continent = "Europe",
                            CountryName = "Norway"
                        },
                        new
                        {
                            Id = -3,
                            Continent = "North America",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = -4,
                            Continent = "South America",
                            CountryName = "Mexico"
                        },
                        new
                        {
                            Id = -5,
                            Continent = "Asia",
                            CountryName = "Japan"
                        },
                        new
                        {
                            Id = -6,
                            Continent = "Australia",
                            CountryName = "Australia"
                        });
                });

            modelBuilder.Entity("LexiconMVC.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("LanguageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            LanguageName = "Swedish"
                        },
                        new
                        {
                            Id = -2,
                            LanguageName = "Japanese"
                        },
                        new
                        {
                            Id = -3,
                            LanguageName = "Norwegian"
                        },
                        new
                        {
                            Id = -4,
                            LanguageName = "Spanish"
                        },
                        new
                        {
                            Id = -5,
                            LanguageName = "English"
                        });
                });

            modelBuilder.Entity("LexiconMVC.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phonenumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            CityId = -1,
                            Name = "Simon Eliasson",
                            Phonenumber = 738450197
                        },
                        new
                        {
                            Id = -2,
                            CityId = -10,
                            Name = "Janne Karlsson",
                            Phonenumber = 709952132
                        },
                        new
                        {
                            Id = -3,
                            CityId = -2,
                            Name = "Annie Svensson",
                            Phonenumber = 782161234
                        },
                        new
                        {
                            Id = -4,
                            CityId = -3,
                            Name = "Kalle Carlsson",
                            Phonenumber = 741237894
                        },
                        new
                        {
                            Id = -5,
                            CityId = -4,
                            Name = "Andy Hjert",
                            Phonenumber = 738660102
                        },
                        new
                        {
                            Id = -6,
                            CityId = -5,
                            Name = "Björn Bergman",
                            Phonenumber = 759982251
                        },
                        new
                        {
                            Id = -7,
                            CityId = -6,
                            Name = "Sara Strand",
                            Phonenumber = 761496378
                        },
                        new
                        {
                            Id = -8,
                            CityId = -7,
                            Name = "Frida Svensson",
                            Phonenumber = 778852211
                        },
                        new
                        {
                            Id = -9,
                            CityId = -8,
                            Name = "Andy Karlsson",
                            Phonenumber = 778852211
                        },
                        new
                        {
                            Id = -10,
                            CityId = -9,
                            Name = "Charlie Svensson",
                            Phonenumber = 778852211
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "838d485a-48c3-436e-ab44-a46afe67257c",
                            ConcurrencyStamp = "75b109af-d495-4288-8b20-bebfe09348af",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "46b5071c-1990-45ce-a8eb-2f269290e337",
                            ConcurrencyStamp = "d9575d3c-ec23-4be7-bbc6-015a4ee407af",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "cc8a47a7-3061-4511-b5d2-fe92e9fbcaed",
                            RoleId = "838d485a-48c3-436e-ab44-a46afe67257c"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("LanguagePerson", b =>
                {
                    b.HasOne("LexiconMVC.Models.Language", null)
                        .WithMany()
                        .HasForeignKey("LanguagesListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LexiconMVC.Models.Person", null)
                        .WithMany()
                        .HasForeignKey("PeopleListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LexiconMVC.Models.City", b =>
                {
                    b.HasOne("LexiconMVC.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("LexiconMVC.Models.Person", b =>
                {
                    b.HasOne("LexiconMVC.Models.City", "City")
                        .WithMany("People")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("LexiconMVC.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("LexiconMVC.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LexiconMVC.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("LexiconMVC.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LexiconMVC.Models.City", b =>
                {
                    b.Navigation("People");
                });

            modelBuilder.Entity("LexiconMVC.Models.Country", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
