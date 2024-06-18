using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_APICURSO.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, " ", "Detalle Paraiso", new DateTime(2024, 5, 31, 19, 2, 39, 219, DateTimeKind.Local).AddTicks(1871), new DateTime(2024, 5, 31, 19, 2, 39, 219, DateTimeKind.Local).AddTicks(1861), " ", 255, "Villa Paraiso", 5, 300.0 },
                    { 2, " ", "Detalle Selva", new DateTime(2024, 5, 31, 19, 2, 39, 219, DateTimeKind.Local).AddTicks(1874), new DateTime(2024, 5, 31, 19, 2, 39, 219, DateTimeKind.Local).AddTicks(1873), " ", 255, "Villa Selva", 2, 350.0 },
                    { 3, " ", "Detalle Tropical", new DateTime(2024, 5, 31, 19, 2, 39, 219, DateTimeKind.Local).AddTicks(1876), new DateTime(2024, 5, 31, 19, 2, 39, 219, DateTimeKind.Local).AddTicks(1875), " ", 500, "Villa Tropical", 6, 850.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
