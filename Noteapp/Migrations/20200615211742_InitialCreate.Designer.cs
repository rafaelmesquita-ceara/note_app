﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Noteapp.Database;

namespace Noteapp.Migrations
{
    [DbContext(typeof(NoteAppContext))]
    [Migration("20200615211742_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Noteapp.Models.NotesSet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CH_Description")
                        .HasColumnType("text");

                    b.Property<string>("CH_Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("DT_Creation")
                        .HasColumnType("datetime");

                    b.HasKey("ID");

                    b.ToTable("Note");
                });
#pragma warning restore 612, 618
        }
    }
}
