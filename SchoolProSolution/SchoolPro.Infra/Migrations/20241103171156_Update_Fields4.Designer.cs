﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SchoolPro.Infra.Context;

#nullable disable

namespace SchoolPro.Infra.Migrations
{
    [DbContext(typeof(SchoolProDbContext))]
    [Migration("20241103171156_Update_Fields4")]
    partial class Update_Fields4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SchoolPro.Core.Entities.AccessToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("ClientSchoolKey")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("client_school_key");

                    b.Property<DateOnly>("CreatedAt")
                        .HasColumnType("date")
                        .HasColumnName("created_at");

                    b.Property<DateOnly?>("DeletedAt")
                        .HasColumnType("date")
                        .HasColumnName("deleted_at");

                    b.Property<DateOnly?>("ExpiringAt")
                        .IsRequired()
                        .HasColumnType("date")
                        .HasColumnName("expiring_at");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("is_active");

                    b.Property<TimeOnly?>("TimedAt")
                        .IsRequired()
                        .HasColumnType("time without time zone")
                        .HasColumnName("timed_at");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("token");

                    b.Property<DateOnly?>("UpdatedAt")
                        .HasColumnType("date")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("Access_Token", (string)null);
                });

            modelBuilder.Entity("SchoolPro.Core.Entities.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("ClientKey")
                        .HasColumnType("uuid")
                        .HasColumnName("client_key");

                    b.Property<DateOnly>("CreatedAt")
                        .HasColumnType("date")
                        .HasColumnName("created_at");

                    b.Property<DateOnly?>("DeletedAt")
                        .HasColumnType("date")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("description");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("is_active");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("name");

                    b.Property<string>("ResponsableCellPhone1")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("responsable_cellphone_1");

                    b.Property<string>("ResponsableCellPhone2")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("responsable_cellphone_2");

                    b.Property<string>("ResponsableEmail")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("responsable_email");

                    b.Property<string>("ResponsableName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("responsable_name");

                    b.Property<DateOnly?>("UpdatedAt")
                        .HasColumnType("date")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("Client", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("9cf0bfd2-3d70-11ef-a3ab-0242ac1c0002"),
                            ClientKey = new Guid("45533ff6-3ba5-11ef-9476-0242ac130002"),
                            CreatedAt = new DateOnly(2024, 11, 3),
                            Description = "Rede de Ensino 123 de Oliveira 4",
                            IsActive = true,
                            Name = "Rede de Ensino 123 de Oliveira 4",
                            ResponsableCellPhone1 = "(11) 11111-1111",
                            ResponsableCellPhone2 = "(22) 22222-2222",
                            ResponsableEmail = "joao.silva@123deoliveira4.com",
                            ResponsableName = "João da Silva"
                        });
                });

            modelBuilder.Entity("SchoolPro.Core.Entities.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("AddressLine2")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)")
                        .HasColumnName("address_line_2");

                    b.Property<string>("CellPhone")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("cellphone");

                    b.Property<string>("City")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)")
                        .HasColumnName("city");

                    b.Property<string>("ClientSchoolKey")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("client_school_key");

                    b.Property<DateOnly>("CreatedAt")
                        .HasColumnType("date")
                        .HasColumnName("created_at");

                    b.Property<DateOnly?>("DeletedAt")
                        .HasColumnType("date")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("email");

                    b.Property<string>("Facebook")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("facebook");

                    b.Property<string>("Github")
                        .HasMaxLength(11)
                        .HasColumnType("character varying(11)")
                        .HasColumnName("github");

                    b.Property<string>("Instagram")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("instagram");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("is_active");

                    b.Property<string>("LinkedIn")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("linkedin");

                    b.Property<string>("Neighborhood")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)")
                        .HasColumnName("neighborhood");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(9)
                        .HasColumnType("character varying(9)")
                        .HasColumnName("postal_code");

                    b.Property<string>("State")
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)")
                        .HasColumnName("state");

                    b.Property<string>("StreetAddress")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)")
                        .HasColumnName("street_address");

                    b.Property<string>("Telephone")
                        .HasMaxLength(14)
                        .HasColumnType("character varying(14)")
                        .HasColumnName("telephone");

                    b.Property<string>("Twitter")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("twitter");

                    b.Property<DateOnly?>("UpdatedAt")
                        .HasColumnType("date")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("Contact", (string)null);
                });

            modelBuilder.Entity("SchoolPro.Core.Entities.Document", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("ClientSchoolKey")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("client_school_key");

                    b.Property<DateOnly>("CreatedAt")
                        .HasColumnType("date")
                        .HasColumnName("created_at");

                    b.Property<DateOnly?>("DeletedAt")
                        .HasColumnType("date")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("description");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)")
                        .HasColumnName("file_path");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("is_active");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uuid")
                        .HasColumnName("parent_id");

                    b.Property<Guid?>("SchoolId")
                        .HasColumnType("uuid")
                        .HasColumnName("school_id");

                    b.Property<Guid?>("StudentId")
                        .HasColumnType("uuid")
                        .HasColumnName("student_id");

                    b.Property<Guid?>("TeacherId")
                        .HasColumnType("uuid")
                        .HasColumnName("teacher_id");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("title");

                    b.Property<DateOnly?>("UpdatedAt")
                        .HasColumnType("date")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.HasIndex("SchoolId");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Document", (string)null);
                });

            modelBuilder.Entity("SchoolPro.Core.Entities.Parent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateOnly?>("Birthdate")
                        .HasColumnType("date")
                        .HasColumnName("birthdate");

                    b.Property<string>("ClientSchoolKey")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("client_school_key");

                    b.Property<Guid?>("ContactId")
                        .HasColumnType("uuid")
                        .HasColumnName("contact_id");

                    b.Property<DateOnly>("CreatedAt")
                        .HasColumnType("date")
                        .HasColumnName("created_at");

                    b.Property<DateOnly?>("DeletedAt")
                        .HasColumnType("date")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Gender")
                        .HasMaxLength(1)
                        .HasColumnType("character varying(1)")
                        .HasColumnName("gender");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("is_active");

                    b.Property<string>("Kinship")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("kinship");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("name");

                    b.Property<DateOnly?>("UpdatedAt")
                        .HasColumnType("date")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.ToTable("Parent", (string)null);
                });

            modelBuilder.Entity("SchoolPro.Core.Entities.School", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("character varying(14)")
                        .HasColumnName("cnpj");

                    b.Property<Guid?>("ClientId")
                        .IsRequired()
                        .HasColumnType("uuid")
                        .HasColumnName("client_id");

                    b.Property<Guid?>("ContactId")
                        .HasColumnType("uuid")
                        .HasColumnName("contact_id");

                    b.Property<string>("CountyRegistration")
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)")
                        .HasColumnName("count_registration");

                    b.Property<DateOnly>("CreatedAt")
                        .HasColumnType("date")
                        .HasColumnName("created_at");

                    b.Property<DateOnly?>("DeletedAt")
                        .HasColumnType("date")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("description");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("is_active");

                    b.Property<bool>("IsBranch")
                        .HasColumnType("boolean")
                        .HasColumnName("is_branch");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("name");

                    b.Property<Guid>("SchoolKey")
                        .HasColumnType("uuid")
                        .HasColumnName("school_key");

                    b.Property<string>("StateRegistration")
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)")
                        .HasColumnName("state_registration");

                    b.Property<DateOnly?>("UpdatedAt")
                        .HasColumnType("date")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("ContactId");

                    b.ToTable("School", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("9cf0bfd2-3d70-11ef-a3ab-0242ac1c0002"),
                            CNPJ = "12345678000199",
                            ClientId = new Guid("9cf0bfd2-3d70-11ef-a3ab-0242ac1c0002"),
                            CreatedAt = new DateOnly(2024, 11, 3),
                            Description = "Matriz da Rede de Ensino 123 de Oliveira 4",
                            IsActive = true,
                            IsBranch = false,
                            Name = "Matriz da Rede de Ensino 123 de Oliveira 4",
                            SchoolKey = new Guid("6c9b91d0-3ba5-11ef-9476-0242ac130002")
                        });
                });

            modelBuilder.Entity("SchoolPro.Core.Entities.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateOnly?>("Birthdate")
                        .HasColumnType("date")
                        .HasColumnName("birthdate");

                    b.Property<string>("ClientSchoolKey")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("client_school_key");

                    b.Property<Guid?>("ContactId")
                        .HasColumnType("uuid")
                        .HasColumnName("contact_id");

                    b.Property<DateOnly>("CreatedAt")
                        .HasColumnType("date")
                        .HasColumnName("created_at");

                    b.Property<DateOnly?>("DeletedAt")
                        .HasColumnType("date")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .HasMaxLength(1)
                        .HasColumnType("character varying(1)")
                        .HasColumnName("description");

                    b.Property<string>("Gender")
                        .HasMaxLength(1)
                        .HasColumnType("character varying(1)")
                        .HasColumnName("gender");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("is_active");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("name");

                    b.Property<DateOnly?>("UpdatedAt")
                        .HasColumnType("date")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.ToTable("Student", (string)null);
                });

            modelBuilder.Entity("SchoolPro.Core.Entities.StudentParent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("ClientSchoolKey")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("client_school_key");

                    b.Property<DateOnly>("CreatedAt")
                        .HasColumnType("date")
                        .HasColumnName("created_at");

                    b.Property<DateOnly?>("DeletedAt")
                        .HasColumnType("date")
                        .HasColumnName("deleted_at");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("is_active");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uuid")
                        .HasColumnName("parent_id");

                    b.Property<Guid?>("StudentId")
                        .HasColumnType("uuid")
                        .HasColumnName("student_id");

                    b.Property<DateOnly?>("UpdatedAt")
                        .HasColumnType("date")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.HasIndex("StudentId");

                    b.ToTable("Student_Parent", (string)null);
                });

            modelBuilder.Entity("SchoolPro.Core.Entities.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateOnly?>("Birthdate")
                        .HasColumnType("date")
                        .HasColumnName("birthdate");

                    b.Property<string>("ClientSchoolKey")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("client_school_key");

                    b.Property<Guid?>("ContactId")
                        .HasColumnType("uuid")
                        .HasColumnName("contact_id");

                    b.Property<DateOnly>("CreatedAt")
                        .HasColumnType("date")
                        .HasColumnName("created_at");

                    b.Property<DateOnly?>("DeletedAt")
                        .HasColumnType("date")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("description");

                    b.Property<string>("Gender")
                        .HasMaxLength(1)
                        .HasColumnType("character varying(1)")
                        .HasColumnName("gender");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("is_active");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("name");

                    b.Property<DateOnly?>("UpdatedAt")
                        .HasColumnType("date")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.ToTable("Teacher", (string)null);
                });

            modelBuilder.Entity("SchoolPro.Core.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid?>("AccessTokenId")
                        .HasColumnType("uuid")
                        .HasColumnName("access_token_id");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uuid")
                        .HasColumnName("client_id");

                    b.Property<DateOnly>("CreatedAt")
                        .HasColumnType("date")
                        .HasColumnName("created_at");

                    b.Property<DateOnly?>("DeletedAt")
                        .HasColumnType("date")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("email");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("is_active");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("password");

                    b.Property<string>("PicturePath")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("picture_path");

                    b.Property<DateOnly?>("UpdatedAt")
                        .HasColumnType("date")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("AccessTokenId");

                    b.HasIndex("ClientId");

                    b.ToTable("User", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("9a150059-614b-47c3-b56f-59deededd8d6"),
                            ClientId = new Guid("9cf0bfd2-3d70-11ef-a3ab-0242ac1c0002"),
                            CreatedAt = new DateOnly(2024, 11, 3),
                            Email = "marcelo@schoolpro.com",
                            IsActive = true,
                            Name = "Marcelo de Oliveira",
                            Password = "123"
                        });
                });

            modelBuilder.Entity("SchoolPro.Core.Entities.Document", b =>
                {
                    b.HasOne("SchoolPro.Core.Entities.Parent", "Parent")
                        .WithMany("Documents")
                        .HasForeignKey("ParentId")
                        .HasConstraintName("parent_Id");

                    b.HasOne("SchoolPro.Core.Entities.School", "School")
                        .WithMany("Documents")
                        .HasForeignKey("SchoolId")
                        .HasConstraintName("school_Id");

                    b.HasOne("SchoolPro.Core.Entities.Student", "Student")
                        .WithMany("Documents")
                        .HasForeignKey("StudentId")
                        .HasConstraintName("student_Id");

                    b.HasOne("SchoolPro.Core.Entities.Teacher", "Teacher")
                        .WithMany("Documents")
                        .HasForeignKey("TeacherId")
                        .HasConstraintName("teacher_Id");

                    b.Navigation("Parent");

                    b.Navigation("School");

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("SchoolPro.Core.Entities.Parent", b =>
                {
                    b.HasOne("SchoolPro.Core.Entities.Contact", "Contact")
                        .WithMany()
                        .HasForeignKey("ContactId");

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("SchoolPro.Core.Entities.School", b =>
                {
                    b.HasOne("SchoolPro.Core.Entities.Client", "Client")
                        .WithMany("Schools")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolPro.Core.Entities.Contact", "Contact")
                        .WithMany()
                        .HasForeignKey("ContactId");

                    b.Navigation("Client");

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("SchoolPro.Core.Entities.Student", b =>
                {
                    b.HasOne("SchoolPro.Core.Entities.Contact", "Contact")
                        .WithMany()
                        .HasForeignKey("ContactId");

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("SchoolPro.Core.Entities.StudentParent", b =>
                {
                    b.HasOne("SchoolPro.Core.Entities.Parent", "Parent")
                        .WithMany("StudentParents")
                        .HasForeignKey("ParentId")
                        .HasConstraintName("parent_id");

                    b.HasOne("SchoolPro.Core.Entities.Student", "Student")
                        .WithMany("StudentParents")
                        .HasForeignKey("StudentId")
                        .HasConstraintName("student_id");

                    b.Navigation("Parent");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("SchoolPro.Core.Entities.Teacher", b =>
                {
                    b.HasOne("SchoolPro.Core.Entities.Contact", "Contact")
                        .WithMany()
                        .HasForeignKey("ContactId");

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("SchoolPro.Core.Entities.User", b =>
                {
                    b.HasOne("SchoolPro.Core.Entities.AccessToken", "AccessToken")
                        .WithMany()
                        .HasForeignKey("AccessTokenId");

                    b.HasOne("SchoolPro.Core.Entities.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccessToken");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("SchoolPro.Core.Entities.Client", b =>
                {
                    b.Navigation("Schools");
                });

            modelBuilder.Entity("SchoolPro.Core.Entities.Parent", b =>
                {
                    b.Navigation("Documents");

                    b.Navigation("StudentParents");
                });

            modelBuilder.Entity("SchoolPro.Core.Entities.School", b =>
                {
                    b.Navigation("Documents");
                });

            modelBuilder.Entity("SchoolPro.Core.Entities.Student", b =>
                {
                    b.Navigation("Documents");

                    b.Navigation("StudentParents");
                });

            modelBuilder.Entity("SchoolPro.Core.Entities.Teacher", b =>
                {
                    b.Navigation("Documents");
                });
#pragma warning restore 612, 618
        }
    }
}
