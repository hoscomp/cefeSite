﻿// <auto-generated />
using cefeAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace cefeAPI.Migrations
{
    [DbContext(typeof(PalestraDbContexto))]
    [Migration("20180502202136_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("cefeAPI.Models.Palestra", b =>
                {
                    b.Property<int>("IdPalestra")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataPalestra");

                    b.Property<string>("DiretorPalestra");

                    b.Property<string>("Palestrante");

                    b.Property<string>("Semana");

                    b.Property<string>("TemaPalestra");

                    b.HasKey("IdPalestra");

                    b.ToTable("palestra");
                });
#pragma warning restore 612, 618
        }
    }
}
