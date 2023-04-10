﻿// <auto-generated />
using System;
using ApiProjetCube.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiProjetCube.Migrations
{
    [DbContext(typeof(TestContext))]
    [Migration("20230410084430_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ApiProjetCube.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ApiProjetCube.Models.DocumentImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdRessource")
                        .HasColumnType("int");

                    b.Property<string>("LienImage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdRessource");

                    b.ToTable("DocumentImages");
                });

            modelBuilder.Entity("ApiProjetCube.Models.DocumentPdf", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdRessource")
                        .HasColumnType("int");

                    b.Property<string>("LienPdf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdRessource");

                    b.ToTable("DocumentPdfs");
                });

            modelBuilder.Entity("ApiProjetCube.Models.MessageForum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdUtilisateur")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdUtilisateur");

                    b.ToTable("MessagesForums");
                });

            modelBuilder.Entity("ApiProjetCube.Models.Ressource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdCategory")
                        .HasColumnType("int");

                    b.Property<int>("IdUtilisateur")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TypeRelation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("contents")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdCategory");

                    b.HasIndex("IdUtilisateur");

                    b.ToTable("Ressources");
                });

            modelBuilder.Entity("ApiProjetCube.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("ApiProjetCube.Models.SubjectForum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdCategorie")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdCategorie");

                    b.ToTable("SubjectsForums");
                });

            modelBuilder.Entity("ApiProjetCube.Models.Utilisateur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdRole")
                        .HasColumnType("int");

                    b.Property<bool>("IsActiver")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdRole");

                    b.ToTable("Utilisateurs");
                });

            modelBuilder.Entity("ApiProjetCube.Models.DocumentImage", b =>
                {
                    b.HasOne("ApiProjetCube.Models.Ressource", "Ressource")
                        .WithMany("DocumentImages")
                        .HasForeignKey("IdRessource")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_DocumentImages_Ressources");

                    b.Navigation("Ressource");
                });

            modelBuilder.Entity("ApiProjetCube.Models.DocumentPdf", b =>
                {
                    b.HasOne("ApiProjetCube.Models.Ressource", "Ressource")
                        .WithMany("DocumentPdfs")
                        .HasForeignKey("IdRessource")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_DocumentPdfs_Ressources");

                    b.Navigation("Ressource");
                });

            modelBuilder.Entity("ApiProjetCube.Models.MessageForum", b =>
                {
                    b.HasOne("ApiProjetCube.Models.Utilisateur", "Utilisateur")
                        .WithMany("MessagesForums")
                        .HasForeignKey("IdUtilisateur")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_MessagesForums_Utilisateurs");

                    b.Navigation("Utilisateur");
                });

            modelBuilder.Entity("ApiProjetCube.Models.Ressource", b =>
                {
                    b.HasOne("ApiProjetCube.Models.Category", "Category")
                        .WithMany("Ressources")
                        .HasForeignKey("IdCategory")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Ressources_Categories");

                    b.HasOne("ApiProjetCube.Models.Utilisateur", "Utilisateur")
                        .WithMany("Ressources")
                        .HasForeignKey("IdUtilisateur")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Ressources_Utilisateurs");

                    b.Navigation("Category");

                    b.Navigation("Utilisateur");
                });

            modelBuilder.Entity("ApiProjetCube.Models.SubjectForum", b =>
                {
                    b.HasOne("ApiProjetCube.Models.Category", "Category")
                        .WithMany("SubjectsForums")
                        .HasForeignKey("IdCategorie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_SubjectsForums_Categories");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ApiProjetCube.Models.Utilisateur", b =>
                {
                    b.HasOne("ApiProjetCube.Models.Role", "Role")
                        .WithMany("Utilisateurs")
                        .HasForeignKey("IdRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Utilisateurs_Roles");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ApiProjetCube.Models.Category", b =>
                {
                    b.Navigation("Ressources");

                    b.Navigation("SubjectsForums");
                });

            modelBuilder.Entity("ApiProjetCube.Models.Ressource", b =>
                {
                    b.Navigation("DocumentImages");

                    b.Navigation("DocumentPdfs");
                });

            modelBuilder.Entity("ApiProjetCube.Models.Role", b =>
                {
                    b.Navigation("Utilisateurs");
                });

            modelBuilder.Entity("ApiProjetCube.Models.Utilisateur", b =>
                {
                    b.Navigation("MessagesForums");

                    b.Navigation("Ressources");
                });
#pragma warning restore 612, 618
        }
    }
}
