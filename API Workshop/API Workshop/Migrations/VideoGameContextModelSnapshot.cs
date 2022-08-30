﻿// <auto-generated />
using API_Workshop;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_Workshop.Migrations
{
    [DbContext(typeof(VideoGameContext))]
    partial class VideoGameContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("API_Workshop.GameTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.Property<int>("VideoGameId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TagId");

                    b.HasIndex("VideoGameId");

                    b.ToTable("GameTags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TagId = 1,
                            VideoGameId = 1
                        });
                });

            modelBuilder.Entity("API_Workshop.MainCharacter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MainCharacters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mario"
                        });
                });

            modelBuilder.Entity("API_Workshop.Studio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EmployeeCount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Studios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmployeeCount = 6500,
                            Name = "Nintendo"
                        });
                });

            modelBuilder.Entity("API_Workshop.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Platformer"
                        });
                });

            modelBuilder.Entity("API_Workshop.VideoGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MainCharacterId")
                        .HasColumnType("int");

                    b.Property<int>("StudioId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MainCharacterId")
                        .IsUnique();

                    b.HasIndex("StudioId");

                    b.ToTable("VideoGames");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MainCharacterId = 1,
                            StudioId = 1,
                            Title = "Super Mario Brothers"
                        });
                });

            modelBuilder.Entity("API_Workshop.GameTag", b =>
                {
                    b.HasOne("API_Workshop.Tag", "Tag")
                        .WithMany("VideoGames")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API_Workshop.VideoGame", "VideoGame")
                        .WithMany("Tags")
                        .HasForeignKey("VideoGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tag");

                    b.Navigation("VideoGame");
                });

            modelBuilder.Entity("API_Workshop.VideoGame", b =>
                {
                    b.HasOne("API_Workshop.MainCharacter", "MainCharacter")
                        .WithOne("VideoGame")
                        .HasForeignKey("API_Workshop.VideoGame", "MainCharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API_Workshop.Studio", "Studio")
                        .WithMany("VideoGames")
                        .HasForeignKey("StudioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MainCharacter");

                    b.Navigation("Studio");
                });

            modelBuilder.Entity("API_Workshop.MainCharacter", b =>
                {
                    b.Navigation("VideoGame")
                        .IsRequired();
                });

            modelBuilder.Entity("API_Workshop.Studio", b =>
                {
                    b.Navigation("VideoGames");
                });

            modelBuilder.Entity("API_Workshop.Tag", b =>
                {
                    b.Navigation("VideoGames");
                });

            modelBuilder.Entity("API_Workshop.VideoGame", b =>
                {
                    b.Navigation("Tags");
                });
#pragma warning restore 612, 618
        }
    }
}
