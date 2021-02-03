﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesteEmpresa.Models;

namespace TesteEmpresa.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210202212524_Clientes")]
    partial class Clientes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TesteEmpresa.Models.Clientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNPJ")
                        .HasColumnType("nvarchar(14)")
                        .HasMaxLength(14);

                    b.Property<decimal>("Capital")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Classificacao")
                        .HasColumnType("nvarchar(1)")
                        .HasMaxLength(1);

                    b.Property<DateTime>("Data_Fundacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Quarentena")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)")
                        .HasMaxLength(1);

                    b.Property<string>("Razao_Social")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Status_Cliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)")
                        .HasMaxLength(1);

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });
#pragma warning restore 612, 618
        }
    }
}