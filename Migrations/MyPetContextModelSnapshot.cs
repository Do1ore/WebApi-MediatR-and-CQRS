﻿// <auto-generated />
using System;
using CleanWebAPI.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CleanWebAPI.Migrations
{
    [DbContext(typeof(MyPetContext))]
    partial class MyPetContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AspNetUserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.AspNetRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "NormalizedName" }, "RoleNameIndex")
                        .IsUnique()
                        .HasFilter("([NormalizedName] IS NOT NULL)");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.AspNetRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "RoleId" }, "IX_AspNetRoleClaims_RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.AspNetUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

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

                    b.Property<string>("PathToProfileImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RegistrationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "NormalizedEmail" }, "EmailIndex");

                    b.HasIndex(new[] { "NormalizedUserName" }, "UserNameIndex")
                        .IsUnique()
                        .HasFilter("([NormalizedUserName] IS NOT NULL)");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.AspNetUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "UserId" }, "IX_AspNetUserClaims_UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.AspNetUserLogin", b =>
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

                    b.HasIndex(new[] { "UserId" }, "IX_AspNetUserLogins_UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.AspNetUserToken", b =>
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

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "UserId" }, "IX_Carts_UserId")
                        .IsUnique()
                        .HasFilter("([UserId] IS NOT NULL)");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.CartProduct", b =>
                {
                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("ProductModelId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartId", "ProductId");

                    b.HasIndex(new[] { "ProductModelId" }, "IX_CartProducts_ProductModelId");

                    b.ToTable("CartProducts");
                });

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.ExtraImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileSource")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "ProductModelId" }, "IX_ExtraImages_ProductModelId");

                    b.ToTable("ExtraImages");
                });

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.MyPetUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PathToProfileImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RegistrationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MyPetUser", (string)null);
                });

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.NewsApiSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateTo")
                        .HasColumnType("datetime2");

                    b.Property<string>("Domains")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PageSize")
                        .HasColumnType("int");

                    b.Property<string>("SearchTerm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sourses")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NewsApiSettings");
                });

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<double?>("DefaultPrice")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastTimeEdited")
                        .HasColumnType("datetime2");

                    b.Property<string>("MainFileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainFilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("MaxPrice")
                        .HasColumnType("float");

                    b.Property<double?>("MinPrice")
                        .HasColumnType("float");

                    b.Property<string>("ParsedUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductExtendedFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.ProductReview", b =>
                {
                    b.Property<Guid>("ReviewId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                    b.Property<int>("ReviewMark")
                        .HasColumnType("int");

                    b.Property<Guid>("ReviewStorageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ReviewText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReviewId");

                    b.HasIndex(new[] { "ProductId" }, "IX_ProductReviews_ProductId");

                    b.HasIndex(new[] { "ReviewStorageId" }, "IX_ProductReviews_ReviewStorageId");

                    b.ToTable("ProductReviews");
                });

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.ReviewStorage", b =>
                {
                    b.Property<Guid>("ReviewStorageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MyPetUserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ReviewStorageId");

                    b.HasIndex(new[] { "MyPetUserId" }, "IX_ReviewStorages_MyPetUserId");

                    b.ToTable("ReviewStorages");
                });

            modelBuilder.Entity("AspNetUserRole", b =>
                {
                    b.HasOne("CleanWebAPI.Models.MainModels.AspNetRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CleanWebAPI.Models.MainModels.AspNetUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.AspNetRoleClaim", b =>
                {
                    b.HasOne("CleanWebAPI.Models.MainModels.AspNetRole", "Role")
                        .WithMany("AspNetRoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.AspNetUserClaim", b =>
                {
                    b.HasOne("CleanWebAPI.Models.MainModels.AspNetUser", "User")
                        .WithMany("AspNetUserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.AspNetUserLogin", b =>
                {
                    b.HasOne("CleanWebAPI.Models.MainModels.AspNetUser", "User")
                        .WithMany("AspNetUserLogins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.AspNetUserToken", b =>
                {
                    b.HasOne("CleanWebAPI.Models.MainModels.AspNetUser", "User")
                        .WithMany("AspNetUserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.Cart", b =>
                {
                    b.HasOne("CleanWebAPI.Models.MainModels.MyPetUser", "User")
                        .WithOne("Cart")
                        .HasForeignKey("CleanWebAPI.Models.MainModels.Cart", "UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.CartProduct", b =>
                {
                    b.HasOne("CleanWebAPI.Models.MainModels.Cart", "Cart")
                        .WithMany("CartProducts")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CleanWebAPI.Models.MainModels.Product", "ProductModel")
                        .WithMany("CartProducts")
                        .HasForeignKey("ProductModelId");

                    b.Navigation("Cart");

                    b.Navigation("ProductModel");
                });

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.ExtraImage", b =>
                {
                    b.HasOne("CleanWebAPI.Models.MainModels.Product", "ProductModel")
                        .WithMany("ExtraImages")
                        .HasForeignKey("ProductModelId");

                    b.Navigation("ProductModel");
                });

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.ProductReview", b =>
                {
                    b.HasOne("CleanWebAPI.Models.MainModels.Product", "Product")
                        .WithMany("ProductReviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CleanWebAPI.Models.MainModels.ReviewStorage", "ReviewStorage")
                        .WithMany("ProductReviews")
                        .HasForeignKey("ReviewStorageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ReviewStorage");
                });

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.ReviewStorage", b =>
                {
                    b.HasOne("CleanWebAPI.Models.MainModels.MyPetUser", "MyPetUser")
                        .WithMany("ReviewStorages")
                        .HasForeignKey("MyPetUserId");

                    b.Navigation("MyPetUser");
                });

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.AspNetRole", b =>
                {
                    b.Navigation("AspNetRoleClaims");
                });

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.AspNetUser", b =>
                {
                    b.Navigation("AspNetUserClaims");

                    b.Navigation("AspNetUserLogins");

                    b.Navigation("AspNetUserTokens");
                });

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.Cart", b =>
                {
                    b.Navigation("CartProducts");
                });

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.MyPetUser", b =>
                {
                    b.Navigation("Cart");

                    b.Navigation("ReviewStorages");
                });

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.Product", b =>
                {
                    b.Navigation("CartProducts");

                    b.Navigation("ExtraImages");

                    b.Navigation("ProductReviews");
                });

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.ReviewStorage", b =>
                {
                    b.Navigation("ProductReviews");
                });
#pragma warning restore 612, 618
        }
    }
}
