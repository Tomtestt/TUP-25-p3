﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using servidor.ModeloDatos;

#nullable disable

namespace servidor.Migrations.TiendaContextoMigrations
{
    [DbContext(typeof(TiendaContexto))]
    partial class TiendaContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.6");

            modelBuilder.Entity("servidor.ModeloDatos.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ApellidoCliente")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailCliente")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreCliente")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Total")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("servidor.ModeloDatos.ItemCompra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CompraId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CompraId");

                    b.HasIndex("ProductoId");

                    b.ToTable("ItemsCompra");
                });

            modelBuilder.Entity("servidor.ModeloDatos.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Categoria")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagenUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Precio")
                        .HasColumnType("TEXT");

                    b.Property<int>("Stock")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Categoria = "",
                            Descripcion = "Pantalla 6.6'' - 128GB - 4GB RAM",
                            ImagenUrl = "img/a.jpg",
                            Nombre = "Celular Samsung A06",
                            Precio = 280000m,
                            Stock = 15
                        },
                        new
                        {
                            Id = 2,
                            Categoria = "",
                            Descripcion = "Smartphone de Apple con chip A17 Pro y cámara avanzada",
                            ImagenUrl = "img/iphone.jpg",
                            Nombre = "iPhone 15 Pro Max",
                            Precio = 1950000m,
                            Stock = 30
                        },
                        new
                        {
                            Id = 3,
                            Categoria = "",
                            Descripcion = "Notebook liviana con procesador Apple Silicon M3",
                            ImagenUrl = "img/macbook-air.jpg",
                            Nombre = "Apple MacBook Air M3",
                            Precio = 2100000m,
                            Stock = 15
                        },
                        new
                        {
                            Id = 4,
                            Categoria = "",
                            Descripcion = "Consola de videojuegos de Sony con diseño más delgado",
                            ImagenUrl = "img/PlayStation5.jpg",
                            Nombre = "PlayStation 5 Slim",
                            Precio = 950000m,
                            Stock = 25
                        },
                        new
                        {
                            Id = 5,
                            Categoria = "",
                            Descripcion = "Consola de Microsoft con 1 TB de almacenamiento y juegos 4K",
                            ImagenUrl = "img/Microsoft-Xbox-Series-X.jpg",
                            Nombre = "Xbox Series X",
                            Precio = 870000m,
                            Stock = 12
                        },
                        new
                        {
                            Id = 6,
                            Categoria = "",
                            Descripcion = "Intel i5 - 8GB RAM - 256GB SSD",
                            ImagenUrl = "img/notebook-hp-.jpg",
                            Nombre = "Notebook HP 14",
                            Precio = 385000m,
                            Stock = 5
                        },
                        new
                        {
                            Id = 7,
                            Categoria = "",
                            Descripcion = "Ergonómica, reclinable, color negro y rojo",
                            ImagenUrl = "img/sillaGamer.jpg",
                            Nombre = "Silla Gamer",
                            Precio = 115000m,
                            Stock = 7
                        },
                        new
                        {
                            Id = 8,
                            Categoria = "",
                            Descripcion = "Reloj inteligente con sensores de salud y chip S9.",
                            ImagenUrl = "img/aple-watch.jpg",
                            Nombre = "Apple Watch Series 9",
                            Precio = 420000m,
                            Stock = 50
                        },
                        new
                        {
                            Id = 9,
                            Categoria = "",
                            Descripcion = "Full HD - HDMI - VGA",
                            ImagenUrl = "img/monitor.jpg",
                            Nombre = "Monitor LED 24",
                            Precio = 95000m,
                            Stock = 10
                        },
                        new
                        {
                            Id = 10,
                            Categoria = "",
                            Descripcion = "Auriculares con cancelación de ruido y sonido espacial",
                            ImagenUrl = "img/AirPods-si.jpg",
                            Nombre = "AirPods Pro 2 (USB-C)",
                            Precio = 127000m,
                            Stock = 18
                        });
                });

            modelBuilder.Entity("servidor.ModeloDatos.ItemCompra", b =>
                {
                    b.HasOne("servidor.ModeloDatos.Compra", "Compra")
                        .WithMany("ItemsCompra")
                        .HasForeignKey("CompraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("servidor.ModeloDatos.Producto", "Producto")
                        .WithMany("ItemsCompra")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Compra");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("servidor.ModeloDatos.Compra", b =>
                {
                    b.Navigation("ItemsCompra");
                });

            modelBuilder.Entity("servidor.ModeloDatos.Producto", b =>
                {
                    b.Navigation("ItemsCompra");
                });
#pragma warning restore 612, 618
        }
    }
}
