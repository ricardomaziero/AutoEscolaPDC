﻿// <auto-generated />
using System;
using AutoEscolaPDC.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AutoEscolaPDC.Migrations
{
    [DbContext(typeof(AutoEscolaPDCContext))]
    [Migration("20211019162341_ArrumandoSexoAluno")]
    partial class ArrumandoSexoAluno
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AutoEscolaPDC.Pages.Alunos.Aluno", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("AutoEscolaPDC.Pages.Categorias.Categoria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.HasKey("ID");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("AutoEscolaPDC.Pages.Funcionarios.Funcionario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ANome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("DtAdmissao")
                        .HasColumnType("datetime2");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("ID");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("AutoEscolaPDC.Pages.Treinamentos.Treinamento", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlunoID")
                        .HasColumnType("int");

                    b.Property<int>("CategoriaID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DtInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("FuncionarioID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AlunoID");

                    b.HasIndex("CategoriaID");

                    b.HasIndex("FuncionarioID");

                    b.ToTable("Treinamentos");
                });

            modelBuilder.Entity("AutoEscolaPDC.Pages.Treinamentos.Treinamento", b =>
                {
                    b.HasOne("AutoEscolaPDC.Pages.Alunos.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoEscolaPDC.Pages.Categorias.Categoria", "Categoria")
                        .WithMany("Treinamentos")
                        .HasForeignKey("CategoriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoEscolaPDC.Pages.Funcionarios.Funcionario", "Funcionario")
                        .WithMany("Treinamentos")
                        .HasForeignKey("FuncionarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("Categoria");

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("AutoEscolaPDC.Pages.Categorias.Categoria", b =>
                {
                    b.Navigation("Treinamentos");
                });

            modelBuilder.Entity("AutoEscolaPDC.Pages.Funcionarios.Funcionario", b =>
                {
                    b.Navigation("Treinamentos");
                });
#pragma warning restore 612, 618
        }
    }
}
