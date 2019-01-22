﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using System.Entities;

namespace System.Entities.Migrations
{
    [DbContext(typeof(SystemContext))]
    partial class SystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("System.Entities.Auditoria", b =>
                {
                    b.Property<int>("AuditoriaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Action");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Descripcion");

                    b.Property<string>("Entity");

                    b.Property<string>("EntityId");

                    b.Property<bool>("Habilitado");

                    b.Property<DateTime?>("TSCreate");

                    b.Property<DateTime?>("TSEliminado");

                    b.Property<DateTime?>("TSModificado");

                    b.Property<string>("TransactionId");

                    b.Property<string>("UserName");

                    b.Property<string>("Value");

                    b.HasKey("AuditoriaId");

                    b.ToTable("Auditoria");
                });

            modelBuilder.Entity("System.Entities.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("System.Entities.Marca", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.HasKey("MarcaId");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("System.Entities.Parametro", b =>
                {
                    b.Property<int>("ParametroId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Categoria");

                    b.Property<string>("Clave");

                    b.Property<string>("Descripcion");

                    b.Property<string>("Valor");

                    b.HasKey("ParametroId");

                    b.ToTable("Parametro");
                });

            modelBuilder.Entity("System.Entities.Permiso", b =>
                {
                    b.Property<int>("PermisoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.Property<string>("Funcionalidad");

                    b.Property<int>("VistaId");

                    b.HasKey("PermisoId");

                    b.HasIndex("VistaId");

                    b.ToTable("Permiso");
                });

            modelBuilder.Entity("System.Entities.Producto", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BreveDescripcion");

                    b.Property<int>("Cantidad");

                    b.Property<int>("CategoriaId");

                    b.Property<int>("Codigo");

                    b.Property<string>("Estado");

                    b.Property<string>("Imagen");

                    b.Property<int>("MarcaId");

                    b.Property<string>("Nombre");

                    b.Property<int>("Precio");

                    b.HasKey("ProductoId");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("MarcaId");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("System.Entities.Rol", b =>
                {
                    b.Property<int>("RolId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo");

                    b.Property<string>("Nombre");

                    b.HasKey("RolId");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("System.Entities.RolPermiso", b =>
                {
                    b.Property<int>("RolId");

                    b.Property<int>("PermisoId");

                    b.HasKey("RolId", "PermisoId");

                    b.HasIndex("PermisoId");

                    b.ToTable("RolPermiso");
                });

            modelBuilder.Entity("System.Entities.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido");

                    b.Property<string>("Contrasena");

                    b.Property<bool>("ContrasenaActualizada");

                    b.Property<string>("Email");

                    b.Property<bool>("Habilitado");

                    b.Property<string>("Nombre");

                    b.Property<DateTime>("TSCreado");

                    b.Property<DateTime?>("TSEliminado");

                    b.Property<DateTime?>("TSModificado");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("System.Entities.UsuarioRol", b =>
                {
                    b.Property<int>("RolId");

                    b.Property<int>("UsuarioId");

                    b.HasKey("RolId", "UsuarioId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("UsuarioRol");
                });

            modelBuilder.Entity("System.Entities.UsuarioToken", b =>
                {
                    b.Property<int>("UsuarioTokenId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("FechaExpiracion");

                    b.Property<string>("Token");

                    b.Property<bool>("Usado");

                    b.Property<int>("UsuarioId");

                    b.HasKey("UsuarioTokenId");

                    b.ToTable("UsuarioToken");
                });

            modelBuilder.Entity("System.Entities.Vista", b =>
                {
                    b.Property<int>("VistaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.Property<string>("Nombre");

                    b.HasKey("VistaId");

                    b.ToTable("Vista");
                });

            modelBuilder.Entity("System.Entities.Permiso", b =>
                {
                    b.HasOne("System.Entities.Vista", "Vista")
                        .WithMany("Permisos")
                        .HasForeignKey("VistaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("System.Entities.Producto", b =>
                {
                    b.HasOne("System.Entities.Categoria", "Categoria")
                        .WithMany("Productos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("System.Entities.Marca", "Marca")
                        .WithMany("Productos")
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("System.Entities.RolPermiso", b =>
                {
                    b.HasOne("System.Entities.Permiso", "Permiso")
                        .WithMany("RolPermisos")
                        .HasForeignKey("PermisoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("System.Entities.Rol", "Rol")
                        .WithMany("RolPermisos")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("System.Entities.UsuarioRol", b =>
                {
                    b.HasOne("System.Entities.Rol", "Rol")
                        .WithMany("UsuarioRoles")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("System.Entities.Usuario", "Usuario")
                        .WithMany("UsuarioRoles")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
